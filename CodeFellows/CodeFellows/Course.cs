using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // Encapsulation, Abstraction, Inheritance. 
    public abstract class Course : Branch
    {
        // Encapsulation: Following 3 are internal because need access from classes outside this hierarchy.
        internal string Title { get; set; }
        internal string Schedule { get; set; }
        internal bool IsDayTime { get; set; }

        // Encapsulation, Polymorphism: Internal because base version is only called from child class and overriden version is called from Person class hierarchy. Virtual because child class implements its own version.
        internal virtual bool EnrollStudent(Student student)
        {
            Console.WriteLine("Enrolling " + student.Name + " in " + Title);
            return true;
        }

        // Encapsulation, Abstraction. Public because its called from anywhere.
        public abstract bool AssignStaff(Staff staff);

        // Encapsulation, Abstraction. Public because its called from anywhere.
        public abstract bool PassStudent(Student student);
    }
}
