using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public class _301Intermediate : Course
    {
        protected int Duration { get; set; }
        protected string CourseNum { get; set; }
        protected string PreReq { get; set; }

        public _301Intermediate(string loc, bool isDay, int duration, string courseNum)
        {
            Location = loc;
            Title = "Intermediate Software Development";
            if (isDay) Schedule = "Mon-Fri 9am-6pm";
            else Schedule = "Mon-Thu 6:30-9:30pm Sat 9am-6pm";
            IsDayTime = isDay;
            Duration = duration;
            CourseNum = courseNum;
            PreReq = "201 Final Exam, 201 Final Project, Instructor Recommendation";
        }

        protected override bool EnrollStudent(Student student)
        {
            Console.WriteLine("Checking the following pre-requisites: " + PreReq);
            return base.EnrollStudent(student);
        }

        protected override bool AssignStaff(Staff staff)
        {
            Console.WriteLine("Assigning " + staff.Name + " to " + CourseNum);
            return true;
        }

        protected override bool PassStudent(Student student)
        {
            Console.WriteLine(student.Name + " to " + CourseNum);
            return true;
        }
    }
}
