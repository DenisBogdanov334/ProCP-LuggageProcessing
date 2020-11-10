using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DenisProCP
{
    public class AirportEmployee
    {
        private static int IdGenerator = 0;
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public AirportEmployee(string name)
        {
            EmployeeId = IdGenerator++;
            Name = name;
        }

        public async Task PutOnBelt (AirportBelt belt, Flight flight)
        {
             await belt.ProcessLuggage(flight);
        }
    }
}