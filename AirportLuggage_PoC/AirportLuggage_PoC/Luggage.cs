using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Luggage
    {
        public int id { get; set; }
        public double weight { get; set; }
        public double volume { get; set; }
        public int ownerId { get; set; }

        public Luggage(int id, double weight, double volume, int owner)
        {
            this.id = id;
            this.weight = weight;
            this.volume = volume;
            this.ownerId = owner;
        }

        public string displayInfo()
        {
            string s;
            s = "Luggage no: " + this.id + ", Weight: " + weight + "kg";
            return s;
        }
    }
}
