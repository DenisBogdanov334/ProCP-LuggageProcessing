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
        #region Properties
        public int id { get; set; }
        public Point position;
        public Status status { get; set; }
        public AirportBelt Belt { get; set; }
        public Plane Flight { get; set; }
        public bool isMoving { get; set; }
        #endregion

        #region Methods
        public Luggage(int id)
        {
            this.id = id;
            this.status = Status.WaitingForLoading;
            this.position = new Point(0, 0);
        }

        public Luggage()
        {
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
                status = Status.LoadedInTrailer;
            }
        }

        internal void Transport()
        {
            if (position.X < Belt.startPos.X)
            {
                position = Belt.startPos;
                status = Status.InTransfer;
            }
            else if (position.X >= Belt.startPos.X && position.X < Belt.startPos.X + Belt.Length)
            {
                position.Offset(5, 0);
            }
            else
            {
                position.Offset(5, 0);
                status = Status.LoadedInTrailer;
            }
        }
        #endregion

    }
}


    public enum Status
{
    WaitingForLoading,
    InTransfer,
    LoadedInTrailer,
    LoadedInAirplane,
}

