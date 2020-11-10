using System;
using System.Collections.Generic;
using System.Text;

namespace DenisProCP
{
    public class AirportEmployee
    {
        private static int IdGenerator = 0;

        public AirportEmployee(string name)
        {
            EmployeeId = IdGenerator++;
            Name = name;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}