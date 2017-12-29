using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    // Abstraction
    public abstract class Courses : CodeFellowsClass
    {
        public bool Curriculum { get; set; }

        // Polymorphism
        public abstract int NumberOfTeachers { get; set; }

        public virtual int NumberOfStudents { get; set; }

        public virtual int NumberOfTeachingAssistants { get; set; }

        public static string TeachStudents()
        {
            return "Today, we learned Javascript";
        }

        public void TestStudents()
        {
            Console.WriteLine("Today, we were tested on Javascript");
        }

        public static string PassFinal()
        {
            return "Used as admission to the next class";
        }

    }
}
