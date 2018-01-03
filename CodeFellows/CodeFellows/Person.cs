using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Person : Branch
    {
        internal string Name { get; set; }
        public DateTime Birthday { get; set; }
        internal string Email { get; set; }

        public bool TravelToCampus()
        {
            Console.WriteLine("Traveling to " + Address);
            return true;
        }

        public abstract bool AttendStandUp();

        public virtual bool GoToLecture()
        {
            Console.WriteLine("Going to class to learn");
            return true;
        }
    }
}
