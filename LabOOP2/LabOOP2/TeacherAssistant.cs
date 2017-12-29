using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP2
{
    internal class TeacherAssistant : Staff

    {
        public string Role { get; set; }
        public bool RecentGraduate { get; set; }

        // virtual method to overide 
        public override int YearsOfExperience => 1;
    }
}
