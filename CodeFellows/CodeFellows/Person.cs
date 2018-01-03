using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // Encapsulation, Abstraction, Inheritance. 
    public abstract class Person : Branch
    {
        // Encapsulation.
        // Name is internal because constructor sets it and still need access from other class methods. 
        // Birthday is public to set at a later time.
        // Email is protected because constructor sets it and not trying to access outside class hierarchy.
        internal string Name { get; set; }
        public DateTime Birthday { get; set; }
        protected string Email { get; set; }

        // Encapsulation. Public because its called from anywhere.
        public bool TravelToCampus()
        {
            Console.WriteLine("Traveling to " + Address);
            return true;
        }

        // Encapsulation, Abstraction. Public because its called from anywhere.
        public abstract bool AttendStandUp();

        // Encapsulation, Polymorphism: Public because its called from anywhere. Virtual because child class can implement its own version.
        public virtual bool GoToLecture()
        {
            Console.WriteLine("Going to class to learn");
            return true;
        }
    }
}
