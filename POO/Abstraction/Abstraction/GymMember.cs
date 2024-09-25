using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class GymMember
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public GymMember(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public abstract void DisplayMembershipDetails();
    }
}
