using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    class Quiz
    {
        Question currentQuestion { get; set; }

        public string getQuestion()
        {
            return currentQuestion.questionText;
        }

        public void nextQuestion(int answerId)
        {
            currentQuestion = currentQuestion.answers[answerId].nextQuestion;
        }
    }
}
