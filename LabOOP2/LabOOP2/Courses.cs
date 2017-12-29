using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP2
{

    abstract class Courses : CodeFellows
    {
        // Properties
        public byte Code { get; set; }
        public int CourseCost { get; set; }
        public int CourseLength { get; set; }

    }
}