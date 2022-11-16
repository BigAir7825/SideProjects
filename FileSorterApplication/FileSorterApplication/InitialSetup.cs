using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class InitialSetup
    {
        public Dictionary<string, string> filePathsAndPurpose = new Dictionary<string, string>();
        public string baseFilePath = "C:\\Users\\";
        public InitialSetup()
        {
            Console.WriteLine("Some base rules:\nDo not give numbers in the names\nGive real filepaths\n");
            getBaseFilePath();

            write("setUp.txt", "COMPLETE", false);
        }
        public void createCollege()
        {
            string collegeFolder = getInput("Give a name for the college folder MUST BE NEW: ");
            string collegePath = makeToPath(baseFilePath, collegeFolder);
            filePathsAndPurpose.Add(collegePath, "COLLEGE");
            createDirectory(collegePath);
        }
        public void createDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
        public void write(string filePath, string toWrite, bool overWrite)
        {
            WriteToFile writer = new WriteToFile(filePath, toWrite, overWrite);
        }
        public string getInput(string consoleOutput)
        {
            Console.WriteLine(consoleOutput);
            return Console.ReadLine();
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
    }
}
