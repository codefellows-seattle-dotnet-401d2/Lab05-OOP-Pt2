using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Course : Branch
    {
        internal string Title { get; set; }
        internal string Schedule { get; set; }
        internal bool IsDayTime { get; set; }

        internal virtual bool EnrollStudent(Student student)
        {
            Console.WriteLine("Enrolling " + student.Name + " in " + Title);
            return true;
        }

        internal abstract bool AssignStaff(Staff staff);

        internal abstract bool PassStudent(Student student);
    }
}
