namespace Exam_02
{
    public class FinalExam : Exam
    {
        public FinalExam(DateTime time, int numberOfQuestions, List<Question> questions) : base(time, numberOfQuestions, questions)
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

            Console.WriteLine($"Grade: {Questions.Sum(q => q.Mark)}");
        }
    }

}
