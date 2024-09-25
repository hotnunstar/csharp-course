using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car regularCar = new Car("Sedan", 2022);
            SportsCar sportsCar = new SportsCar("Supercar", 2023);
            EletricCar eletricCar = new EletricCar("Tesla", 2022);

            regularCar.DisplayInfo();
            sportsCar.DisplayInfo();
            eletricCar.DisplayInfo();

            Console.WriteLine();

            regularCar.OperateVehicle(60);
            sportsCar.OperateVehicle(120);
            eletricCar.OperateVehicle(70);
        }
    }
}
