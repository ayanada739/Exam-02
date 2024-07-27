using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {

        public DateTime Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }


        protected Exam(DateTime time , int numberOfQuestions , List<Question> questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();
        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }



        public override string ToString()
        {
            return $"Time: {Time}, Number of Questions: {NumberOfQuestions}";
        }
    }

}
