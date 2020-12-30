using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private List<Trailer> trailers;

        public int totalLuggageBeltA { get; set; }
        public int totalLuggageBeltB { get; set; }
        public int totalLuggageBeltC { get; set; }

        public LuggageManagement()
        {
            luggages = new List<Luggage>();
            flights = new List<UpcomingFlight>();
            passengers = new List<Passenger>();
            belts = new List<AirportBelt>();
            trailers = new List<Trailer>();
            totalLuggageBeltA = 10;
            totalLuggageBeltB = 61;
            totalLuggageBeltC = 94;
            LoadData();
            SetFlight();
        }

        private void LoadData()
        {
            belts.Add(new AirportBelt(400, 50, 75, "beltA"));
            belts.Add(new AirportBelt(450, 50, 75, "beltB"));
            belts.Add(new AirportBelt(500, 50, 75, "beltC"));

            flights.Add(new UpcomingFlight("F100A", "zoneA", DateTime.Parse("10:00:05"), 10));
            flights.Add(new UpcomingFlight("F100B", "zoneB", DateTime.Parse("10:00:15"), 10));
            flights.Add(new UpcomingFlight("F100C", "zoneC", DateTime.Parse("10:00:20"), 10));

            foreach (var flight in flights)
            {
                luggages.AddRange(flight.Luggages);
                luggages.Sort();
            }

            //passengers.Add(new Passenger(1001, "Joe", "Smith", "F100A"));
            //passengers.Add(new Passenger(1002, "Joe", "Smith", "F100B"));
            //passengers.Add(new Passenger(1003, "Joe", "Smith", "F100A"));
            //passengers.Add(new Passenger(1004, "Joe", "Smith", "F100B"));
            //passengers.Add(new Passenger(1005, "Joe", "Smith", "F100C"));
            //passengers.Add(new Passenger(1006, "Joe", "Smith", "F100A"));
            //passengers.Add(new Passenger(1007, "Joe", "Smith", "F100C"));
            //passengers.Add(new Passenger(1008, "Joe", "Smith", "F100A"));
            //passengers.Add(new Passenger(1009, "Joe", "Smith", "F100C"));
            //passengers.Add(new Passenger(1010, "Joe", "Smith", "F100B"));

            //luggages.Add(new Luggage(2001, 22.4, 10.5, 1001));
            //luggages.Add(new Luggage(2002, 22.4, 10.5, 1002));
            //luggages.Add(new Luggage(2003, 22.4, 10.5, 1003));
            //luggages.Add(new Luggage(2004, 22.4, 10.5, 1004));
            //luggages.Add(new Luggage(2005, 22.4, 10.5, 1005));
            //luggages.Add(new Luggage(2006, 22.4, 10.5, 1006));
            //luggages.Add(new Luggage(2007, 22.4, 10.5, 1007));
            //luggages.Add(new Luggage(2008, 22.4, 10.5, 1008));
            //luggages.Add(new Luggage(2009, 22.4, 10.5, 1009));
            //luggages.Add(new Luggage(2010, 22.4, 10.5, 1010));         

            trailers.Add(new Trailer("T100A", 80));
            trailers.Add(new Trailer("T100B", 80));
            trailers.Add(new Trailer("T100C", 80));

            trailers[0].Belt = belts[0];
            trailers[1].Belt = belts[1];
            trailers[2].Belt = belts[2];
        }

        private void SetFlight()
        {
            foreach (var luggage in luggages)
            {
                Passenger passenger = GetPassenger(luggage.ownerId);
                if (passenger != null)
                {
                    UpcomingFlight flight = GetFlight(passenger.flightNo);
                    if(flight != null)
                        luggage.Flight = GetFlight(passenger.flightNo);
                }
            }
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
                        case "zoneA": return GetBelt("beltA");
                        case "zoneB": return GetBelt("beltB");
                        case "zoneC": return GetBelt("beltC");
                        default:
                            break;
                    }
                }

            }
            return null;
        }

        internal void AddLoadedLuggageToTrailer(Luggage luggage)
        {
            foreach (var trailer in trailers)
            {
                if(trailer.Belt.Id == luggage.Belt.Id)
                {
                    trailer.CurrentLoad++;
                    trailer.luggages.Add(luggage);

                    //check if trailer is full or all luggages for current flight have been loaded to trailer
                    // if yes, move trailer to airplane
                    if (trailer.CurrentLoad == luggage.Flight.Luggages.Count || trailer.CurrentLoad == trailer.Capacity)
                    {
                        trailer.IsTransporting = true;
                    }
                }
            }
        }

        internal void MoveTrailers(int maxRight)
        {
            foreach (var trailer in trailers)
            {
                if(trailer.IsTransporting && trailer.position.X < maxRight)
                {
                    trailer.Transport();
                }
            }
        }

        internal List<Trailer> GetTrailers()
        {
            return this.trailers;
        }

        public void SetBelt(Luggage luggage)
        {
            if (luggage.Flight != null)
            {
                if (luggage.Flight.Zone == "zoneA")
                    luggage.Belt = belts[0];
                else if (luggage.Flight.Zone == "zoneB")
                    luggage.Belt = belts[1];
                else
                    luggage.Belt = belts[2];
            }
            luggage.status = Status.LoadedOnBelt;
            luggage.Belt.Loaded++;
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
                if (luggage.Belt != null)
                    luggage.Transport();
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

        public List<Luggage> GetLuggagesWaitingForLoading()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.WaitingForLoading)
                    result.Add(luggage);
            }
            return result;
        }

        public List<Luggage> GetLuggagesLoadedInTrailer()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.LoadedInTrailer)
                    result.Add(luggage);
            }
            return result;
        }

        public List<Luggage> GetLuggagesLoadedOnBelt()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.LoadedOnBelt)
                    result.Add(luggage);
            }
            return result;
        }

        public List<Luggage> GetLuggagesLoadedInAirplane()
        {
            var result = new List<Luggage>();
            foreach (var luggage in luggages)
            {
                if (luggage.status == Status.LoadedInAirplane)
                    result.Add(luggage);
            }
            return result;
        }

        public List<UpcomingFlight> GetAllFlights()
        {
            return this.flights;
        }
    }

}
