using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Occupation: ");
            string occupation = Console.ReadLine();

            var personData = new Tuple<string, int, string>(name, age, occupation);

            object[] dataArray = { personData.Item1, personData.Item2, personData.Item3 };

            Console.WriteLine("\nPerson Data:");
            foreach (var item in dataArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
