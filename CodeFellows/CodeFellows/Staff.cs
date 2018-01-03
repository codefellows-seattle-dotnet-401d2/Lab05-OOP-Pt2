using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public class Staff : Person
    {
        public string Role { get; set; }
        public Course AssignedClass { get; set; }
        public decimal Salary { get; set; }

        public Staff (string name)
        {
            Name = name;
        }

        public string GradeAssignment(Student student)
        {
            return this.Name + " graded an assignment for " + student.Name + ".";
        }

        public override bool AttendStandUp()
        {
            Console.WriteLine("Attending daily standup meeting.");
            return true;
        }

        public override bool GoToLecture()
        {
            Console.WriteLine("Going to class to teach/grade assignments.");
            return true;
        }
    }
}
