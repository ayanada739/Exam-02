using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class PracticalExam : Exam
{
    public PracticalExam(DateTime time , int numberOfQuestions , List<Question> questions): base(time , numberOfQuestions , questions)
    {
    }

    public override void ShowExam()
    {
        foreach (var question in Questions)
        {
            question.DisplayQuestion();
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
            Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}");
        }
    }
}

}
