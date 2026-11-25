using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31
{
    public class Organization
    {
        public string Name { get; set; }
        public string Address;

        public Organization(string name)
        {
            this.Name = name;
        }
    }
}
