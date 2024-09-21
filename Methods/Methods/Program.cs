using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintString();
            Modifiers(1, "Nuno");
            Console.WriteLine("Area of circle is: " + CalculateArea(10.5, 3.14));

            // Student Position Finder
            Console.Write("Enter the name for the first student: ");
            string studentName = Console.ReadLine();
            Console.Write($"Enter the score for {studentName} :");
            int studentNumbers = int.Parse(Console.ReadLine());
            int studentPosition = PositionMethod(studentNumbers);
            Print(studentName, studentPosition);

            // Temperature Conversion
            Console.Write("Enter the temperature scale (F or C): ");
            char tempName = char.Parse(Console.ReadLine());
            Console.Write("Enter the temperature value: ");
            double tempValue = double.Parse(Console.ReadLine());
            double calculatedResult = CalculateTemperature(tempName, tempValue);
            PrintResult(tempName, calculatedResult);

            // Leap Year Finder
            Console.Write("Enter a year to check its leap year or not: ");
            CheckLeapYear(int.Parse(Console.ReadLine()));

            // Rectangle & Square Calculations
            Console.Write("Enter the length of the rectangle: ");
            int rectangleLength = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int rectangleWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter the side length of the square: ");
            int squareSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter of Rectangle: " + PerimeterRectangle(rectangleLength, rectangleWidth));
            Console.WriteLine("Area of Rectangle: " + AreaRectangle(rectangleLength, rectangleWidth));
            Console.WriteLine("Perimeter of Square: " + PerimeterSquare(squareSide));
            Console.WriteLine("Area of Square: " + AreaSquare(squareSide));

            // Method Overloading
            Add();
            Add(10, 20);
            Add(100, 200, 300);

            // Shape Areas Calculation
            Console.WriteLine("Area of rectangle: " + Area(30.0, 20.0));
            Console.WriteLine("Area of triangle: " + Area(30));
            Console.WriteLine("Area of square: " + Area(50.0, 10.0, 0.5));
            Console.WriteLine("Area of circle: " + Area(40.0));

            // String Concatenation with method
            Console.WriteLine("Concatenation without separator: " + Concatenate("Nuno", "Araújo"));
            Console.WriteLine("Concatenation with separator: " + Concatenate("Nuno", "Araújo", " - "));

            // Exception Handling
            Console.Write("Enter numerator value: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator value: ");
            int denominator = int.Parse(Console.ReadLine());

            try
            {
                int result = numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. The denominator must be greater than zero");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }

            Console.WriteLine("Program continues executing after the 'try-catch-finally' block.");
        }

        public static void PrintString()
        {
            Console.WriteLine("Hello World");
        }

        public static void Modifiers(int number, string name)
        {
            Console.WriteLine("First parameter value is: " + number);
            Console.WriteLine("Second parameter value is: " + name);
        }

        public static double CalculateArea(double radius, double pi)
        {
            return radius * radius * pi;
        }

        #region Student Position Finder
        public static int PositionMethod(int number)
        {
            if (number < 50) return 0;
            else if (number >= 50 && number <= 60) return 5;
            else if (number >= 61 && number <= 70) return 4;
            else if (number >= 71 && number <= 80) return 3;
            else if (number >= 81 && number <= 90) return 2;
            else return 1;
        }

        public static void Print(string stdName, int position)
        {
            Console.WriteLine($"Student name is: {stdName} & Position is: {position}");
        }
        #endregion

        #region Temperature Conversion
        public static double CalculateTemperature(char tempChar, double temperature)
        {
            if (tempChar == 'F') return (temperature - 32) * 5 / 9;
            else if (tempChar == 'C') return (temperature * 9 / 5) + 32;
            else return 0;
        }

        public static void PrintResult(char tempName, double result)
        {
            Console.WriteLine($"Temperature is: {result} {tempName}");
        }
        #endregion

        #region Leap Year Finder
        public static void CheckLeapYear(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) Console.WriteLine(year + " is a leap year");
            else Console.WriteLine(year + " is not a leap year");
        }
        #endregion

        #region Rectangle & Square Calculations
        public static int PerimeterRectangle(int length, int width)
        {
            return 2 * (length + width);
        }

        public static int AreaRectangle(int length, int width)
        {
            return length * width;
        }

        public static int PerimeterSquare(int side)
        {
            return 4 * side;
        }

        public static int AreaSquare(int side)
        {
            return side * side;
        }
        #endregion

        #region Method Overloading
        public static void Add()
        {
            Console.WriteLine("Method with no parameter");
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"Method with two parameters: {a} & {b}");
        }

        public static void Add(int a, int b, int c)
        {
            Console.WriteLine($"Method with three parameters: {a}, {b} & {c}");
        }
        #endregion

        #region Shape Areas Calculation
        public static double Area(double length, double width)
        {
            return length * width;
        }
        
        public static double Area(int side)
        {
            return side * side;
        }

        public static double Area(double base1, double height, double shape)
        {
            return 0.5 * base1 * height;
        }

        public static double Area(double radius)
        {
            return 3.14 * radius * radius;
        }
        #endregion

        #region String Concatenation with method
        public static string Concatenate(string s1, string s2)
        {
            return s1 + s2;
        }

        public static string Concatenate(string s1, string s2, string separator)
        {
            return s1 + separator + s2;
        }
        #endregion
    }
}
