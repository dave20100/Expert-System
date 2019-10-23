using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public static class JsonParser
    {
        private static string readJson(string name)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(name))
            {
                return sr.ReadToEnd();
            }
        }

        public static Quiz generateQuiz()
        {
        }
    }
}
