using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class College
    {
        private List<Year> yearsOfCollege = new List<Year>();
        private Dictionary<string, string> paths;
        public College(Dictionary<string, string> paths)
        {
            this.paths = paths;
            addYear();
        }
        public void addYear()
        {
            Dictionary<string, string> newYears = new Dictionary<string, string>();
            int counterOfYears = 0;
            foreach (var path in paths)
            {
                if (path.Value == "YEAR")
                {
                    counterOfYears++;
                    if (counterOfYears > 1)
                    {
                        yearsOfCollege.Add(new Year(newYears));
                        counterOfYears = 1;
                    }
                }
                else if (path.Value != "YEAR" && counterOfYears == 1)
                {
                    newYears.Add(path.Key, path.Value);
                }
            }
        }
    }
}
