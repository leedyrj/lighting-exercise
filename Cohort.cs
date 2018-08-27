using System;
using System.Collections.Generic;

namespace lightning_exercise
{
    public class Cohort
    {
        public int CohortNumber { get; set; }
        public List<Student> Students = new List<Student>();

        public List<Instructor> Instructors = new List<Instructor>();


    }
}
