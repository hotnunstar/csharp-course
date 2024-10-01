using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int resultAdd = calculator.Add(5, 3);
            Console.WriteLine("Addition result: " + resultAdd);

            int resultSubtract = calculator.Subtract(5, 3);
            Console.WriteLine("Subtraction result: " + resultSubtract);

            TestAddition();
            TestSubtraction();
        }

        public static void TestAddition()
        {
            Calculator calculator = new Calculator();
            Calculator.BinaryOperation addDelegate = calculator.Add;

            int result = addDelegate(5, 3);
            Console.WriteLine("Unit Test - Addition: " + (result == 8 ? "Passed" : "Failed"));
        }

        public static void TestSubtraction()
        {
            Calculator calculator = new Calculator();
            Calculator.BinaryOperation subtractDelegate = calculator.Subtract;

            int result = subtractDelegate(5, 3);
            Console.WriteLine("Unit Test - Subtraction: " + (result == 2 ? "Passed" : "Failed"));
        }
    }
}
