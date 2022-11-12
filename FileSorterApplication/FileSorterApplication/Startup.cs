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
            if (reader.isValid)
            {
                //TODO: implement running program
            } else
            {
                InitialSetup setup = new InitialSetup();
                //TODO: implement running program
            }
        }
    }
}
