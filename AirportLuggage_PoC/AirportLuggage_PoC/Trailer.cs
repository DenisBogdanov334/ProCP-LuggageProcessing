using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Trailer
    {
        public Point position;
        public string Id { get; set; }
        public int Capacity { get; set; }
        public int CurrentLoad { get; set; }
        public AirportBelt Belt { get; set; }
        public bool Available { get; set; }

        public List<Luggage> luggages { get; set; }

        public bool IsTransporting { get; set; }

        public Trailer(string id)
        {
            this.Id = id;
            this.CurrentLoad = 0;
            this.luggages = new List<Luggage>();
        }

        internal void Transport()
        {
            position.Offset(5, 0);
        }
    }
}
