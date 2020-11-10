using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DenisProCP.Factory
{
    public static class Factory
    {
        public static List<AirportEmployee> FakeEmployees()
        {
            List<AirportEmployee> employees = new List<AirportEmployee>();

            employees.Add(new AirportEmployee("Denis"));
            employees.Add(new AirportEmployee("Viktor"));
            employees.Add(new AirportEmployee("Stefan"));
            employees.Add(new AirportEmployee("Martin"));
            employees.Add(new AirportEmployee("Georgi"));

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

            flights.Add(new Flight(new DateTime()));
            flights.Add(new Flight(new DateTime()));
            flights.Add(new Flight(new DateTime()));
            flights.Add(new Flight(new DateTime()));
            flights.Add(new Flight(new DateTime()));

            return flights;
        }

        public static void SeedData()
        {
            var flights = FakeFlights();

            flights.ForEach(flight =>
            {
                flight.Passengers = FakePassengers(flight.FlightId);
                flight.Luggages = FakeLuggages(flight.Passengers);
            });
        }
    }
}