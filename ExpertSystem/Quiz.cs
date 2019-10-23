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

        public string nextQuestion(int answerId)
        {
            if(currentQuestion.answers[answerId].resultOfQuiz != null)
            {
                currentQuestion = currentQuestion.answers[answerId].nextQuestion;
                return null;
            }
            return currentQuestion.answers[answerId].resultOfQuiz;
        }
    }
}
