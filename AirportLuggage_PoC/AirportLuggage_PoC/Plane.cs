using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Plane
    {
        public int NrFlight { get; set; }
        public int NrOfLuggages { get; set; }
        public DateTime FlightTime { get; set; }
        public Zone Zone { get; set; }
        public AirportBelt Belt { get; set; }
        public Trailer Trailer { get; set; }
        public int NeededEmployees { get; set; }
        public List<Luggage> luggages { get; set; }
        public string StartLoadingTime { get; set; }
        public string EndLoadingTime { get; set; }

        public void FillLuggageList()
        {
            luggages = new List<Luggage>();
            for (int i = 0; i < NrOfLuggages; i++)
            {
                luggages.Add(new Luggage(i));
            }
        }
        public List<Luggage> GetLuggages()
        {
            return luggages;
        }

        public DateTime GetLoadingTimeToWagon()
        {
            DateTime loadingTime = new DateTime();
            loadingTime = loadingTime.AddSeconds(Belt.Length * NrOfLuggages);
            loadingTime = loadingTime.AddMinutes(NrOfLuggages);
            return loadingTime;

        }
    }
}
