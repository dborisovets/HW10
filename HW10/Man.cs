using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Man : Human
    {
        public Man()
        {
            Name = "By Default";
            LastName = "By Default";
        }
        public Man(string name, string lastName)
        {

            Name = name;
            LastName = lastName;
        }
    }
}
