using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder.Classes
{
    class Student : Person
    {
        public Student(string firstname, string lastname, string email, string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
        }
    }
}
