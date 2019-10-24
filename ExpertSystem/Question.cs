using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class Question
    {
        public string questionText;


        public List<Answer> answers { get; set; }

        public Question(string questionText, List<Answer> answers)
        {
            this.questionText = questionText;
            this.answers = answers;
        }

    }
}
