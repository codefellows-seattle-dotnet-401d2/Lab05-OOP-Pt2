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
        protected int Duration { get; set; }
        protected string CourseNum { get; set; }
        protected string PreReq { get; set; }

        protected virtual bool EnrollStudent(Student student)
        {
            return true;
        }

        protected bool AssignStaff(Staff staff)
        {
            return true;
        }

        protected abstract bool PassStudent(Student student);
    }
}
