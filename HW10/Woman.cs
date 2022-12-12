using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
     class Woman: Human
    {
        public Woman()
        {
            Name = "By Default";
            LastName = "By Default";
        }

        public Woman(string name, string lastName)
        {
            
            Name=name;
            LastName=lastName;
        }
    }
}
