using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DenisProCP
{
    public static class Factory
    {
        public static List<AirportBelt> FakeBelts()
        {
            List<AirportBelt> belts = new List<AirportBelt>();

            belts.Add(new AirportBelt("BeltA",150, FakeEmployees()[0]));
            belts.Add(new AirportBelt("BeltB",170, FakeEmployees()[1]));
            belts.Add(new AirportBelt("BeltC",225, FakeEmployees()[2]));

            return belts;
        }

        public static List<AirportEmployee> FakeEmployees()
        {
            List<AirportEmployee> employees = new List<AirportEmployee>();

            employees.Add(new AirportEmployee("Denis"));
            employees.Add(new AirportEmployee("Viktor"));
            employees.Add(new AirportEmployee("Stefan"));

            return employees;
        }

        public static List<Passenger> FakePassengers(int flightId)
        {
            List<Passenger> passengers = new List<Passenger>();

            passengers.Add(new Passenger(true, flightId));
            passengers.Add(new Passenger(true, flightId));
            passengers.Add(new Passenger(true, flightId));
            passengers.Add(new Passenger(true, flightId));
            passengers.Add(new Passenger(true, flightId));

            return passengers;
        }

        public static List<Luggage> FakeLuggages(List<Passenger> passengers)
        {
            List<Luggage> luggages = new List<Luggage>();

            passengers.ForEach(passenger =>
            {
                if (passenger.Priority)
                {
                    luggages.Add(new Luggage(passenger.Id, 24));
                }
                luggages.Add(new Luggage(passenger.Id, 14));
            });

            return luggages;
        }

        public static List<Flight> FakeFlights()
        {
            List<Flight> flights = new List<Flight>();

            flights.Add(new Flight(new DateTime(2020, 11, 15, 13, 20, 00, 00)));
            flights.Add(new Flight(new DateTime(2020, 11, 15, 13, 30, 00, 00)));
            flights.Add(new Flight(new DateTime(2020, 11, 15, 13, 40, 00, 00)));

            flights.ForEach(flight =>
            {
                flight.Passengers = FakePassengers(flight.FlightId);
                flight.Luggages = FakeLuggages(flight.Passengers);
            });

            return flights;
        } 
    }
}