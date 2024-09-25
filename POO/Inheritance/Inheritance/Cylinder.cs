using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cylinder : AreaCalculator
    {
        protected double height;
        protected double volume;

        public void SetHeight(double h)
        {
            height = h;
        }

        public double GetHeight()
        {
            return height;
        }

        public void CalculateVolume()
        {
            volume = area * height;
        }

        public double GetVolume() 
        { 
            return volume; 
        }
    }
}
