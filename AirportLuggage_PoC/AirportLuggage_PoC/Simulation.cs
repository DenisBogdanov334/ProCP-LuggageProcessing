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
        List<Plane> planes = new List<Plane>();
        List<AirportBelt> belts;
        List<Zone> zones;
        int nrAvailableEmployees;
        int nrAvailableTrailers;
        int nrAvailableWagons;
        bool wagonsNeeded;
        bool trailerNeeded;
        bool employeesNeeded;
        bool bandAvailable;
        bool zoneAvailable;
        int nrNeededEmployees;
        int nrNeededWagons;
        DateTime newBandAvailable;
        DateTime newEmployeeAvailable;
        DateTime newTrailerAvailable;
        DateTime newWagonAvailable;
        DateTime newZoneAvailable;

        public Simulation(string filePath,int nrTrailers, int nrWagons, int nrEmployees)
        {
            this.nrAvailableEmployees = nrEmployees;
            this.nrAvailableTrailers = nrTrailers;
            this.nrAvailableWagons = nrWagons;
            belts=new List<AirportBelt>(){new AirportBelt(){ Length = 150, Id ="A",Available=true},
                                                        new AirportBelt() { Length=170, Id="B",Available=true},
                                                        new AirportBelt() { Length=225,Id="C",Available = true} };
            zones= new List<Zone>() { new Zone() {Id="A"},
                                             new Zone() {Id="B"},
                                             new Zone() {Id="C"} };

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
        }
         

        public void FromCheckinToWagon()
        {
            foreach (var plane in planes)
            {
                int index = planes.FindIndex(a => a.NrFlight == plane.NrFlight);
                var currentPlane = plane;
                var nextPlane = planes[index+1];
                DateTime startTime = plane.FlightTime.AddHours(-2);
                DateTime endTime=plane.FlightTime.AddMinutes(-15);
                decimal totalTime = 0;
                foreach (var zone in zones)
                {
                    if (zone.Available == true)
                    {
                        zone.Available = false;
                        plane.Zone = zone;
                        break;
                    }
                    else if (zones.All(Zones => Zones.Available.Equals(false)))
                    {
                        zoneAvailable = false;
                        totalTime += Convert.ToDecimal((newZoneAvailable - startTime).Minutes);
                    }
                }
                foreach (var band in belts)
                {
                    if (band.Available == true)
                    {
                        band.Available = false;
                        plane.Belt = band;
                        break;
                    }
                    else if (belts.All(AirportBelt => AirportBelt.Available.Equals(false)))
                    {
                        bandAvailable = false;
                        totalTime += Convert.ToDecimal((newBandAvailable - startTime).Minutes);
                    }
                }
                if (nrAvailableEmployees > 0)
                {
                    if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes >= currentPlane.NrOfLuggages+5)
                    {
                        nrNeededEmployees = 1;
                       
                    }
                    else if((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < currentPlane.NrOfLuggages + 5)
                    {
                        nrNeededEmployees = 2;
                        if (nrNeededEmployees > nrAvailableEmployees)
                        {
                            employeesNeeded = true;
                        }
                    }
                    else if((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2)){
                        nrNeededEmployees = 3;
                        if (nrNeededEmployees > nrAvailableEmployees)
                        {
                            employeesNeeded = true;
                        }
                    }
                }
               

                    
                    
                }
                
                
                //int neededWagons = (plane.NrOfLuggages/50) + 1;
                

            }
        }
    }

