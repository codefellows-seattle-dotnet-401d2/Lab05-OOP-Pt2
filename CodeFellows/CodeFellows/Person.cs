using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // 
    public abstract class Person : Branch
    {
        // Name is internal because constructor sets it and still need access from other class methods. 
        // Birthday is public to set at a later time.
        // Email is protected because constructor sets it and not trying to access outside class hierarchy.
        internal string Name { get; set; }
        public DateTime Birthday { get; set; }
        protected string Email { get; set; }

        // public in order to run unit tests
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
