﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    class Question
    {
        List<Question> nextQuestions;
        Answer answer { get; set; }
    }
}
