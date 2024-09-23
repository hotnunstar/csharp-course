using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) continue;
                if (i == 8) break;
                Console.WriteLine(i);
            }

            // Find Prime Numbers
            Console.Write("Enter a number to check if it's prime or not: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + " is " + (isPrime(number) ? "" : "not ") + "a prime number.");

            // While Loop
            number = 10;
            while (number >= 1)
            {
                Console.WriteLine(number);
                number--;
            }

            // Even & Odd Finder
            int start = 5, end = 11;
            while (start <= end)
            {
                checkEvenOdd(start);
                start++;
            }

            // Do-While Loop
            int x = 6;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 5);

            // Sum of integers in a given range
            int z = 21, sum = 0;
            do
            {
                sum += z;
                z--;
            } while (z > 10);
            Console.WriteLine("Summation: " + sum);

            // Nested Loop
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }

            // Displaying a triangle using asterisks
            Console.Write("Enter the number of rows for the triangle: ");
            int numberOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine("\nRight-Angle Triangle:");

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Displaying a pyramid using asterisks
            Console.Write("Enter the number of rows for the pyramid: ");
            numberOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= numberOfRows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        #region Find Prime Numbers
        public static bool isPrime(int wholeNumber)
        {
            if (wholeNumber <= 2) return (wholeNumber == 2);

            for (int divisor = 2; divisor <= wholeNumber / 2; divisor++)
            {
                if ((wholeNumber % divisor) == 0) return false;
            }

            return true;
        }
        #endregion

        #region Even & Odd Finder
        public static void checkEvenOdd(int num)
        {
            if (num % 2 == 0) Console.WriteLine(num + " is even");
            else Console.WriteLine(num + " is odd");
        }
        #endregion
    }
}
