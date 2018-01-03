using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public class Student : Person
    {
        public decimal DebtOwed { get; set; }
        public bool IsGrad { get; set; }
        public string EnrolledClass { get; set; }

        public Student(string loc, string name, string email)
        {
            Location = loc;
            if (loc == "Seattle") Address = "2901 3rd Ave";
            Name = name;
            Email = email;
        }

        public bool Enroll(Course course)
        {
            EnrolledClass = course.Title;
            return course.EnrollStudent(this);
        }

        public string SubmitAssignment(string assignment)
        {
            return Name + " submitted " + assignment;
        }

        public override bool AttendStandUp()
        {
            Console.WriteLine("Attending Project Week morning standup");
            return true;
        }
    }
}
