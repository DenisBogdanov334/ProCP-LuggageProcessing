using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class Passenger
    {
        private static int PassengerIdGenerator = 0;

        public Passenger(bool priority, int flightId)
        {
            PassengerIdGenerator++;
            Priority = priority;
            FlightId = flightId;

            if (Priority) AmountLuggage = 2;

            AmountLuggage = 1;
        }

        public int Id { get; set; }
        public int FlightId { get; set; }
        public bool Priority { get; set; }
        public int AmountLuggage { get; set; }
    }
}