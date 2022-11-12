using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class InitialSetup
    {
        private Dictionary<string, string> toPrint;
        private string fileStub = "C:\\Users";
        public InitialSetup()
        {
            toPrint = new Dictionary<string, string>();
            Console.WriteLine("This is the initial setup: READ ALL QUESTIONS CAREFULLY\n\n");
            string userNameFilePath = makeValidFilePath(fileStub, getInput("Enter the User name of the windows user (i.e. C:\\Users\\{userName}): "));
            toPrint.Add(userNameFilePath, "USERNAME");
            getCollegeInfo(userNameFilePath);
            foreach (var index in toPrint)
                write("paths.txt", $"{index.Value} - {index.Key}", true);
            Console.WriteLine("Initial Setup complete, returning to main program");
            write("setUp.txt", "COMPLETE", false);
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
        public string makeValidFilePath(string input, string fileName)
        {
            return $"{input}\\{fileName}";
        }
        public void getCollegeInfo(string originalFilePath)
        {
            string collegePath = makeValidFilePath(originalFilePath, getInput("Enter the name of the college folder: "));
            toPrint.Add(collegePath, "COLLEGE");
            int numberOfYears = Convert.ToInt32(getInput("Enter the number of years in college (reccomended 4): "));
            for (int collegeYear = 1; collegeYear <= numberOfYears; collegeYear++)
                getYearInfo(collegePath, collegeYear);
        }
        public void getYearInfo(string collegeFilePath, int collegeYear)
        {
            string yearPath = makeValidFilePath(collegeFilePath, getInput($"Enter the name for year {collegeYear}: "));
            toPrint.Add(yearPath, "YEAR");
            int numberOfSemesters = Convert.ToInt32(getInput($"Enter the number of semesters for year {collegeYear}: "));
            for (int yearSemester = 1; yearSemester <= numberOfSemesters; yearSemester++)
                getSemesterInfo(yearPath, yearSemester, collegeYear);
        }
        public void getSemesterInfo(string yearFilePath, int yearSemester, int collegeYear)
        {
            string semesterPath = makeValidFilePath(yearFilePath, getInput($"Enter the name for semester {yearSemester} of {collegeYear}: "));
            toPrint.Add(semesterPath, "SEMESTER");
            int numberOfFocusAreas = Convert.ToInt32(getInput($"Enter the number of focus areas for year {collegeYear}, semester {yearSemester} (i.e. classes & internship): "));
            for (int semesterFocus = 1; semesterFocus <= numberOfFocusAreas; semesterFocus++)
                getFocusAreaInfo(semesterPath, semesterFocus, yearSemester, collegeYear);
        }
        public void getFocusAreaInfo(string semesterFilePath, int semesterFocus, int yearSemester, int collegeYear)
        {
            string focusAreaPath = makeValidFilePath(semesterFilePath, getInput($"Enter the name for focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            toPrint.Add(focusAreaPath, "FOCUSAREA");
            int numberOfSubjects = Convert.ToInt32(getInput($"Enter the number of subjects in focus areas for year {collegeYear}, semester {yearSemester}, focus area {semesterFocus} (i.e. number of classes): "));
            for (int subjectFocus = 1; subjectFocus <= numberOfSubjects; subjectFocus++)
                getSubjectInfo(focusAreaPath, subjectFocus, semesterFocus, yearSemester, collegeYear);
        }
        public void getSubjectInfo(string focusAreaFilePath, int subjectFocus, int semesterFocus, int yearSemester, int collegeYear)
        {
            string subjectPath = makeValidFilePath(focusAreaFilePath, getInput($"Enter the name for subject {subjectFocus} of focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            toPrint.Add(subjectPath, "SUBJECT");
            int numberOfSections = Convert.ToInt32(getInput($"Enter the number of sections in subjects for year {collegeYear}, semester {yearSemester}, focus area {semesterFocus} (i.e. number of lab/lectures): "));
            for (int sectionSubject = 1; sectionSubject <= numberOfSections; sectionSubject++)
                getSectionInfo(subjectPath, sectionSubject, subjectFocus, semesterFocus, yearSemester, collegeYear);
        }
        public void getSectionInfo(string subjectFilePath, int sectionSubject, int subjectFocus, int semesterFocus, int yearSemester, int collegeYear)
        {
            string sectionPath = makeValidFilePath(subjectFilePath, getInput($"Enter the name for section {sectionSubject} of subject {subjectFocus} of focus area {semesterFocus} of semester {yearSemester} of year {collegeYear}: "));
            toPrint.Add(sectionPath, "SECTION");
        }
    }
}
