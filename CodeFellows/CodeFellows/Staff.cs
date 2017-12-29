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

        public string GradeAssignment(Student student)
        {
            return this.Name + " graded an assignment for " + student.Name + ".";
        }
    }
}
