using System;
using System.Collections.Generic;


namespace lightningExercises
{

    //     Create a `Student` class with the following properties and fields
    // 1. private fields for first name and last name
    // 2. Public calculated property that returns "Firstname Lastname" of student
    // 3. Constructor that accepts first name and last name
    // 4. A public list of exercises
    public class Student : Person
    {
        //theres a 'get' because I want to be able to get a list of the exercises for each student
        public List<Exercise> AssignedExercises { get; } = new List<Exercise>();


        //Constructor that accepts first name and last name
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
