using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterApplication
{
    internal class FileWork
    {
        public List<string> rawData;
        public FileWork(string purpose, string filePath, string textToWrite)
        {
            switch (purpose)
            {
                case "read":
                    ReadFromFile(filePath);
                    break;
                case "write":
                    break;
            }
        }
        public void ReadFromFile(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                    rawData.Add(reader.ReadLine());
                reader.Close();
            } catch (Exception e)
            {
                Console.WriteLine("File path not set up");
                InitialSetup setupApplication = new InitialSetup("error");
            }
        }
        public void WriteToFile(string filePath, string textToWrite)
        {
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(textToWrite);
            writer.Close();
        }
    }
}
