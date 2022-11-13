using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class Subject
    {
        private List<Section> sectionsOfSubject;
        private Dictionary<string, string> paths;
        public Subject(Dictionary<string, string> paths)
        {
            this.paths = paths;
        }
        public void addSection()
        {
            Dictionary<string, string> newSection = new Dictionary<string, string>();
            int counterOfSections = 0;
            foreach (var path in paths)
            {
                if (path.Value == "SECTION")
                {
                    counterOfSections++;
                    if (counterOfSections > 1)
                    {
                        sectionsOfSubject.Add(new Section());
                        counterOfSections = 1;
                    }
                }
                else if (path.Value != "SECTION" && counterOfSections == 1)
                {
                    newSection.Add(path.Key, path.Value);
                }
            }
        }
    }
}
