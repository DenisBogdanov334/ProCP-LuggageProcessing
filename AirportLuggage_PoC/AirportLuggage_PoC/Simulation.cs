using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirportLuggage_PoC
{
    public class Simulation
    {

        public int NrAvailableEmployees { get; set; }
        public int NrAvailableWagons { get; set; }
        public DateTime startTime { get; set; }
        public int TotalEmp { get; set; }
        private List<Luggage> luggages;
        private List<Plane> planes;
        private List<Trailer> trailers;
        private List<Wagon> wagons;
        private List<AirportBelt> belts;
        private List<Employee> employees;
        readonly List<Zone> zones;
        public int TotalWagons { get; set; }
        public int MoreWaggons { get; set; }
        public int MoreEmployees { get; set; }
        


        public Simulation(string filePath, int nrWagons, int nrEmployees, List<Plane> plns, DateTime startT)
        {
            this.NrAvailableEmployees = nrEmployees;
            employees = new List<Employee>();
            for (int i = 0; i < nrEmployees; i++)
            {
                employees.Add(new Employee() { isAvailable = true }) ;
            }
            wagons = new List<Wagon>();
            for (int i = 0; i < nrWagons; i++)
            {
                wagons.Add(new Wagon() { Available = true, TimesUsed = 0 }) ;
            }
            this.NrAvailableWagons = nrWagons;
            this.TotalWagons = nrWagons;
            this.TotalEmp = nrEmployees;
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

        internal List<Employee> GetEmployees()
        {
            return this.employees;
        }
        public List<Plane> GetPlanes()
        {
            return planes;
        }
        internal void MoveTrailers(int maxRight)
        {
            foreach (var trailer in trailers)
            {
                if (trailer.IsTransporting)
                {
                    if (trailer.position.X < maxRight)
                    {
                        trailer.Transport();
                    }
                }
            }
        }

        internal List<Trailer> GetTrailers()
        {
            return this.trailers;
        }

        internal List<Wagon> GetWagons()
        {
            return this.wagons;
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
        public int GetNeedeEmp()
        {
            int total = 0;
            foreach (var p in planes)
            {
                total += p.NeededEmployees;
            }
            return total;
        }

        public int GetNeededWagons()
        {
            int total = 0;
            foreach (var p in planes)
            {
                total += p.NeededWagons;
            }
            return total;
        }
        public async void MoveAllLuggage()
        {
            foreach (var p in planes)
            {
                    foreach (var l in p.GetLuggages())
                    {                   
                    if (l.isMoving)
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
        }



        public async void MoveLuggagePerFlight(Plane pl)
        {
            foreach (var p in planes)
            {
                if (p == pl)
                {
                    foreach (var l in pl.GetLuggages())
                    {
                        if (pl.Belt != null)
                        {
                            await Task.Delay(1500);
                            l.Transport(pl.Belt);
                        }

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
                if (zone.Available == true)
                {
                    zone.Available = false;
                    plane.Zone = zone;
                    break;
                }
            }
        }
        public List<Zone> GetZones()
        {
            return this.zones;
        }

        public void AssignBelt(Plane plane)
        {
            foreach (AirportBelt band in belts)
            {
                
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
            foreach (var plane in planes)
            {
                if (p == plane)
                {
                    if (TimeSpan.Parse(p.GetTotalLoadingTime().ToString("HH:mm")) < (p.FlightTime.AddMinutes(-30) - p.FlightTime.AddMinutes(-120)))
                    {
                        p.NeededEmployees = 2;
                        
                        int count = 0;
                        bool contains = employees.Any(e => (e.TimesUsed >= 1) && e.isAvailable == true);
                        foreach (var em in employees)
                        {                           
                            if (contains==true)
                            {
                                if (count < 2 && em.isAvailable == true && em.TimesUsed >= 1)
                                {
                                    em.isAvailable = false;
                                    em.TimesUsed++;
                                    count++;
                                }
                                else if(count>=2 || em.isAvailable==false || em.TimesUsed < 1)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (count < 2 && em.isAvailable == true)
                                {
                                    em.isAvailable = false;
                                    em.TimesUsed++;
                                    count++;
                                }
                            }
                            
                        }
                    }
                    else { p.NeededEmployees = 3;
                        int count = 0;
                        bool contains = employees.Any(e => (e.TimesUsed >= 1) && e.isAvailable == true);
                        foreach (var em in employees)
                        {
                            if (contains == true)
                            {
                                if (count < 3 && em.isAvailable == true && em.TimesUsed >= 1)
                                {
                                    em.isAvailable = false;
                                    em.TimesUsed++;
                                    count++;
                                }
                                else if (count >= 3 || em.isAvailable == false || em.TimesUsed < 1)
                                {
                                    break;
                                }
                            }
                            else if (em.isAvailable == true && count < 3)
                            {
                                em.isAvailable = false;
                                em.TimesUsed++;
                                count++;
                            }
                            break;
                        }
                    }
                }
                }
            //foreach (Plane plane in planes)
            //{
            //    if (plane == p)
            //    {
            //        int index = planes.FindIndex(a => a.NrFlight == plane.NrFlight);
            //        var currentPlane = plane;
            //        var nextPlane = new Plane();
            //        if (index < planes.Count - 1)
            //        {
            //            nextPlane = planes[index + 1];
            //        }
            //        else
            //        {
            //            nextPlane = null;
            //        }
            //        DateTime startTime = plane.FlightTime.AddHours(-2);
            //        DateTime endTime = plane.FlightTime.AddMinutes(-15);                   
            //        if (nextPlane != null)
            //        {
            //            if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes >= currentPlane.NrOfLuggages * 2 + 5)
            //            {
            //                plane.NeededEmployees = 2;
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 2)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }                           
            //            }
            //            else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < currentPlane.NrOfLuggages * 2 + 5)
            //            {
            //                plane.NeededEmployees = 3;
                
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 3)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }
            //            }
            //            else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < (currentPlane.NrOfLuggages + 5))
            //            {
            //                plane.NeededEmployees = 4;
                            
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 4)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }
                            
            //            }
            //        }
            //        else
            //        {
            //            if ((endTime - startTime).Minutes > (currentPlane.NrOfLuggages + 5))
            //            {
            //                plane.NeededEmployees = 2;               
                            
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 3)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }                          
            //            }
            //            else if ((endTime - startTime).Minutes < (currentPlane.NrOfLuggages + 5))
            //            {
            //                plane.NeededEmployees = 3;
                            
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 3)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }
                           
            //            }
            //            else if ((endTime - startTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2))
            //            {
            //                plane.NeededEmployees = 4;
                           
            //                int count = 0;
            //                foreach (var e in employees)
            //                {
            //                    if (e.isAvailable == true && count < 4)
            //                    {
            //                        e.isAvailable = false;
            //                        e.isUsed = true;
            //                        count++;
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //        }
            //    }
        }

        public void AssignTrailer(Plane plane)
        {
            foreach (Trailer t in trailers)
            {
                if (t.Available == true)
                {
                    t.Available = false;
                    plane.Trailer = t;

                    break;
                }
            }
        }

        public void AssignWagons(Plane plane)
        {
            int wag = plane.NrOfLuggages / 50;
            switch (wag)
            {
                case 0:
                    plane.NeededWagons = 1;
                    int count = 0;
                    foreach (var w in wagons)
                    {
                        if (count < 1 && w.Available == true)
                        {
                            w.Available = false;
                            w.TimesUsed++;
                            count++;
                        }
                    }
                    break;
                case 1:
                    plane.NeededWagons = 2;
                    int count2 = 0;
                    foreach (var w in wagons)
                    {
                        if (count2 < 2 && w.Available == true)
                        {
                            w.Available = false;
                            w.TimesUsed++;
                            count2++;
                        }
                    }
                    break;
                case 2:
                    plane.NeededWagons = 3;
                    int count3 = 0;
                    foreach (var w in wagons)
                    {
                        if (count3 < 3 && w.Available == true)
                        {
                            w.Available = false;
                            w.TimesUsed++;
                            count3++;
                        }
                    }
                    break;
                case 3:
                    plane.NeededWagons = 4;
                    int count4 = 0;
                    foreach (var w in wagons)
                    {
                        if (count4 < 4 && w.Available == true)
                        {
                            w.Available = false;
                            w.TimesUsed++;
                            count4++;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        public void TransferToAirplane(Plane plane, string currentTime)
        {
            foreach (var p in planes)
            {
                if (p == plane)
                {
                    DateTime endTime = plane.FlightTime.AddMinutes(-30);
                    p.StartLoadingTime = currentTime;
                    DateTime endLoading = DateTime.Parse(p.StartLoadingTime).Add(TimeSpan.Parse(p.GetTotalLoadingTime().ToString("HH:mm")));
                    p.EndLoadingTime = endLoading.ToString("HH:mm");
                    DateTime loadedToWagons= DateTime.Parse(p.StartLoadingTime).Add(TimeSpan.Parse(p.GetLoadingTimeToWagon().ToString("HH:mm")));
                    p.LoadedToWagons = loadedToWagons.ToString("HH:mm");
                    if (endLoading < endTime)
                    {
                        p.OnTime = true;
                    }
                    else
                    {
                        p.Delay = DateTime.Parse(endLoading.Subtract(endTime).ToString());
                    }
                    foreach (var l in p.GetLuggages())
                    {
                        l.isMoving = true;
                    }
                }
            }
        }
        public void SetBelt(Luggage luggage)
        {
            if (luggage.Flight != null)
            {
                if (luggage.Flight.Zone.Id == "A")
                    luggage.Belt = belts[0];
                else if (luggage.Flight.Zone.Id == "B")
                    luggage.Belt = belts[1];
                else
                    luggage.Belt = belts[2];
            }
        }

    }
}
    

    

