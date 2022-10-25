using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReview
{
    internal class FileWork
    {
        public StreamReader reader;
        public List<string> questions;
        public List<string> answers;
        public FileWork(string filePath)
        {
            reader = new StreamReader(filePath);
            ReadFromFile();
            reader.Close();
        }
        public void ReadFromFile()
        {
            List<string> rawData = new List<string>();
            while (!reader.EndOfStream)
                rawData.Add(reader.ReadLine());
            FindQuestionsAndAnswers getLists = new FindQuestionsAndAnswers(rawData);
            questions = getLists.questions;
            answers = getLists.answers;
        }

        public void WriteToFile(string filePath, string question, string answer)
        {
            if (!questions.Contains(question) && !answers.Contains(answer))
            {
                StreamWriter writer = new StreamWriter(filePath, true);
                writer.WriteLine(question);
                writer.WriteLine(answer);
                writer.Close();
            }
        }
    }
}
