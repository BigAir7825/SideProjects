using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FileSorterApplication
{
    internal class Startup
    {
        private Dictionary<string, string> filePaths;
        private College initializedCollege;
        public Startup()
        {
            filePaths = new Dictionary<string, string>();
            ReadFromFile reader = new ReadFromFile("setUp.txt");
            InitialSetup setup;
            if (!reader.isValid)
                setup = new InitialSetup();
            createObjects();
            Console.WriteLine("Successfully put everything into sorting objects");
        }
        public void createObjects()
        {
            read("paths.txt");
            initializedCollege = new College(filePaths);
        }
        public void read(string filePath)
        {
            ReadFromFile reader = new ReadFromFile(filePath);
            foreach (string data in reader.lines)
            {
                string[] split = data.Split(" - ");
                filePaths.Add(split[1], split[0]);
            }
        }
    }
}
