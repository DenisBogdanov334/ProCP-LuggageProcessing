using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class AirportBelt
    {
        public string Id { get; private set; }
        public int Length { get; set; }
        // public double supportedWeight { get; set; } this is not a problem since customer told us there is no limit.
        public int Speed { get; set; }
        public int CurrentLoad { get; set; }
        public int EmployeeId { get; set; }

        //Ling
        public Point startPos;

        //Ling
        public AirportBelt(int length, double weight, int speed, string id)
        {
            this.Length = length;
            this.Speed = speed;
            this.CurrentLoad = 0;
            this.Id = id;
        }

        //public bool AddLuggage(double luggageWeight)
        //{
        //    if (currentLoad + luggageWeight <= supportedWeight)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
    }
}
