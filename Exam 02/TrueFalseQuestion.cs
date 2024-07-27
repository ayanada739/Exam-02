using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header , string body , int mark , Answer[] answers , Answer correctAnswer): base(header , body , mark , answers , correctAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}\nTrue or False?");
        }
    }
}
