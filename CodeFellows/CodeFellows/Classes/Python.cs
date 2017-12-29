using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    public class Python : _401
    {

        // Polymorphism
        public override int NumberOfTeachers { get; set; }

        public override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void DoPythonThings()
        {
            Console.WriteLine("So many python things");
        }

        public void DoMorePythonThings()
        {
            Console.WriteLine("So many MORE python things");
        }

        public void CreateAlexaSkill()
        {
            Console.WriteLine("Python for IOT");
        }
    }
}
