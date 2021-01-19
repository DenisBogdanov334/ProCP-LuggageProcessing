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
        #region Properties

        public string Id { get; set; }
        public int Length { get; set; }
        public int Speed { get; set; }
        public int CurrentLoad { get; set; }
        public int EmployeeId { get; set; }
        public bool Available { get; set; }
        public Point startPos;

        #endregion

        #region Constructors

        //Ling
        public AirportBelt(int length, double weight, int speed, string id)
        {
            this.Length = length;
            this.Speed = speed;
            this.CurrentLoad = 0;
            this.Id = id;
        }

        public AirportBelt(int lenght, int speed, string id)
        {
            this.Length = lenght;
            this.Available = true;
            this.Speed = speed;
            this.Id = id;
        }
        #endregion
    }
}
