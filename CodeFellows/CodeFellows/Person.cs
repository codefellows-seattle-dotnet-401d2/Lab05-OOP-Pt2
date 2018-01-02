using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Person : Branch
    {
        internal string Name { get; set; }
        protected DateTime Birthday { get; set; }
        protected string Email { get; set; }

        public bool TravelToCampus()
        {
            Console.WriteLine("Traveling to " + Address);
            return true;
        }

        internal abstract bool AttendStandUp();

        internal virtual bool GoToLecture()
        {
            Console.WriteLine("Going to class to learn");
            return true;
        }
    }
}
