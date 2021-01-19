using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DenisProCP
{
    public class AirportBelt
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public AirportEmployee Employee { get; set; }
        public int AmountOfProcessedLuggages { get; set; }

        public event EventHandler<string> OnProcessedLuggageEvent;
        public event EventHandler<Flight> OnReadyToLoad;

        public AirportBelt(string name, int length, AirportEmployee employee)
        {
            Name = name;
            Length = length;
            Employee = employee;
        }

        public async Task ProcessLuggage (Flight flight)
        {
            foreach (Luggage l in flight.Luggages)
            {
                await Task.Delay(1000);
                AmountOfProcessedLuggages++;

                OnProcessedLuggageEvent?.Invoke(this, $"Processed {AmountOfProcessedLuggages} out of {flight.Luggages.Count}");
            }
            OnProcessedLuggageEvent?.Invoke(this, $"Processed all {flight.Luggages.Count} luggages");
            OnReadyToLoad?.Invoke(this, flight);
        }
    }
}