using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class InitialSetup
    {
        public string userName;
        Dictionary<string, string> paths;
        public InitialSetup(string condition)
        {
            switch (condition)
            {
                case "error":
                    FromError();
                    break;
                case "normal":
                    NormalOperations();
                    break;
            }

        }
        public void FromError()
        {
            Console.Write("Initial setup incomplete\nEnter the user name for the account (i.e. C\\Users\\{Username}): ");
            userName = Console.ReadLine();
        }
        public void NormalOperations()
        {
            paths = new Dictionary<string, string>();
            FileWork fileWork = new FileWork("read", "paths.txt", "");
            foreach (string line in fileWork.rawData)
            {
                string[] splitLine = line.Split(" - ");
                switch (splitLine[0])
                {
                    case "College":
                        break;
                    case "1) Freshman":
                        break;
                    case "2) Sophomore":
                        break;
                    case "3) Junior":
                        break;
                    case "4) Senior":
                        break;
                    case "1) Fall":
                        break;
                    case "2) Spring":
                        break;
                    case "3) Summer":
                        break;
                }
            }
        }
    }
}
