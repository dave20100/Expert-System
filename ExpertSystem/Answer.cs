using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class Answer
    {
        public Answer(string answer, string resultOfQuiz, Question nextQuestion)
        {
            this.answer = answer;
            this.resultOfQuiz = resultOfQuiz;
            this.nextQuestion = nextQuestion;
        }

        public string answer { get; set; }
        public string resultOfQuiz { get; set; }
        public Question nextQuestion { get; set; }
    }
}
