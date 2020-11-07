using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    class AirportBelt
    {
        public int length { get; set; }
        public double supportedWeight { get; set; }
        public double speed { get; set; }
        public double currentLoad { get; set; }

        public AirportBelt(int length, double weight, double speed)
        {
            this.length = length;
            this.supportedWeight = weight;
            this.speed = speed;
            this.currentLoad = 0;
        }

        public bool AddLuggage(double luggageWeight)
        {
            if (currentLoad + luggageWeight <= supportedWeight)
            {
                return true;
            }
            else return false;
        }
    }
}
