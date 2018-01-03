using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // Encapsulation, Inheritance. 
    public class Staff : Person
    {
        // Encapsulation: Following 3 are public in order to assign values whenever from anywhere.
        public string Role { get; set; }
        public Course AssignedClass { get; set; }
        public decimal Salary { get; set; }

        // Encapsulation.
        public Staff (string name)
        {
            Name = name;
        }

        // Encapsulation. Public because its called from anywhere.
        public string GradeAssignment(Student student)
        {
            return this.Name + " graded an assignment for " + student.Name + ".";
        }

        // Encapsulation, Polymorphism. Public because its called from anywhere. Override because implements its own version of base method.
        public override bool AttendStandUp()
        {
            Console.WriteLine("Attending daily standup meeting.");
            return true;
        }

        // Encapsulation, Polymorphism. Public because its called from anywhere. Override because implements its own version of base method.
        public override bool GoToLecture()
        {
            Console.WriteLine("Going to class to teach/grade assignments.");
            return true;
        }
    }
}
