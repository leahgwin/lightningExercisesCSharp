namespace lightningExercises
{

    public class Person
    {

        protected string _firstName;
        protected string _lastName;

        //this is an expression body function that just returns the full name
        public string FullName { get => $"{_firstName} {_lastName}"; }

    }
}
