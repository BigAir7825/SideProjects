using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class WriteToFile
    {
        public string filePath;
        public string textToWrite;
        public bool isValid = true;
        public WriteToFile(string filePath, string textToWrite, bool overWrite)
        {
            this.filePath = filePath;
            this.textToWrite = textToWrite;
            try
            {
                if (!overWrite)
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(textToWrite);
                    sw.Close();
                } else
                {
                    StreamWriter sw = new StreamWriter(filePath, true);
                    sw.Write(textToWrite);
                    sw.Close();
                }
            } catch (Exception e)
            {
                Console.WriteLine($"The file path {filePath} is incorrect ending program");
                isValid = false;
            }
        }
    }
}
