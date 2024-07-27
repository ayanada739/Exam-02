using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class MCQPracticalQuestion : Question
    {
        public MCQPracticalQuestion(string header , string body , int mark , Answer[] answers , Answer correctAnswer): base(header , body , mark , answers , correctAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");


            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i]. AnswerText}");
            }
        }
    }
}
