using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Person : Branch
    {
        internal string Name { get; set; }
        protected DateTime Birthday { get; set; }
        protected string Email { get; set; }
    }
}
