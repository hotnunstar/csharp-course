using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollection
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("University student management system");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAllStudents();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("Enter the student details:");
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string department = Console.ReadLine();

            Student newStudent = new Student
            {
                StudentId = studentId,
                Name = name,
                Age = age,
                Department = department,
            };

            students.Add(newStudent);

            Console.WriteLine("Student added successfully!\n");
        }

        static void DisplayAllStudents()
        {
            if (students.Any())
            {
                Console.WriteLine("\nList of all students:");
                var studentQuery = from student in students select student;

                foreach (var student in studentQuery)
                {
                    Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("No students found.\n");
        }
    }
}
