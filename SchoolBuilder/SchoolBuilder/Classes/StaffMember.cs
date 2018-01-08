using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder.Classes
{
    public class StaffMember : Person
    {
        public string JobTitle { get; set; }

        public StaffMember(string firstname, string lastname, string email, string phonenumber, string jobtitle)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            JobTitle = jobtitle;
        }
    }
}
