using System;
using System.Collections.Generic;


namespace lightningExercises
{

    // Create an `Instructor` class with the following properties and fields
    // 1. private fields for first name and last name
    // 2. Public calculated property that returns "Firstname Lastname" of instructor
    // 3. Constructor that accepts first name and last name
    public class Instructor
    {
        private string _firstName;
        private string _lastName;

        public string FullName { get => $"{_firstName} {_lastName}"; }

        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    }


}
