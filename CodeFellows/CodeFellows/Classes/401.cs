using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    // Abstraction
    public abstract class _401 : Courses
    {
        public bool JavascriptBasics { get; set; }

        // Polymorphism
        public override int NumberOfTeachers { get; set; }

        public override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void LearnCSharp()
        {
            Console.WriteLine("OOP everyday.");
        }

        public void WarGames()
        {
            Console.WriteLine("WAR!!!");
        }

        public void OOP()
        {
            Console.WriteLine("There are 4 principles of OOP.");
        }
    }
}
