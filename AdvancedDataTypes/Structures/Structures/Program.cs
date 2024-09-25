using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{

    struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(5.0, 10.0);

            Console.WriteLine("Rectangle Width: " + myRectangle.Width);
            Console.WriteLine("Rectangle Heigth: " + myRectangle.Height);
            Console.WriteLine("Rectangle Area: " + myRectangle.CalculateArea());
        }
    }
}
