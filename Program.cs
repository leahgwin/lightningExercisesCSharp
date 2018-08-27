using System;
using System.Collections.Generic;


namespace lightningExercises
{
    // Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort
    class Program
    {
        static void Main(string[] args)
        {
            //creating the cohort
            Cohort cohort26 = new Cohort();
            //creating the instructor
            Instructor steve = new Instructor("Steve", "Brownlee");
            //creating the students
            Student leah = new Student("Leah", "Gwin");
            Student natasha = new Student("Natasha", "Cox");
            Student shu = new Student("Shu", "Sajid");
            Student robert = new Student("Robert", "Leedy");
            Student will = new Student("Will", "Kimball");
            Student vik = new Student("Vik", "Reddy");

            //adding those students and instructors to the list they belong
            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(leah);
            cohort26.StudentList.Add(natasha);
            cohort26.StudentList.Add(shu);
            cohort26.StudentList.Add(robert);
            cohort26.StudentList.Add(will);
            cohort26.StudentList.Add(vik);


            //making the exercises
            Exercise exercise1 = new Exercise();
            exercise1.Name = "ChickenMonkey";
            exercise1.Language = "JavaScript";
            exercise1.GithubUrl = "www.github.com";

            Exercise exercise2 = new Exercise();
            exercise2.Name = "Kill Nickelback";
            exercise2.Language = "C#";
            exercise2.GithubUrl = "www.github.com";

            Exercise exercise3 = new Exercise();
            exercise3.Name = "Nut Shell";
            exercise3.Language = "JavaScript";
            exercise3.GithubUrl = "www.github.com";

            steve.AssignExercise(leah, exercise1);
            steve.AssignExercise(natasha, exercise1);
            steve.AssignExercise(natasha, exercise2);
            steve.AssignExercise(natasha, exercise3);

            foreach (Exercise exercise in natasha.AssignedExercises)
            {
                Console.WriteLine($"Natasha's Exercises: {exercise.Name}");
            }
        }
    }
}