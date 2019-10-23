using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    class Answer
    {
        public string answer { get; set; }
        public string resultOfQuiz { get; set; }
        public Question nextQuestion { get; set; }
    }
}
