using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class UpcomingFlight
    {
        public string FlightNo { get; private set; } 
        public string Zone { get; set; }
        public DateTime DepartureTime { get; set; }

        public List<Luggage> Luggages;
        public UpcomingFlight(string flight, string zone)
        {
            this.FlightNo = flight;
            this.Zone = zone;
            this.Luggages = new List<Luggage>();
        }

        public UpcomingFlight(string flight, string zone, DateTime departureTime, int nrOfLuggages)
        {
            this.FlightNo = flight;
            this.Zone = zone;
            this.DepartureTime = departureTime;
            this.Luggages = new List<Luggage>();
            this.setDummyLuggages(nrOfLuggages);
        }

        public override string ToString()
        {
            return this.FlightNo + ":" + this.Luggages.Count + " luggages departures " + this.DepartureTime.ToString("hh:mm:ss") + " from "+ this.Zone;
        }

        private void setDummyLuggages (int nrOfLuggages)
        {
            Random rdm = new Random();
            for (int i = 0; i < nrOfLuggages; i++)
            {
                Luggages.Add(new Luggage(rdm.Next(5, 30), this));
            }
        }
    }
}
