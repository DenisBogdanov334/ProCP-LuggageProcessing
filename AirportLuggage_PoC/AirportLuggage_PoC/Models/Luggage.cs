using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class Luggage
    {
        public int OwnerId { get; set; }
        public int Weight { get; set; } = 20;

        public Luggage(int ownerId, int weight)
        {
            OwnerId = ownerId;
            Weight = weight;
        }
    }
}