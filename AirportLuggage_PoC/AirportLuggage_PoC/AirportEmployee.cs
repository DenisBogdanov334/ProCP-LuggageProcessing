using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class AirportEmployee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }

        public AirportEmployee (string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
        }
    }
}
