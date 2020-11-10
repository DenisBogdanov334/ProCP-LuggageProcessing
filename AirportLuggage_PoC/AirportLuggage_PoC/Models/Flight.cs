using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class Flight
    {
        private static int IdGenerator = 100;
        public int FlightId { get; set; }
        public DateTime Departure { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<Luggage> Luggages { get; set; }

        public Flight(DateTime departure)
        {
            FlightId = IdGenerator++;
            Departure = departure;
            Passengers = new List<Passenger>();
            Luggages = new List<Luggage>();
        }
    }
}