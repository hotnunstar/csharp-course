using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDelegates
{
    internal class Calculator
    {
        public delegate int BinaryOperation(int a, int b);
        public int Add(int a, int b)
        {
            return a + b; 
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
