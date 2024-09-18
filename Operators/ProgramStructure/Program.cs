using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic Operators
            int first = 2;
            int second = 3;
            int sum = first + second;
            Console.WriteLine(sum);

            int number = 1;
            number = number + 1;
            Console.WriteLine(number);

            int myNumber = 10;
            myNumber++;
            myNumber += 1;
            Console.WriteLine(myNumber);

            int x = 2;
            int y = 3;
            x *= y;
            Console.WriteLine(x);

            double pointNumber = 5.5;
            pointNumber += 4.5;
            Console.WriteLine(pointNumber);
            #endregion

            #region Conditional Statments and Operators
            bool flag = true;
            if (flag)
            {
                Console.WriteLine("Flag is True");
            }
            #endregion

            #region Logical Operators
            int age = 20;
            if (age > 18)
            {
                Console.WriteLine("Condition is True");
            }

            string gender = "male";
            if (gender == "male")
            {
                Console.WriteLine("Condition is True");
            }

            if (age > 18 && gender == "male")
            {
                Console.WriteLine("Eligible");
            }

            double examScore = 85;
            if (examScore >= 60 || examScore <= 100)
            {
                Console.WriteLine("The student has passed the Exam");
            }

            double num = 6;
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("The Number is even or divisible by 3");
            }

            int num1 = 7;
            if (!(num1 % 2 == 0))
            {
                Console.WriteLine("The Number is odd");
            }
            #endregion

            #region Assignment Operators
            int c = 10;
            c += 5;
            Console.WriteLine(c);

            int j = 10, i = 10;
            if (j == i)
            {
                Console.WriteLine("Both are equal");
            }

            bool z = true;
            if (z = false)
            {
                Console.WriteLine("This will not be printed to the console.");
            }
            Console.WriteLine("The value of 'z' after the if statement: " + z);

            #endregion

            #region Comparison Operators
            int q = 5, w = 3, e = 4;
            if (q > w && q > e)
            {
                Console.WriteLine("x is the largest number");
            }

            int score = 85;
            string grade;
            if (score >= 80 && score <= 95)
            {
                grade = "A";
                Console.WriteLine(grade);
            }
            #endregion

            #region Ternary Operators
            int minutes = 67;
            string status;

            status = (minutes < 60) ? "Less than an hour" : "More than an hour";
            Console.WriteLine(status);
            #endregion
        }
    }
}
