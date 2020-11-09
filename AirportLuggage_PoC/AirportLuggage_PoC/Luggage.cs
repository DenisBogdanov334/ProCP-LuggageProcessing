using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Luggage
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public double Weight { get; set; }
        public int TicketID { get; set; }

        public Point position;

        public Status status { get; set; }

        public Luggage(double weight, int ticketID)
        {
            this.TicketID = ticketID;
            this.Weight = weight;
        }

        public Luggage(int id, double weight, double volume, int owner)
        {
            this.id = id;
            this.ownerId = owner;
            this.status = Status.WaitingForLoading;
            this.position = new Point(0, 0);
        }

        internal void Transport(AirportBelt belt)
        {
            if (position.X < belt.startPos.X)
            {
                position = belt.startPos;
                status = Status.InTransfer;
            }
            else if (position.X >= belt.startPos.X && position.X < belt.startPos.X + belt.Length)
            {
                position.Offset(5, 0);
            }
            else
            {
                position.Offset(5, 0);
                status = Status.Loaded;
            }
        }

        internal bool IsReachingObstacles(List<Luggage> luggages)
        {
            int index = luggages.FindIndex(l => l.id == this.id);
            if (index > 0)
            {
                if (luggages[index - 1].position.X - luggages[index].position.X < 40)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Luggage {id} for passenger {ownerId}";
        }

        //public string displayInfo()
        //{
        //    string s;
        //    s = "Luggage no: " + this.id + ", Weight: " + weight + "kg";
        //    return s;
        //}

    }
}

public enum Status
{
    WaitingForLoading,
    InTransfer,
    Loaded,
}

