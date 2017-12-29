using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP2
{
    public abstract class CodeFellows
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
     
        public string CodeOfConduct()
        {
            string phrase =
                "NO CHEATING";
            return phrase;
        }
    }
}
