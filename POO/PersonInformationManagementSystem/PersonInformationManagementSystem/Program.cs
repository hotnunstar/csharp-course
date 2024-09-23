using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 0) person.Age = age;
            else Console.WriteLine("Invalid age input. age set to 0.");

            Console.Write("Enter address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter position: ");
            person.Position = Console.ReadLine();

            Console.Write("Enter department: ");
            person.Department = Console.ReadLine();

            Console.WriteLine("\nPerson Information:");
            person.DisplayPersonInfo();
        }
    }
}