using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate double MathOperation(double x, double y);
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            MathOperation addDelegate = Add;
            MathOperation subtractDelegate = Subtract;
            MathOperation multiplyDelegate = Multiply;
            MathOperation divideDelegate = Divide;

            double resultAdd = PerformOperation(number1, number2, addDelegate);
            double resultSubtract = PerformOperation(number1, number2, subtractDelegate);
            double resultMultiply = PerformOperation(number1, number2, multiplyDelegate);
            double resultDivide = PerformOperation(number1, number2, divideDelegate);

            Console.WriteLine($"Addiction Result: {resultAdd}");
            Console.WriteLine($"Subtraction Result: {resultSubtract}");
            Console.WriteLine($"Multiplication Result: {resultMultiply}");
            Console.WriteLine($"Division Result: {resultDivide}");
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y) 
        { 
            if(y != 0 ) return x / y; 
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN;
            }
        }

        static double PerformOperation(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }
    }
}
