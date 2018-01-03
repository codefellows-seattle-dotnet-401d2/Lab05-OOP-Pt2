using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    // Encapsulation and Abstraction. All classes inherit from here.
    public abstract class Branch
    {
        protected string Location { get; set; }
        protected string Address { get; set; }
    }
}
