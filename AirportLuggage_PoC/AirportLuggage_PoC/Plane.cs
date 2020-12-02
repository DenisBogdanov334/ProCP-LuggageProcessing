using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    class Plane
    {
        public int NrFlight { get; set; }
        public int NrOfLuggages { get; set; }
        public DateTime FlightTime { get; set; }
        public Zone Zone { get; set; }
        public AirportBelt Belt { get; set; }
    }
}
