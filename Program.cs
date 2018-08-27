using System;
using System.Collections.Generic;

namespace lightning_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();

            Student robert = new Student("Robert", "Leedy");
            Student leah = new Student("Leah", "Gwin");
            Student will = new Student("Will", "Kimball");
            Student elliot = new Student("Elliot", "Huck");
            Student natasha = new Student("Natasha", "Cox");

            Instructor jisie = new Instructor("Jisie", "David");
            Instructor jordan = new Instructor("Jordan", "Something");
            Instructor emily = new Instructor("Emily", "Lemmon");

            cohort26.Instructors.Add(jisie);
            cohort26.Instructors.Add(jordan);
            cohort26.Instructors.Add(emily);

            cohort26.Students.Add(robert);
            cohort26.Students.Add(leah);
            cohort26.Students.Add(will);
            cohort26.Students.Add(elliot);
            cohort26.Students.Add(natasha);

            Exercise Lists = new Exercise()
            {
                Name = "Lists",
                GithubUrl = "github.com/lists",
                Language = "C#"
            };
            Exercise Tuples = new Exercise()
            {
                Name = "Lists",
                GithubUrl = "github.com/tuples",
                Language = "C#",
            };
            Exercise Dictionaries = new Exercise()
            {
                Name = "Lists",
                GithubUrl = "github.com/dictionaries",
                Language = "C#",
            };
            Exercise HashSets = new Exercise()
            {
                Name = "Lists",
                GithubUrl = "github.com/hashsets",
                Language = "C#"
            };
            Exercise ChickenMonkey = new Exercise()
            {
                Name = "ChickenMonkey",
                GithubUrl = "github.com/ChickenMonkey",
                Language = "JavaScript"
            };

            jisie.AssignExercise(robert, Lists);
            jordan.AssignExercise(leah, Dictionaries);
            emily.AssignExercise(will, Tuples);
            jisie.AssignExercise(elliot, HashSets);
            jordan.AssignExercise(natasha, ChickenMonkey);

            foreach (Exercise Exercise in robert.ExerciseList)
            {
                Console.WriteLine($"Robert was assigned {Exercise.Name}. It's github url is {Exercise.GithubUrl} and it is in {Exercise.Language}.");
            }

        }
    }
}
