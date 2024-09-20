using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -5;
            if (num > 0)  Console.WriteLine("Number is Positive");
            else Console.WriteLine("Number is Negative");

            #region Ladder if-else Statement
            int marks = 65;
            if (marks >= 90) Console.WriteLine("Excellent");
            else if (marks >= 70 && marks <= 89) Console.WriteLine("Good");
            else if (marks >= 50 && marks <= 69) Console.WriteLine("Pass");
            else Console.WriteLine("Poor");

            int age = 30;
            if (age < 18) Console.WriteLine("Child");
            else if (age >= 18 && age <= 20) Console.WriteLine("Teenager");
            else if (age >= 21 && age <= 65) Console.WriteLine("Adult");
            else Console.WriteLine("Senior Citizen");

            string day = "Tuesday";
            if (day == "Monday") Console.WriteLine("Monday Blues");
            else if (day == "Tuesday") Console.WriteLine("Tuesday Vibes");
            else if (day == "Wednesday") Console.WriteLine("Hump Day");
            else if (day == "Thursday") Console.WriteLine("Almost Friday");
            else if (day == "Friday") Console.WriteLine("TGIF");
            else if (day == "Saturday") Console.WriteLine("Weekend");
            else if (day == "Sunday") Console.WriteLine("Weekend Hangover");
            else Console.WriteLine("Invalid Day");
            #endregion

            #region Nested if-else Statement
            int number = 5;
            if(number > 0)
            {
                if (number % 2 == 0) Console.WriteLine("Number is Positive and Even");
                else Console.WriteLine("Number is Positive but not Even");
            }
            else Console.WriteLine("Number is not Positive");
            #endregion

            #region Switch Statement
            int weekDay = 3;
            switch (weekDay) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default: 
                    Console.WriteLine("Invalid Day");
                    break;
            }
            #endregion

            #region Enhanced Switch Statement
            int value = 3;
            string result = value switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };
            Console.WriteLine(result);
            #endregion

            #region Exercise Area Calculation: Shapes
            string shape = "Parallelogram";
            double majorAxis = 11, minorAxis = 16;
            double topBase = 0, bottomBase = 0, height = 0;
            double base1 = 11, heightPara = 14;
            double areaResult;

            areaResult = shape switch
            {
                "Ellipse" => (3.14 * majorAxis * minorAxis),
                "Trapezoid" => (((topBase + bottomBase) / 2) * height),
                "Parallelogram" => (base1 * heightPara),
                _ => 0
            };
            Console.WriteLine($"{shape}: {areaResult}");
            #endregion
        }
    }
}
