using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder
{
    // abstract class School
    abstract class School
    {
        public string[] StudentRoster(get; set; )

        public string[] EmployeeRoster(get; set; )

        abstract public string MailingAddress(get; set; )

        abstract public string PrimaryCampus(get; set; )

        abstract public void EmailStaff()
        {
            for(i = 0; i < self.EmployeeRoster.length; i++)
            {
                Console.WriteLine("Sending Email to " + self.EmployeeRoster[i]);
            }
        }

        abstract public void EmailStudents()
        {
            for (i = 0; i < self.StudentRoster.length; i++)
            {
                Console.WriteLine("Sending Email to " + self.StudentRoster[i]);
            }
        }

        abstract public void EmailEveryone()
        {
            EmailStaff();
            EmailStudents();
        }
    }
}
