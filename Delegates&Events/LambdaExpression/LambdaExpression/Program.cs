using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "John", Salary = 50000 },
                new Employee { Id = 2, Name = "Alice", Salary = 60000 },
                new Employee { Id = 3, Name = "Bob", Salary = 55000 },
                new Employee { Id = 4, Name = "Eve", Salary = 52000 },
            };

            Console.WriteLine("Original list of employees:");
            DisplayEmployees(employees);

            var sortedByName = employees.OrderBy(e => e.Name).ToList();
            Console.WriteLine("\nSorted list of employees by name:");
            DisplayEmployees(sortedByName);

            var sortedBySalary = employees.OrderByDescending(e => e.Salary).ToList();
            Console.WriteLine("\nSorted list of employees by salary (descending):");
            DisplayEmployees(sortedBySalary);
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees) 
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}€");
            }
            Console.WriteLine();
        }
    }
}
