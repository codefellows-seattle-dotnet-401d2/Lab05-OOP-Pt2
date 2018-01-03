using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public class _401Python : Course
    {
        // Encapsulation: Following 3 are private because constructor sets it and do not need access elsewhere.
        private int Duration { get; set; }
        private string CourseNum { get; set; }
        private string PreReq { get; set; }

        // Encapsulation.
        public _401Python(string loc, int duration, string courseNum)
        {
            Location = loc;
            Title = "Advanced Software Development in Python";
            Schedule = "Mon-Fri 9am-6pm";
            Duration = duration;
            CourseNum = courseNum;
            PreReq = "301 Final Exam, 301 Final Project, Instructor Recommendation";
        }

        // Encapsulation, Polymorphism: Internal because is called from Person class hierarchy. Overriden because implements its own version of base method.
        internal override bool EnrollStudent(Student student)
        {
            Console.WriteLine("Checking the following pre-requisites: " + PreReq);
            return base.EnrollStudent(student);
        }

        // Encapsulation, Polymorphism. Public because its called from anywhere. Override because implements its own version of base method.
        public override bool AssignStaff(Staff staff)
        {
            Console.WriteLine("Assigning " + staff.Name + " to " + CourseNum);
            return true;
        }

        // Encapsulation, Polymorphism. Public because its called from anywhere. Override because implements its own version of base method.
        public override bool PassStudent(Student student)
        {
            Console.WriteLine(student.Name + " to " + CourseNum);
            return true;
        }
    }
}
