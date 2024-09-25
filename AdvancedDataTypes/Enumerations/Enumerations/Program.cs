using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            for (int i = 0; i < 5; i++)
            {
                trafficLight.DisplayColor();
                Console.WriteLine("Press ENTER to change the traffic light color...");
                Console.ReadLine();
                trafficLight.ChangeColor();
            }
        }
    }
}
