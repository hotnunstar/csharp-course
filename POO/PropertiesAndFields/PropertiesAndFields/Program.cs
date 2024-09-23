using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personObject = new Person();
            personObject.Name = "Anderson Smith";
            personObject.DisplayInfo();
        }
    }
}
