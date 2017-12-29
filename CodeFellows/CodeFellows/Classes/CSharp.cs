using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    public class CSharp : _401
    {
        // Polymorphism
        public sealed override int NumberOfTeachers { get; set; }

        // Encapsulation with sealed
        public sealed override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void UseEdge()
        {
            Console.WriteLine("Wait. . .this isn't Chrome.");
        }

        public void UseWindows10()
        {
            Console.WriteLine("It's free!");
        }

        // Inheritance
        public static string InheritCourses()
        {
            return TeachStudents();
        }
    }
}
