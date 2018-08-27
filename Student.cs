using System;
using System.Collections.Generic;

namespace lightning_exercise
{

    public class Student : Person
    {
        //alternate code for namePrinter - expression bodied property
        // public string namePrinter { get => $"{_firstName} {_lastName}"; }

        public List<Exercise> ExerciseList { get; } = new List<Exercise>();


        public Student(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

    }
}