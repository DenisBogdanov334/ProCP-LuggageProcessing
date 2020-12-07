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
        //Ling
        public int id { get; set; }
        //public int ownerId { get; set; }
        public Point position;
        public Status status { get; set; }

        public AirportBelt Belt { get; set; }

        //public UpcomingFlight Flight { get; set; }
        public Plane Flight { get; set; }



        //Ling
        //public Luggage(int id, double weight, double volume, int owner)
        //{
        //    this.id = id;
        //    this.ownerId = owner;
        //    this.status = Status.WaitingForLoading;
        //    this.position = new Point(0, 0);
        //}

        public Luggage(int id)
        {
            this.id = id;
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

        //public override string ToString()
        //{
        //    if (this.status == Status.WaitingForLoading)
        //        return $"Luggage: {id} - passenger: {ownerId} - flight: {Flight.FlightNo} departure from {Flight.Zone}";
        //    else if (this.status == Status.LoadedInTrailer)
        //        return $"Luggage: {id} - passenger: {ownerId} - flight: {Flight.FlightNo} loaded to trailer";
        //    else if (this.status == Status.LoadedInAirplane)
        //        return $"Luggage: {id} - passenger: {ownerId} - flight: {Flight.FlightNo} arrived at {Flight.Zone}";
        //    else
        //        return $"Luggage: {id} - passenger: {ownerId} - flight: {Flight.FlightNo} is on transport belt";
        //}

        //public override string ToString()
        //{
        //    if (this.status == Status.WaitingForLoading)
        //        return $"Luggage:   - flight: {Flight.NrFlight} departure from {Flight.Zone}";
        //    else if (this.status == Status.LoadedInTrailer)
        //        return $"Luggage:  - flight: {Flight.NrFlight} loaded to trailer";
        //    else if (this.status == Status.LoadedInAirplane)
        //        return $"Luggage:   - flight: {Flight.NrFlight} arrived at {Flight.Zone}";
        //    else
        //        return $"Luggage:  - flight: {Flight.NrFlight} is on transport belt";
        //}


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
    LoadedInTrailer,
    LoadedInAirplane,
}

