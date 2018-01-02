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
            Name = name;
            Email = email;
        }

        public bool Enroll(Course course)
        {
            return true;
        }

        internal string SubmitAssignment(string assignment)
        {
            return Name + " submitted " + assignment;
        }

        internal override bool AttendStandUp()
        {
            Console.WriteLine("Attending Project Week morning standup");
            return true;
        }
    }
}
