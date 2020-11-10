using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class AirportBelt
    {
        public AirportBelt(int length, AirportEmployee employee)
        {
            Length = length;
            Employee = employee;
        }

        public int Length { get; set; }
        public AirportEmployee Employee { get; set; }
    }
}