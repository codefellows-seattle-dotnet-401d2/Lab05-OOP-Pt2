using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Course : Branch
    {
        protected string Title { get; set; }
        protected string Schedule { get; set; }
        protected bool IsDayTime { get; set; }

        protected virtual bool EnrollStudent(Student student)
        {
            Console.WriteLine("Enrolling " + student.Name + " in " + Title);
            return true;
        }

        protected abstract bool AssignStaff(Staff staff);

        protected abstract bool PassStudent(Student student);
    }
}
