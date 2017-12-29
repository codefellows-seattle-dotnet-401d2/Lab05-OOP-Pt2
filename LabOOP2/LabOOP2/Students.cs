using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP2
{
    internal class Students : People
    {
        public String DateOfBirth { get; set; }
        public String[] ListOfHobbies { get; set; }
        public bool MilitaryVeteran { get; set; }

        public string Study()
        {
            return "I want that 70k Salary";
        }
    }
}
