using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();

            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            double height = Convert.ToDouble(Console.ReadLine());

            cylinder.SetRadius(radius);
            cylinder.SetHeight(height);

            cylinder.CalculateArea();
            cylinder.CalculateVolume();

            Console.WriteLine($"Radius of the circle: {cylinder.GetRadius()}");
            Console.WriteLine($"Area of the circle: {cylinder.GetArea()}");
            Console.WriteLine($"Height of the cylinder: {cylinder.GetHeight()}");
            Console.WriteLine($"Volume of the cylinder: {cylinder.GetVolume()}");

        }
    }
}
