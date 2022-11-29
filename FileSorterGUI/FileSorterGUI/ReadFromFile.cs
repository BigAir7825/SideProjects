using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterGUI
{
    internal class ReadFromFile
    {
        public List<string> lines;
        public string filePath;
        public bool isValid = true;
        public ReadFromFile(string filePath)
        {
            this.filePath = filePath;
            lines = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                    lines.Add(sr.ReadLine());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"The file path {filePath} is incorrect ending program");
                isValid = false;
            }
        }
    }
}
