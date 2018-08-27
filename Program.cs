using System;
using System.Collections.Generic;


namespace lightningExercises
{
    // Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();

            Instructor steve = new Instructor("Steve", "Brownlee");

            Student leah = new Student("Leah", "Gwin");
            Student natasha = new Student("Natasha", "Cox");
            Student shu = new Student("Shu", "Sajid");
            Student robert = new Student("Robert", "Leedy");
            Student will = new Student("Will", "Kimball");
            Student vik = new Student("Vik", "Reddy");


            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(leah);
            cohort26.StudentList.Add(natasha);
            cohort26.StudentList.Add(shu);
            cohort26.StudentList.Add(robert);
            cohort26.StudentList.Add(will);
            cohort26.StudentList.Add(vik);


        }
    }
}