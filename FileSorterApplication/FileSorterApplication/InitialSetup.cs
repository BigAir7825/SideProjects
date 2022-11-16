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
        public InitialSetup()
        {
            write("setUp.txt", "COMPLETE", false);
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
    }
}
