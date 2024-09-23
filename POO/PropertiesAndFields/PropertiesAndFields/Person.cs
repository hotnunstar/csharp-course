using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    internal class Person
    {
        private string _name;

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value)) _name = value;
                else Console.WriteLine("Name cannot be null or empty");
            }
            get { return _name; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
