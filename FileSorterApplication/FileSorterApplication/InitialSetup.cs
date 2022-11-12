using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class InitialSetup
    {
        public bool isSetUp;
        public Dictionary<string, string> paths;
        public InitialSetup()
        {
            ReadFromFile initialRead = new ReadFromFile("setUp.txt");
            paths = new Dictionary<string, string>();
            if (!initialRead.isValid)
            {
                write("setUp.txt", "SetUP - Valid", false);
                Console.WriteLine("This is the initial setup of this program");
                Console.WriteLine("To start, please enter the name of the user of this program (i.e. C:\\{userName}: ");
                paths.Add("UserName", "");
            }
        }
        public void write(string filePath, string text, bool overWrite)
        {

        }
    }
}
