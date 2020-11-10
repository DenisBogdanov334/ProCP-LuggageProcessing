using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class Flight
    {
        private static int IdGenerator = 0;

        public Flight(DateTime departure)
        {
            FlightId = IdGenerator++;
            Departure = departure;
            Passengers = new List<Passenger>();
            Luggages = new List<Luggage>();
        }

        public int FlightId { get; set; }
        public DateTime Departure { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<Luggage> Luggages { get; set; }
    }
}