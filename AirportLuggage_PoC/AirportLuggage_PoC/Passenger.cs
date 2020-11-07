using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Passenger
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string flightNo { get; set; }
        public int noOfLuggage { get; set; }

        public Passenger(int id, string fname, string lname, string flight, int amount)
        {
            this.id = id;
            this.firstName = fname;
            this.lastName = lname;
            this.flightNo = flight;
            this.noOfLuggage = amount;
        }

    }
}
