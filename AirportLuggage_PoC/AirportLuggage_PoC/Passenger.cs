using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Passenger
    {
        public int TicketID { get; set; }
        public int FlightNum { get; set; }
        public bool Priority { get; set; }
        public int Luggage { get; set; }

        public Passenger(int ticket, int flightNum, bool priority)
        {
            TicketID = ticket;
            FlightNum = flightNum;
            // if you don't get what this does, research it fam
            Luggage = priority ? 2 : 1;
        }
    }
}
