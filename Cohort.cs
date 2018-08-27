using System.Collections.Generic;


namespace lightningExercises
{

    // Create a `Cohort` class that

    // 1. Maintains a list of students
    // 2. Maintains a list of instructors
    // 3. Has a property of the cohort number

    public class Cohort
    {
        public int CohortNumber { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public List<Instructor> InstructorList { get; set; } = new List<Instructor>();

    }
}
