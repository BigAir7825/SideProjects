using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class Semester
    {
        private List<FocusArea> focusAreasOfSemester;
        private Dictionary<string, string> paths;
        public Semester(Dictionary<string, string> paths)
        {
            this.paths = paths;
        }
        public void addFocusArea()
        {
            Dictionary<string, string> newFocusAreas = new Dictionary<string, string>();
            int counterOfFocusAreas = 0;
            foreach (var path in paths)
            {
                if (path.Value == "FOCUSAREA")
                {
                    counterOfFocusAreas++;
                    if (counterOfFocusAreas > 1)
                    {
                        focusAreasOfSemester.Add(new FocusArea(newFocusAreas));
                        counterOfFocusAreas = 1;
                    }
                }
                else if (path.Value != "FOCUSAREA" && counterOfFocusAreas == 1)
                {
                    newFocusAreas.Add(path.Key, path.Value);
                }
            }
        }
    }
}
