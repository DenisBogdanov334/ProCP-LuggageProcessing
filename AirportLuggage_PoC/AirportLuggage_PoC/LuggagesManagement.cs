using DenisProCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class LuggageManagement
    {
        private List<Luggage> luggages;
        private List<UpcomingFlight> flights;
        private List<Passenger> passengers;
        private List<AirportBelt> belts;

        public int totalLuggageBeltA { get; set; }
        public int totalLuggageBeltB { get; set; }
        public int totalLuggageBeltC { get; set; }


        public LuggageManagement()
        {
            luggages = new List<Luggage>();
            flights = new List<UpcomingFlight>();
            passengers = new List<Passenger>();
            belts = new List<AirportBelt>();
            totalLuggageBeltA = 10;
            totalLuggageBeltB = 61;
            totalLuggageBeltC = 94;

            LoadData();
        }

        private void LoadData()
        {
            belts.Add(new AirportBelt(400, 50, 75, "beltA"));
            belts.Add(new AirportBelt(500, 50, 75, "beltB"));
            belts.Add(new AirportBelt(600, 50, 75, "beltC"));

            flights.Add(new UpcomingFlight("F100A", "zoneA"));
            flights.Add(new UpcomingFlight("F100B", "zoneB"));
            flights.Add(new UpcomingFlight("F100C", "zoneC"));

            passengers.Add(new Passenger(1001, "Joe", "Smith", "F100A"));
            passengers.Add(new Passenger(1002, "Joe", "Smith", "F100A"));
            passengers.Add(new Passenger(1003, "Joe", "Smith", "F100A"));
            passengers.Add(new Passenger(1004, "Joe", "Smith", "F100B"));
            passengers.Add(new Passenger(1005, "Joe", "Smith", "F100C"));

            luggages.Add(new Luggage(2001, 22.4, 10.5, 1001));
            luggages.Add(new Luggage(2002, 22.4, 10.5, 1002));
            luggages.Add(new Luggage(2003, 22.4, 10.5, 1003));
            luggages.Add(new Luggage(2004, 22.4, 10.5, 1004));
            luggages.Add(new Luggage(2005, 22.4, 10.5, 1005));

            
        }

       
        
        private AirportBelt SetBeltForLuggage(Luggage luggage)
        {
            
            Passenger passenger = GetPassenger(luggage.ownerId);
            if (passenger != null)
            {
                UpcomingFlight flight = GetFlight(passenger.flightNo);
                if (flight != null)
                {
                    switch (flight.Zone)
                    {
                        case "zoneA":
                            {
                                totalLuggageBeltA++;
                                return GetBelt("beltA");
                            }
                        case "zoneB":
                            {
                                totalLuggageBeltB++;
                                return GetBelt("beltB");
                            }
                        case "zoneC":
                            {
                                totalLuggageBeltC++;
                                return GetBelt("beltC");
                            }
                        default:
                            break;
                    }
                }

            }
            return null;
        }

        private AirportBelt SetBeltForLuggage(Luggage luggage, UpcomingFlight flight)
        {
            Passenger passenger = GetPassenger(luggage.ownerId);
            if (passenger != null)
            {
                UpcomingFlight upcomingFlight = GetFlight(passenger.flightNo);
                if (flight.FlightNo == upcomingFlight.FlightNo)
                {
                    switch (flight.Zone)
                    {
                        case "zoneA": return GetBelt("beltA");
                        case "zoneB": return GetBelt("beltB");
                        case "zoneC": return GetBelt("beltC");
                        default: throw new NotSupportedException();
                    }
                }
            }
            return null;
        }

        public List<Luggage> GetAllLuggages()
        {
            return this.luggages;
        }

        public List<Luggage> GetAllLuggages(string flightNo)
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                Passenger passenger = GetPassenger(luggage.ownerId);
                if (passenger != null)
                {
                    UpcomingFlight upcomingFlight = GetFlight(passenger.flightNo);
                    if (upcomingFlight.FlightNo == flightNo)
                        result.Add(luggage);
                }
            }
            return result;
        }

        public List<AirportBelt> GetBelts()
        {
            return this.belts;
        }

        private Passenger GetPassenger(int pid)
        {
            foreach (var passenger in passengers)
            {
                if (passenger.id == pid)
                    return passenger;
            }
            return null;
        }
        public List<Passenger> GetAllpassengers()
        {
            return this.passengers;
        }

        public List<UpcomingFlight> GetAllFlights()
        {
            return this.flights;
        }

        private UpcomingFlight GetFlight(string fid)
        {
            foreach (var flight in flights)
            {
                if (flight.FlightNo == fid)
                    return flight;
            }
            return null;
        }

        private AirportBelt GetBelt(string bid)
        {
            foreach (var belt in belts)
            {
                if (belt.Id == bid)
                    return belt;
            }
            return null;
        }

        public void MoveAllLuggage()
        {
            foreach (var luggage in luggages)
            {
                AirportBelt belt = SetBeltForLuggage(luggage);
                if (belt != null)
                    luggage.Transport(belt);
            }
        }

        public void MoveLuggagePerFlight(string flightNo)
        {
            var luggages = GetAllLuggages(flightNo);
            var flight = GetFlight(flightNo);
            foreach (var luggage in luggages)
            {
                AirportBelt belt = SetBeltForLuggage(luggage, flight);
                if (belt != null && !luggage.IsReachingObstacles(luggages))
                    luggage.Transport(belt);
            }
        }

        public void MoveLuggage(Luggage luggage)
        {
            AirportBelt belt = SetBeltForLuggage(luggage);
            if (belt != null)
                luggage.Transport(belt);
        }

        public List<Luggage> GetAllUnLoadedLuggages()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.WaitingForLoading)
                    result.Add(luggage);
            }
            return result;
        }

        public List<Luggage> GetAllLoadedLuggages()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.Loaded)
                    result.Add(luggage);
            }
            return result;
        }
    }

}
