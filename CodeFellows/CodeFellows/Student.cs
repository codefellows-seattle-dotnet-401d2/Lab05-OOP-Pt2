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

        public Student()
        {

        }

        public bool Enroll()
        {
            return true;
        }

        public string SubmitAssignment(string assignment)
        {
            return this.Name + " submitted " + assignment;
        }
    }
}
