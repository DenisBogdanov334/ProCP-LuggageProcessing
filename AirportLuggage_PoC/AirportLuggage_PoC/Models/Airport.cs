using System;
using System.Collections.Generic;
using System.Text;


namespace DenisProCP
{
    public class Airport
    {
        public List<AirportBelt> Belts { get; set; }
        public List<Flight> Flights { get; set; }
        public List<AirportEmployee> Employees { get; set; }

        public Airport(List<AirportBelt> belts, List<Flight> flights, List<AirportEmployee> employees)
        {
            Belts = belts;
            Flights = flights;
            Employees = employees;
        }
    }
}