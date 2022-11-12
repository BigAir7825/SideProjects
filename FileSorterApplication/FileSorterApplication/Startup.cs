using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class Startup
    {
        public Startup()
        {
            ReadFromFile reader = new ReadFromFile("setUp.txt");
            InitialSetup setup;
            if (!reader.isValid)
                setup = new InitialSetup();
        }
        public void createObjects()
        {

        }
        public List<string> read(string filePath)
        {
            ReadFromFile reader = new ReadFromFile(filePath);
            return reader.lines;
        }
    }
}
