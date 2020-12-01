using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    class Trailer
    {
        public Point position;
        public string Id { get; private set; }
        public int Capacity { get; set; }
        public int CurrentLoad { get; set; }
        public AirportBelt Belt { get; set; }

        public List<Luggage> luggages { get; set; }

        public bool IsTransporting { get; set; }

        public Trailer(string id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.CurrentLoad = 0;
            this.luggages = new List<Luggage>();
        }

        internal void Transport()
        {
            position.Offset(5, 0);
        }
    }
}
