using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Luggage
    {
        public double Weight { get; set; }
        public int TicketID { get; set; }


        public Luggage(double weight, int ticketID)
        {
            this.TicketID = ticketID;
            this.Weight = weight;
        }

        //public string displayInfo()
        //{
        //    string s;
        //    s = "Luggage no: " + this.id + ", Weight: " + weight + "kg";
        //    return s;
        //}
    }
}
