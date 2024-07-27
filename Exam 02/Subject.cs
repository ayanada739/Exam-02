﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{


    public class Subject
    {

            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam Exam { get; set; }

            public Subject(int subjectId, string subjectName)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
            }

            public void CreateExam(Exam exam)
            {
                Exam = exam;
            }

            public override string ToString()
            {
                return ($"Subject Id: {SubjectId}, Subject Name: {SubjectName}, Exam: {Exam}");
            }
    }

}

