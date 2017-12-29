using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows.Classes
{
    public class _201 : Courses
    {
        public bool JavascriptBasics { get; set; }

        // Polymorphism
        public override int NumberOfTeachers { get; set; }

        public override int NumberOfStudents { get; set; }

        public override int NumberOfTeachingAssistants { get; set; }

        public void BusMall()
        {
            Console.WriteLine("Banana slicer!");
        }

        public void AboutMe()
        {
            Console.WriteLine("Prompt and alerts!");
        }

        public void ChartJS()
        {
            Console.WriteLine("Charts on charts");
        }
    }
}
