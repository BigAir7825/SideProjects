using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class FocusArea
    {
        private List<Subject> subjectsOfFocusArea;
        private Dictionary<string, string> paths;
        public FocusArea(Dictionary<string, string> paths)
        {
            this.paths = paths;
        }
        public void addSubject()
        {
            Dictionary<string, string> newSubject = new Dictionary<string, string>();
            int counterOfSubjects = 0;
            foreach (var path in paths)
            {
                if (path.Value == "SUBJECT")
                {
                    counterOfSubjects++;
                    if (counterOfSubjects > 1)
                    {
                        subjectsOfFocusArea.Add(new Subject(newSubject));
                        counterOfSubjects = 1;
                    }
                }
                else if (path.Value != "SUBJECT" && counterOfSubjects == 1)
                {
                    newSubject.Add(path.Key, path.Value);
                }
            }
        }
    }
}
