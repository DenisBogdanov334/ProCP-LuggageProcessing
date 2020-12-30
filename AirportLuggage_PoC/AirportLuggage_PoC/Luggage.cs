using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLuggage_PoC
{
    public class Luggage: IComparable<Luggage>
    {
        //Ling
        public int id { get; set; }
        public int ownerId { get; set; }

        public int weight { get; set; }

        public Point position;
        public Status status { get; set; }

        public AirportBelt Belt { get; set; }

        public UpcomingFlight Flight { get; set; }

        public static int startId = 2001;

        //Ling
        public Luggage(int id, double weight, double volume, int owner)
        {
            this.id = id;
            this.ownerId = owner;
            this.status = Status.WaitingForLoading;
            this.position = new Point(0, 0);
        }

        public Luggage(double weight, UpcomingFlight flight)
        {
            this.id = startId;
            this.status = Status.WaitingForLoading;
            this.position = new Point(0, 0);
            this.Flight = flight;
            startId++;
        }

        internal void Transport(AirportBelt belt)
        {
            if (position.X < belt.startPos.X)
            {
                position = belt.startPos;
                status = Status.LoadedOnBelt;
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
            if (status != Status.LoadedInAirplane)
            {
                if (position.X < Belt.startPos.X)
                {
                    position = Belt.startPos;
                    status = Status.LoadedOnBelt;
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
            if (this.status == Status.WaitingForLoading)
                return $"Luggage: {id} - flight: {Flight.FlightNo} departure from {Flight.Zone}";
            else if (this.status == Status.LoadedInTrailer)
                return $"Luggage: {id} - flight: {Flight.FlightNo} loaded to trailer";
            else if (this.status == Status.LoadedInAirplane)
                return $"Luggage: {id} - flight: {Flight.FlightNo} arrived at {Flight.Zone}";
            else
                return $"Luggage: {id} - flight: {Flight.FlightNo} is on transport belt";
        }

        public string GetInfo()
        {
            string s;
            s = "Luggage no: " + this.id;
            return s;
        }

        public int CompareTo(Luggage other)
        {
            if (other == null)
                return 1;

            else
                return this.weight.CompareTo(other.weight);
        }
    }
}


    public enum Status
{
    WaitingForLoading,
    LoadedOnBelt,
    LoadedInTrailer,
    LoadedInAirplane,
}

