using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}");
        }

        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }

        protected virtual void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating at {speed} mph");
        }

        public void OperateVehicle(int speed)
        {
            StartEngine();
            Accelerate(speed);
        }
    }
}
