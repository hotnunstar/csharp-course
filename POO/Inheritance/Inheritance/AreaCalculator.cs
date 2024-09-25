using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AreaCalculator : Circle
    {
        protected double area;

        public void CalculateArea()
        {
            area = Math.PI * radius * radius;
        }

        public double GetArea()
        {
            return area;
        }
    }
}
