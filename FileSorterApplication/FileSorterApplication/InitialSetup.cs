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
            toPrint.Add("USERNAME", userNameFilePath);
            getCollegeInfo(userNameFilePath);
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
            toPrint.Add("COLLEGE", collegePath);
            for (int collegeYear = 1; collegeYear <= Convert.ToInt32(getInput("Enter the number of years in college (reccomended 4): ")); collegeYear++)
                getYearInfo(collegePath, collegeYear);
        }
        public void getYearInfo(string collegeFilePath, int collegeYear)
        {
            string yearPath = makeValidFilePath(collegeFilePath, getInput($"Enter the name for year {collegeYear}: "));
            toPrint.Add("YEAR", yearPath);
            for (int yearSemester = 1; yearSemester <= Convert.ToInt32(getInput($"Enter the number of semesters for year {collegeYear}: ")); yearSemester++)
                getSemesterInfo(yearPath, yearSemester, collegeYear);
        }
        public void getSemesterInfo(string yearFilePath, int yearSemester, int collegeYear)
        {
            string semesterPath = makeValidFilePath(yearFilePath, getInput($"Enter the name for semester {yearSemester} of {collegeYear}: "));
            toPrint.Add("SEMESTER", semesterPath);
        }
    }
}
