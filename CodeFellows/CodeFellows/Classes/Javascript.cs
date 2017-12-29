using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    public class Javascript : _401
    {

        // Polymorphism
        public override int NumberOfTeachers { get; set; }

        public override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void LearnReact()
        {
            Console.WriteLine("Mobile Apps!");
        }

        public void MoreJS()
        {
            Console.WriteLine("More Javascript!");
        }

        public void MoreNode()
        {
            Console.WriteLine("Node.js is great");
        }
    }
}
