using System;
using System.Collections.Generic;

namespace lightning_exercise
{
    public class Instructor : Person
    {
        public Instructor(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public void AssignExercise(Student student, Exercise exercise)
        {
            /*
                Refactor this method and the `AssignedExercises` property
                on Student to keep track of which instructor assigned the
                exercise, and when.
            */
            student.ExerciseList.Add(exercise);
        }

    }
}