using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public class _401NetCore : Course
    {
        protected int Duration { get; set; }
        protected string CourseNum { get; set; }
        protected string PreReq { get; set; }

        public _401NetCore(string loc, int duration, string courseNum)
        {
            Location = loc;
            Title = "Advanced Software Development in ASP.NET Core";
            Schedule = "Mon-Fri 9am-6pm";
            Duration = duration;
            CourseNum = courseNum;
            PreReq = "301 Final Exam, 301 Final Project, Instructor Recommendation";
        }

        internal override bool EnrollStudent(Student student)
        {
            Console.WriteLine("Checking the following pre-requisites: " + PreReq);
            return base.EnrollStudent(student);
        }

        public override bool AssignStaff(Staff staff)
        {
            Console.WriteLine("Assigning " + staff.Name + " to " + CourseNum);
            return true;
        }

        public override bool PassStudent(Student student)
        {
            Console.WriteLine(student.Name + " to " + CourseNum);
            return true;
        }
    }
}
