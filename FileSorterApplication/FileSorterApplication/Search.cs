using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class Search
    {
        public Dictionary<string, string> outOfPlace = new Dictionary<string, string>();
        public Search(Dictionary<string, string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                string[] listOfFiles = Directory.GetFiles(filePath.Key);
                foreach (string file in listOfFiles)
                {
                    if (filePath.Value != "SUBJECT" || filePath.Value != "SECTION")
                        outOfPlace.Add(file, filePath.Value);
                }
            }
        }

    }
}
