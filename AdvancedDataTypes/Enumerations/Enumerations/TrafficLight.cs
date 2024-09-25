using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }
    internal class TrafficLight
    {
        private TrafficLightColor currentColor;

        public TrafficLight()
        {
            currentColor = TrafficLightColor.Red;
        }

        public void ChangeColor()
        {
            switch (currentColor)
            {
                case TrafficLightColor.Red:
                    currentColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Yellow:
                    currentColor = TrafficLightColor.Red;
                    break;
                case TrafficLightColor.Green:
                    currentColor = TrafficLightColor.Yellow;
                    break;
            }
        }

        public void DisplayColor()
        {
            Console.WriteLine($"Traffic Light is currently {currentColor}");
        }
    }
}
