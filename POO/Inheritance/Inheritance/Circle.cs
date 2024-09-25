using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Circle
    {
        protected double radius;

        public void SetRadius(double r)
        {
            radius = r;
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
