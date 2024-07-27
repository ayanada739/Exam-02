namespace Exam_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Answer[] trueFalseAnswer = { new Answer(1, "True"), new Answer(2, "False") };
            Answer trueFalseCorrectAnswer = trueFalseAnswer[0];
            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion("Q1" , "Pascal case is used when naming a class ?" , 5 , trueFalseAnswer , trueFalseCorrectAnswer );


            Answer[] mcqAnswers = { new Answer(1, "A : C "), new Answer(2, "B : Cpp "), new Answer(3, "C: Cs ") };
            Answer mcqCorrectAnswer = mcqAnswers[2];
            MCQFinalQuestion mcqFinalQuestion = new MCQFinalQuestion("Q2","What is the extension of a language file?",5, mcqAnswers, mcqCorrectAnswer );


            List<Question> finalQuestions = new List<Question> { trueFalseQuestion, mcqFinalQuestion };
            FinalExam finalExam = new FinalExam(DateTime.Now, finalQuestions.Count, finalQuestions);


            Subject Programing = new Subject(1, "Programing");
            Programing.CreateExam(finalExam);


            Console.WriteLine(Programing);
            finalExam.ShowExam();
        }
    }
}
