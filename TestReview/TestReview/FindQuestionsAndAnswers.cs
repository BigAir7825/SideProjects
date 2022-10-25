using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReview
{
    internal class FindQuestionsAndAnswers
    {
        public List<string> questions;
        public List<string> answers;
        public FindQuestionsAndAnswers(List<string> rawData)
        {
            questions = new List<string>();
            answers = new List<string>();
            foreach (string data in rawData)
            {
                if (data.StartsWith("*"))
                    answers.Add(data);
                else
                    questions.Add(data);
            }
        }
    }
}
