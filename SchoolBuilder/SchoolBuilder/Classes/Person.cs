using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder.Classes
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Groups { get; set; }
    }
}
