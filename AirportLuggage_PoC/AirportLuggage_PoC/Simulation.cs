using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirportLuggage_PoC
{
    class Simulation
    {

        public int NrAvailableEmployees { get; set; }
        public int NrAvailableTrailers { get; set; }
        public int NrAvailableWagons { get; set; }
        public DateTime startTime { get; set; }
        private List<Luggage> luggages;
        private List<Plane> planes;
        private List<Trailer> trailers;
        private List<AirportBelt> belts;
        readonly List<Zone> zones;
        public bool OnTime { get; set; }

        public Simulation(string filePath, int nrTrailers, int nrWagons, int nrEmployees, List<Plane> plns, DateTime startT)
        {
            this.NrAvailableEmployees = nrEmployees;
            this.NrAvailableTrailers = nrTrailers;
            this.NrAvailableWagons = nrWagons;
            this.startTime = startT;
            planes = new List<Plane>();
            this.planes = plns;
            luggages = new List<Luggage>();
            trailers = new List<Trailer>();
            belts = new List<AirportBelt>();
            zones = new List<Zone>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Plane newPlane = new Plane();
                newPlane.NrFlight = Convert.ToInt32(entries[0]);
                newPlane.NrOfLuggages = Convert.ToInt32(entries[1]);
                newPlane.FlightTime = Convert.ToDateTime(entries[2]);

                planes.Add(newPlane);
            }
            LoadData();
        }
        private void LoadData()
        {
            belts.Add(new AirportBelt(400, 50, 75, "A") { Available = true });
            belts.Add(new AirportBelt(450, 50, 75, "B") { Available = true });
            belts.Add(new AirportBelt(500, 50, 75, "C") { Available = true });

            foreach (var p in planes)
            {
                p.FillLuggageList();
            }

            zones.Add(new Zone() { Id = "A", Available = true });
            zones.Add(new Zone() { Id = "B", Available = true });
            zones.Add(new Zone() { Id = "C", Available = true });

            trailers.Add(new Trailer("T100A") { Available = true });
            trailers.Add(new Trailer("T100B") { Available = true });
            trailers.Add(new Trailer("T100C") { Available = true });

            trailers[0].Belt = belts[0];
            trailers[1].Belt = belts[1];
            trailers[2].Belt = belts[2];

        }

        public List<Plane> GetPlanes()
        {
            return planes;
        }
        internal void MoveTrailers(int maxRight)
        {
            foreach (var trailer in trailers)
            {
                if (trailer.IsTransporting && trailer.position.X < maxRight)
                {
                    trailer.Transport();
                }
            }
        }

        internal List<Trailer> GetTrailers()
        {
            return this.trailers;
        }


        public List<AirportBelt> GetBelts()
        {
            return this.belts;
        }

        public int GetAllLuggages()
        {
            int total = 0;
            foreach (var p in planes)
            {
                total += p.NrOfLuggages;
            }
            return total;
        }
        public async void MoveAllLuggage()
        {
            foreach (var p in planes)
            {
                foreach (var l in p.GetLuggages())
                {
                    l.Belt = p.Belt;
                    if (l.Belt != null)
                    {
                        await Task.Delay(1500);
                        l.Transport();
                    }
                }
            }
        }



        public void MoveLuggagePerFlight(int flightNo)
        {
            foreach (var p in planes)
            {
                if (p.NrFlight == flightNo)
                {
                    foreach (var l in p.GetLuggages())
                    {
                        if (p.Belt != null)
                            l.Transport(p.Belt);

                    }
                }
            }
        }


        private AirportBelt GetBelt(string bid)
        {
            foreach (var belt in belts)
            {
                if (belt.Id == bid)
                    return belt;
            }
            return null;
        }

        public void AssignZone(Plane plane)
        {
            foreach (Zone zone in zones)
            {
                bool flag = true;
                while (zones.All(Zones => Zones.Available.Equals(false)))
                {
                    if (flag)
                    {
                        flag = false;
                    }

                }
                if (zone.Available == true)
                {
                    zone.Available = false;
                    plane.Zone = zone;
                    break;
                }
            }
        }

        public void AssignBelt(Plane plane)
        {
            foreach (AirportBelt band in belts)
            {
                bool flag = true;
                while (belts.All(AirportBelt => AirportBelt.Available.Equals(false)))
                {
                    if (flag)
                    {
                        flag = false;
                    }
                }
                if (band.Available == true)
                {
                    band.Available = false;
                    plane.Belt = band;
                    break;
                }
            }
        }

        public void AssignEmployees(Plane p)
        {
            foreach (Plane plane in planes)
            {
                if (plane == p)
                {
                    int index = planes.FindIndex(a => a.NrFlight == plane.NrFlight);
                    var currentPlane = plane;
                    var nextPlane = new Plane();
                    if (index < planes.Count - 1)
                    {
                        nextPlane = planes[index + 1];
                    }
                    else
                    {
                        nextPlane = null;
                    }
                    DateTime startTime = plane.FlightTime.AddHours(-2);
                    DateTime endTime = plane.FlightTime.AddMinutes(-15);
                    DateTime startLoading = startTime;

                    bool flg = true;
                    while (NrAvailableEmployees == 0)
                    {
                        if (flg)
                        {
                            flg = false;
                        }
                    }
                    if (NrAvailableEmployees > 0)
                    {
                        if (nextPlane != null)
                        {
                            if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes >= currentPlane.NrOfLuggages + 5)
                            {
                                plane.NeededEmployees = 1;
                                NrAvailableEmployees--;

                            }
                            else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < currentPlane.NrOfLuggages + 5)
                            {
                                plane.NeededEmployees = 2;
                                bool flag = true;
                                while (NrAvailableEmployees < plane.NeededEmployees)
                                {
                                    if (flag)
                                    {
                                        flag = false;
                                    }
                                }

                                NrAvailableEmployees -= plane.NeededEmployees;
                            }
                            else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2))
                            {
                                plane.NeededEmployees = 3;
                                bool flag = true;
                                while (NrAvailableEmployees < plane.NeededEmployees)
                                {
                                    if (flag)
                                    {
                                        flag = false;
                                    }
                                }

                                NrAvailableEmployees -= plane.NeededEmployees;
                            }
                        }
                        else
                        {
                            if ((endTime - startTime).Minutes > (currentPlane.NrOfLuggages + 5))
                            {
                                plane.NeededEmployees = 1;
                                NrAvailableEmployees--;
                            }
                            else if ((endTime - startTime).Minutes < (currentPlane.NrOfLuggages + 5))
                            {
                                plane.NeededEmployees = 2;
                                bool flag = true;
                                while (NrAvailableEmployees < plane.NeededEmployees)
                                {
                                    if (flag)
                                    {

                                        flag = false;
                                    }
                                }

                                NrAvailableEmployees -= plane.NeededEmployees;
                            }
                            else if ((endTime - startTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2))
                            {
                                plane.NeededEmployees = 3;
                                bool flag = true;
                                while (NrAvailableEmployees < plane.NeededEmployees)
                                {
                                    if (flag)
                                    {

                                        flag = false;
                                    }
                                }

                                NrAvailableEmployees -= plane.NeededEmployees;
                            }
                        }
                    }
                }
            }
        }

        public void AssignTrailer(Plane plane)
        {
            foreach (Trailer t in trailers)
            {
                bool flag = true;
                while (trailers.All(Trailer => Trailer.Available.Equals(false)))
                {
                    if (flag)
                    {

                        flag = false;
                    }
                }
                if (t.Available == true)
                {
                    t.Available = false;
                    plane.Trailer = t;

                    break;
                }
            }
        }
        public void TransferToTrailer(Plane plane, string currentTime)
        {
            foreach (var p in planes)
            {
                if (p == plane)
                {
                    DateTime endTime = plane.FlightTime.AddMinutes(-15);
                    p.StartLoadingTime = currentTime;
                    DateTime endLoading = DateTime.Parse(p.StartLoadingTime).Add(TimeSpan.Parse(p.GetLoadingTimeToWagon().ToString("HH:mm")));
                    p.EndLoadingTime = endLoading.ToString("HH:mm");
                }
            }
        }

        //internal void AddLoadedLuggageToTrailer(Plane plane)
        //{
        //    foreach (var p in planes)
        //    {
        //        if (p == plane) { }
        //        foreach (var t in trailers)
        //        {
        //            if (p.Trailer == t)
        //            {
        //                t.CurrentLoad++;
        //                if (t.CurrentLoad == p.NrOfLuggages)
        //                {
        //                    t.IsTransporting = true;
        //                }
        //            }
        //        }
        //    }
        //    }

        //}
    }
}
    

    

