using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class UpcomingFlight
    {
        public int FlightNum { get; set; }
        public DateTime DepartureTime { get; set; }

        public UpcomingFlight (int flightNum, DateTime departureTime, List<Passenger> passengers)
        {
            this.DepartureTime = departureTime;
            this.FlightNum = flightNum;
        }
    }
}
