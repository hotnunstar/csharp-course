using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class EletricCar : Car
    {
        public EletricCar(string model, int year) : base(model, year) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electric Car - Model: {Model}, Year: {Year}");
        }

        protected override void StartEngine()
        {
            Console.WriteLine("Starting electric motor!");
        }
        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating silently at {speed} mph");
        }
    }
}
