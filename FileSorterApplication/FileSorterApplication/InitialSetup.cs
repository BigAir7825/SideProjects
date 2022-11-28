using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace FileSorterApplication
{
    internal class InitialSetup
    {
        private Dictionary<string, string> filePathsAndPurpose;
        private string baseFilePath = "C:\\Users";
        private KeyValuePair<string, string> college;
        private KeyValuePair<string, string> year;
        private KeyValuePair<string, string> semester;
        private KeyValuePair<string, string> focusArea;
        private KeyValuePair<string, string> subject;
        private KeyValuePair<string, string> section;
        public InitialSetup()
        {
            Console.WriteLine("This is the initial setup: READ ALL QUESTIONS CAREFULLY\n\n");
            getBaseFilePath();
            getCollegeInfo();
            foreach (var index in filePathsAndPurpose)
                write("paths.txt", $"{index.Value} - {index.Key}", true);
            makeDirectory();
            Console.WriteLine("Directory has been written, enter y if you are content with this, otherwise delete and restart");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Initial Setup complete, returning to main program");
                write("setUp.txt", "COMPLETE", false);
            }
            else
            {
                Console.WriteLine("Sorry about that");
                System.Environment.Exit(1);
            }
        }
        public string makeToPath(string baseFile, string newFile)
        {
            if (baseFile == "" || newFile == "")
                return null;
            return $"{baseFile}\\{newFile}";
        }
        public void getBaseFilePath()
        {
            baseFilePath += getInput("Enter the user name of the program user (i.e. C:\\Users\\[userName]): ");
            bool keepGoing = true;
            while (keepGoing)
            {
                string input = getInput($"Enter the location under use (i.e. {baseFilePath}\\[place]): if done enter DONE");
                switch (input)
                {
                    case "DONE":
                        keepGoing = false;
                        break;
                    default:
                        baseFilePath = makeToPath(baseFilePath, input);
                        break;
                }
            }
        }
        public string getInput(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
        public void write(string filePath, string text, bool overWrite)
        {
            WriteToFile writer = new WriteToFile(filePath, text, overWrite);
        }
        public void getCollegeInfo()
        {
            string collegeName = getInput("Give the college folder a name: ");
            string collegePath = makeToPath(baseFilePath, collegeName);
            college = new KeyValuePair<string, string>(collegeName, collegePath);
            filePathsAndPurpose.Add(collegePath, "COLLEGE");
            int numberOfYears = Convert.ToInt32(getInput("Enter the number of years in college (reccomended 4): "));
            for (int collegeYear = 1; collegeYear <= numberOfYears; collegeYear++)
                getYearInfo(collegeYear);
        }
        public void getYearInfo(int collegeYear)
        {
            string yearName = getInput($"Give a name for year {collegeYear}: ");
            string yearPath = makeToPath(college.Value, yearName);
            year = new KeyValuePair<string, string>(yearName, yearPath);
            filePathsAndPurpose.Add(yearPath, "YEAR");
            int numberOfSemesters = Convert.ToInt32(getInput($"Enter the number of semesters for year {collegeYear}: "));
            for (int semesterNumber = 1; semesterNumber <= numberOfSemesters; semesterNumber++)
                getSemesterInfo(semesterNumber);
        }
        public void getSemesterInfo(int semesterNumber)
        {
            string semesterName = getInput($"Give a name for semester {semesterNumber} of year {year.Key}: ");
            string semesterPath = makeToPath(year.Value, semesterName);
            semester = new KeyValuePair<string, string>(semesterName, semesterPath);
            filePathsAndPurpose.Add(semesterPath, "SEMESTER");
            int numberOfFocusAreas = Convert.ToInt32(getInput($"Enter the number of focus areas for year {year.Key}, semester {semesterNumber} (i.e. classes & internship): "));
            for (int focusAreaNumber = 1; focusAreaNumber <= numberOfFocusAreas; focusAreaNumber++)
                getFocusAreaInfo(focusAreaNumber);
        }
        public void getFocusAreaInfo(string semesterFilePath, int semesterFocus, int yearSemester, int collegeYear)
        {
            st
            string focusAreaPath = makeToPath(semesterFilePath, getInput($"Enter the name for focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            filePathsAndPurpose.Add(focusAreaPath, "FOCUSAREA");
            int numberOfSubjects = Convert.ToInt32(getInput($"Enter the number of subjects in focus areas for year {collegeYear}, semester {yearSemester}, focus area {semesterFocus} (i.e. number of classes): "));
            for (int subjectFocus = 1; subjectFocus <= numberOfSubjects; subjectFocus++)
                getSubjectInfo(focusAreaPath, subjectFocus, semesterFocus, yearSemester, collegeYear);
        }
        public void getSubjectInfo(string focusAreaFilePath, int subjectFocus, int semesterFocus, int yearSemester, int collegeYear)
        {
            string subjectPath = makeToPath(focusAreaFilePath, getInput($"Enter the name for subject {subjectFocus} of focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            filePathsAndPurpose.Add(subjectPath, "SUBJECT");
            int numberOfSections = Convert.ToInt32(getInput($"Enter the number of sections in subjects for year {collegeYear}, semester {yearSemester}, focus area {semesterFocus} (i.e. number of lab/lectures): "));
            for (int sectionSubject = 1; sectionSubject <= numberOfSections; sectionSubject++)
                getSectionInfo(subjectPath, sectionSubject, subjectFocus, semesterFocus, yearSemester, collegeYear);
        }
        public void getSectionInfo(string subjectFilePath, int sectionSubject, int subjectFocus, int semesterFocus, int yearSemester, int collegeYear)
        {
            string sectionPath = makeToPath(subjectFilePath, getInput($"Enter the name for section {sectionSubject} of subject {subjectFocus} of focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            filePathsAndPurpose.Add(sectionPath, "SECTION");
        }
        public void makeDirectory()
        {
            foreach (var index in filePathsAndPurpose)
            {
                if (!Directory.Exists(index.Key))
                    Directory.CreateDirectory(index.Key);
            }
        }
    }
}
