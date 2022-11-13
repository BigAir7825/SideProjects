using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class Year
    {
        private List<Semester> semestersOfYear;
        private Dictionary<string, string> paths;
        public Year(Dictionary<string, string> paths)
        {
            this.paths = paths;
        }
        public void addSemester()
        {
            Dictionary<string, string> newSemesters = new Dictionary<string, string>();
            int counterOfSemesters = 0;
            foreach (var path in paths)
            {
                if (path.Value == "SEMESTER")
                {
                    counterOfSemesters++;
                    if (counterOfSemesters > 1)
                    {
                        semestersOfYear.Add(new Semester(newSemesters));
                        counterOfSemesters = 1;
                    }
                }
                else if (path.Value != "SEMESTER" && counterOfSemesters == 1)
                {
                    newSemesters.Add(path.Key, path.Value);
                }
            }
        }
    }
}
