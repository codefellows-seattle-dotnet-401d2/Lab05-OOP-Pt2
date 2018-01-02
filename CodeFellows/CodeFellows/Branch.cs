using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellows
{
    public abstract class Branch
    {
        protected string Location
        {
            get => Location;
            set
            {
                Location = value;
                Address = value;
            }
        }
        protected string Address
        {
            get => Address;
            private set
            {
                if (value == "Seattle")
                {
                    Address = "2901 3rd Ave";
                }
            }
        }
    }
}
