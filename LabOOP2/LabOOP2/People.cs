using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP2
{

    abstract class People : CodeFellows
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        

        // Virtual property
        public virtual int YearsOfExperience { get; set; }
    }
}