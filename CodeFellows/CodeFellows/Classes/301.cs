using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    public class _301 : Courses
    {
        // Polymorphism
        public override int NumberOfTeachers { get; set; }

        public override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void Jquery()
        {
            Console.WriteLine("Everything is easier with these methods.");
        }

        public void API()
        {
            Console.WriteLine("REST applications.");
        }

        public void Postgress()
        {
            Console.WriteLine("Lets find things with Postgress");
        }
    }
}
