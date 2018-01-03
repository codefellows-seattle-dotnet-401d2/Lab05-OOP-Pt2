using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // Encapsulation, Inheritance. 
    public class Student : Person
    {
        public decimal DebtOwed { get; set; }
        public bool IsGrad { get; set; }
        public string EnrolledClass { get; set; }

        // Encapsulation. Public because its called from anywhere.
        public Student(string loc, string name, string email)
        {
            Location = loc;
            if (loc == "Seattle") Address = "2901 3rd Ave";
            Name = name;
            Email = email;
        }

        // Encapsulation. Public because its called from anywhere.
        public bool Enroll(Course course)
        {
            EnrolledClass = course.Title;
            return course.EnrollStudent(this);
        }

        // Encapsulation. Public because its called from anywhere.
        public string SubmitAssignment(string assignment)
        {
            return Name + " submitted " + assignment;
        }

        // Encapsulation, Polymorphism. Public because its called from anywhere. Override because implements its own version of base method.
        public override bool AttendStandUp()
        {
            Console.WriteLine("Attending Project Week morning standup");
            return true;
        }
    }
}
