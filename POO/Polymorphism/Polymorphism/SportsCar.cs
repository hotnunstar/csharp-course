using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class SportsCar : Car
    {
        public SportsCar(string model, int year) : base(model, year) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sports Car - Model: {Model}, Year: {Year}");
        }

        protected override void Accelerate(int speed)
        {
            base.Accelerate(speed);
            Console.WriteLine("Performing a high-speed acceleration!");
        }
    }
}
