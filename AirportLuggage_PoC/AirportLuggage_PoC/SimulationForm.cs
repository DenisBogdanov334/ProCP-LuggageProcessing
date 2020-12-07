using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DenisProCP;
using System.Timers;
using System.Threading.Tasks;
using AirportLuggage_PoC.Properties;
using System.Drawing;

namespace AirportLuggage_PoC
{
    public partial class SimulationForm : Form
    {

        private List<PictureBox> pbs;
        private int currentLuggage;
        private Simulation simulation;
        private System.Windows.Forms.Timer currentTimeTimer = null;
        private DateTime currentTime;
       

        public SimulationForm(string filePath, int nrTrailers, int nrWagons, int nrEmployees,List<Plane> planes, DateTime start)
        {
            InitializeComponent();
            pbs = new List<PictureBox>();
            
            //UpdateLbUnloadedLuggages();
            btnPause.Enabled = false;
            pauzeToolStripMenuItem.Enabled = false;
            simulation = new Simulation(filePath, nrTrailers, nrWagons, nrEmployees, planes, start);
            currentTime = start;
            StartTimer();
            DrawSimulation();
        }

        private void StartTimer()
        {
            currentTimeTimer = new System.Windows.Forms.Timer();
            currentTimeTimer.Interval = 1000;
            currentTimeTimer.Tick += new EventHandler(currentTimeTimer_Tick);
            currentTimeTimer.Enabled = true;
            lbTime.Text = currentTime.ToString();
        }

        public void currentTimeTimer_Tick(object sender, EventArgs e)
        {

            currentTime = currentTime.AddMinutes(1);
            string time = currentTime.ToString("HH:mm");
            lbTime.Text = time;

        }
        public string GetCurrentTime()
        {
            string test = currentTime.ToString("HH:mm");
            return test;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //simulation.FromCheckinToWagon(GetCurrentTime());
            StartSim();
            //timerSetBelt.Start();
            //FromCheckinToWagon();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
            
        }

        private async void StartSim()
        {
            foreach (var p in simulation.GetPlanes())
            {
                bool flag = true;
                while (p.FlightTime.ToString("HH:mm") != GetCurrentTime())
                {
                    if (flag)
                    {
                        lbDropoff.Items.Add("Sunt in while");
                        flag = false;
                    }
                    await Task.Delay(1);
                }
                simulation.AssignZone(p);
                simulation.AssignBelt(p);
                simulation.AssignTrailer(p);
                simulation.AssignEmployees(p);
                lbDropoff.Items.Add($"Zone {p.Zone.Id} and band {p.Belt.Id} and trailer {p.Trailer.Id} and {p.NeededEmployees} employees");
                timerMoveLuggages.Start();
                simulation.TransferToTrailer(p,GetCurrentTime());
                FinishLoadingToTrailer(p);
            }
        }

        public async void FinishLoadingToTrailer(Plane p)
        {
            bool flag = true;
            while (p.EndLoadingTime != GetCurrentTime())
            {
                if (flag)
                {
                    lbDropoff.Items.Add("Astept sa se termine");
                    flag = false;
                }
                await Task.Delay(1);
            }
            lbLoadToFlight.Items.Add("S-a terminat");
            p.Belt.Available = true;
        }
        private void pauzeButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            //timerSetBelt.Stop();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            //StatisticsForm frm = new StatisticsForm(lm);
            //frm.Show();
        }

        private void DrawSimulation()
        {
            //bind belts to grogressBar_belts
            var bands = simulation.GetBelts();
            bands[0].startPos = new Point(progressBar1.Location.X, progressBar1.Location.Y - 30);
            bands[1].startPos = new Point(progressBar2.Location.X, progressBar2.Location.Y - 30);
            bands[2].startPos = new Point(progressBar3.Location.X, progressBar3.Location.Y - 30);

            //bind trainers to picturebox_trailers
            var trl = simulation.GetTrailers();
            trl[0].position = new Point(progressBar4.Location.X, progressBar4.Location.Y - 20);
            trl[1].position = new Point(progressBar5.Location.X, progressBar5.Location.Y - 20);
            trl[2].position = new Point(progressBar6.Location.X, progressBar6.Location.Y - 20);

            pbTrailerA.Location = trl[0].position;
            pbTrailerB.Location = trl[1].position;
            pbTrailerC.Location = trl[2].position;

            pbTrailerA.Tag = trl[0];
            pbTrailerB.Tag = trl[1];
            pbTrailerC.Tag = trl[2];


            //bind luggages to picturebox_luggages
            foreach (var plane in simulation.GetPlanes())
            {
                foreach (var luggage in plane.GetLuggages())
                {
                    PictureBox pb = new PictureBox();
                    pb.BackgroundImage = Resources.luggage;
                    pb.Location = new Point(0, 0);
                    pb.Size = new Size(30, 30);
                    pb.Tag = luggage;
                    this.pbs.Add(pb);
                    this.Controls.Add(pb);
                    if (luggage.position.X == 0)
                        pb.Visible = false;
                }
            }
        }

        private void ReDrawSimulation()
        {
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pb = (PictureBox)control;
                    if (pb.Tag != null)
                    {
                        if (pb.Tag is Luggage luggage)
                        {
                            pb.Location = luggage.position;
                            if (luggage.position.X > 0 && luggage.status != Status.LoadedInTrailer && luggage.status != Status.LoadedInAirplane)
                                pb.Visible = true;
                            else if (luggage.status == Status.LoadedInTrailer)
                            {
                                pb.Visible = false;
                                lbStatus.Items.Add(pb.Tag);
                                this.Controls.Remove(pb);
                                this.pbs.Remove(pb);
                                foreach (var p in simulation.GetPlanes())
                                {   
                                    if (GetCurrentTime()==p.FlightTime.AddHours(+1).ToString("HH:mm"))
                                    {
                                        this.lbDropoff.Items.Add("All luggages have been sent to belt!");
                                        this.lbStatus.Items.Add("All luggages have been transported to trailer!");
                                    }
                                }
                                //update number of loaded luggages for each trailor
                                //lm.AddLoadedLuggageToTrailer(luggage);
                                //UpdateNrOfLoadedLuggages(luggage);
                            }
                        }

                        else if (pb.Tag is Trailer trailer) // otherwise it is a trailer
                        {
                            pb.Location = trailer.position;

                            //check if trailer already arrived at departure zone: if yes, update information listbox
                            if (trailer.position.X >= pbZoneA.Location.X && trailer.IsTransporting)
                            {
                                trailer.IsTransporting = false;
                                this.lbLoadToFlight.Items.Add($"Trailer {trailer.Id} has arrived at departure zone!");
                                foreach (var l in trailer.luggages)
                                {
                                    if (l.status != Status.LoadedInAirplane)
                                    {
                                        l.status = Status.LoadedInAirplane;
                                        this.lbStatus.Items.Remove(l);
                                        this.lbLoadToFlight.Items.Add(l);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            this.Invalidate();
        }

        //private void UpdateNrOfLoadedLuggages(Luggage luggage)
        //{
        //    switch (luggage.Belt.Id)
        //    {
        //        case "beltA":
        //            lbLoadedA.Text = "+" + lm.GetTrailers()[0].CurrentLoad.ToString();
        //            return;
        //        case "beltB":
        //            lbLoadedB.Text = "+" + lm.GetTrailers()[1].CurrentLoad;
        //            return;
        //        case "beltC":
        //            lbLoadedC.Text = "+" + lm.GetTrailers()[2].CurrentLoad;
        //            return;
        //        default:
        //            break;
        //    }
        //}


        //private void UpdateLbUnloadedLuggages()
        //{
        //    lbDropoff.Items.Clear();
        //    foreach (var item in lm.GetAllUnLoadedLuggages())
        //    {
        //        lbDropoff.Items.Add(item);
        //    }
        //}

        //private void UpdateLbLoadedLuggaes()
        //{
        //    lbStatus.Items.Clear();
        //    foreach (var item in lm.GetAllLoadedLuggages())
        //    {
        //        lbStatus.Items.Add(item);
        //    }
        //}

        private void resetButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            //timerSetBelt.Stop();
            //this.lm = new LuggageManagement();
            clearLuggage_pbs();
            //clearNrLoadedLuggages_lbs();
            //UpdateLbUnloadedLuggages();
            //UpdateLbLoadedLuggaes();
            lbLoadToFlight.Items.Clear();
            DrawSimulation();
            currentLuggage = 0;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            pauzeToolStripMenuItem.Enabled = false;
        }

        private void clearNrLoadedLuggages_lbs()
        {
            lbLoadedA.Text = "+0";
            lbLoadedB.Text = "+0";
            lbLoadedC.Text = "+0";
        }

        private void clearLuggage_pbs()
        {
            foreach (var pb in this.pbs)
            {
                this.Controls.Remove(pb);
            }
            pbs.Clear();
            this.Invalidate();
        }

        private void timerMoveLuggages_Tick(object sender, EventArgs e)
        {

            simulation.MoveAllLuggage();
            simulation.MoveTrailers(pbZoneA.Location.X);
            ReDrawSimulation();
        }

        private void timerSetBelt_Tick(object sender, EventArgs e)
        {
            //foreach (var p in planes)
            //{
            //    if (currentLuggage < p.GetLuggages().Count)
            //    {
            //        simulation.SetBelt(p.GetLuggages()[currentLuggage]);
            //        currentLuggage++;
            //    }
            //}
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Start();
            //timerSetBelt.Start();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void pauzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            //timerSetBelt.Stop();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            //timerSetBelt.Stop();
            //this.lm = new LuggageManagement();
            clearLuggage_pbs();
            //UpdateLbUnloadedLuggages();
            //UpdateLbLoadedLuggaes();
            DrawSimulation();
            currentLuggage = 0;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            pauzeToolStripMenuItem.Enabled = false;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {

        }
        //public async void FromCheckinToWagon()
        //{

        //    foreach (Plane plane in planes)
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
        //        DateTime startLoading = startTime;

        //        while (startTime.ToString("HH:mm") != GetCurrentTime())
        //        {
        //            await Task.Delay(1);
        //        }
        //        foreach (Zone zone in zones)
        //        {
        //            bool flag = true;
        //            while (zones.All(Zones => Zones.Available.Equals(false)))
        //            {
        //                if (flag)
        //                {
        //                    lbLoadToFlight.Items.Add($"Zones not available!");
        //                    flag = false;
        //                }

        //            }
        //            if (zone.Available == true)
        //            {
        //                zone.Available = false;
        //                plane.Zone = zone;
        //                string zn = $"Airplane {plane.NrFlight} arrived at zone {zone.Id}";
        //                lbLoadToFlight.Items.Add(zn);
        //                break;
        //            }
        //        }

        //        foreach (AirportBelt band in belts)
        //        {
        //            bool flag = true;
        //            while (belts.All(AirportBelt => AirportBelt.Available.Equals(false)))
        //            {
        //                if (flag)
        //                {
        //                    lbLoadToFlight.Items.Add($"Belt not available!");
        //                    flag = false;
        //                }
        //            }
        //            if (band.Available == true)
        //            {
        //                band.Available = false;
        //                plane.Belt = band;
        //                string bt = $"Airplane {plane.NrFlight} got belt {band.Id}";
        //                lbLoadToFlight.Items.Add(bt);
        //                break;
        //            }
        //        }
        //        bool flg = true;
        //        while (simulation.NrAvailableEmployees == 0)
        //        {
        //            if (flg)
        //            {
        //                lbLoadToFlight.Items.Add($"No employees available!");
        //                flg = false;
        //            }
        //        }
        //        if (simulation.NrAvailableEmployees > 0)
        //        {
        //            if (nextPlane != null)
        //            {
        //                if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes >= currentPlane.NrOfLuggages + 5)
        //                {
        //                    plane.NeededEmployees = 1;
        //                    simulation.NrAvailableEmployees--;
        //                    lbLoadToFlight.Items.Add($"1 employee distributed to flight {plane.NrFlight}");

        //                }
        //                else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < currentPlane.NrOfLuggages + 5)
        //                {
        //                    plane.NeededEmployees = 2;
        //                    bool flag = true;
        //                    while (simulation.NrAvailableEmployees < plane.NeededEmployees)
        //                    {
        //                        if (flag)
        //                        {
        //                            lbLoadToFlight.Items.Add($"{plane.NeededEmployees - simulation.NrAvailableEmployees} more employee(s) needed for flight {plane.NrFlight}");
        //                            flag = false;
        //                        }
        //                    }
                            
        //                    lbLoadToFlight.Items.Add($"2 employees distributed to flight {plane.NrFlight}");
        //                    simulation.NrAvailableEmployees -= plane.NeededEmployees;
        //                }
        //                else if ((nextPlane.FlightTime - currentPlane.FlightTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2))
        //                {
        //                    plane.NeededEmployees = 3;
        //                    bool flag = true;
        //                    while (simulation.NrAvailableEmployees < plane.NeededEmployees)
        //                    {
        //                        if (flag)
        //                        {
        //                            lbLoadToFlight.Items.Add($"{plane.NeededEmployees - simulation.NrAvailableEmployees} more employee(s) needed for flight {plane.NrFlight}");
        //                            flag = false;
        //                        }
        //                    }
        //                    lbLoadToFlight.Items.Add($"3 employees distributed to flight {plane.NrFlight}");
        //                    simulation.NrAvailableEmployees -= plane.NeededEmployees;
        //                }
        //            }
        //            else
        //            {
        //                if((endTime-startTime).Minutes > (currentPlane.NrOfLuggages + 5)){
        //                    plane.NeededEmployees = 1;
        //                    simulation.NrAvailableEmployees--;
        //                    lbLoadToFlight.Items.Add($"1 employee distributed to flight {plane.NrFlight}");
        //                }
        //                else if ((endTime - startTime).Minutes < (currentPlane.NrOfLuggages + 5))
        //                {
        //                    plane.NeededEmployees = 2;
        //                    bool flag = true;
        //                    while (simulation.NrAvailableEmployees < plane.NeededEmployees)
        //                    {
        //                        if (flag)
        //                        {
        //                            lbLoadToFlight.Items.Add($"{plane.NeededEmployees - simulation.NrAvailableEmployees} more employee(s) needed for flight {plane.NrFlight}");
        //                            flag = false;
        //                        }
        //                    }

        //                    lbLoadToFlight.Items.Add($"2 employees distributed to flight {plane.NrFlight}");
        //                    simulation.NrAvailableEmployees -= plane.NeededEmployees;
        //                }
        //                else if ((endTime - startTime).Minutes < ((currentPlane.NrOfLuggages + 5) / 2))
        //                {
        //                    plane.NeededEmployees = 3;
        //                    bool flag = true;
        //                    while (simulation.NrAvailableEmployees < plane.NeededEmployees)
        //                    {
        //                        if (flag)
        //                        {
        //                            lbLoadToFlight.Items.Add($"{plane.NeededEmployees - simulation.NrAvailableEmployees} more employee(s) needed for flight {plane.NrFlight}");
        //                            flag = false;
        //                        }
        //                    }
        //                    lbLoadToFlight.Items.Add($"3 employees distributed to flight {plane.NrFlight}");
        //                    simulation.NrAvailableEmployees -= plane.NeededEmployees;
        //                }
        //            }
        //        }
        //        foreach (Trailer t in trailers)
        //        {
        //            bool flag = true;
        //            while (trailers.All(Trailer => Trailer.Available.Equals(false)))
        //            {
        //                if (flag)
        //                {
        //                    lbLoadToFlight.Items.Add($"Trailers not available!");
        //                    flag = false;
        //                }
        //            }
        //            if (t.Available == true)
        //            {
        //                t.Available = false;
        //                plane.Trailer=t;
        //                string bt = $"Trailer {t.Id} got assigned to flight {plane.NrFlight}";
        //                lbLoadToFlight.Items.Add(bt);
        //                break;
        //            }
        //        }
        //        TimeSpan s= TimeSpan.Parse(GetCurrentTime()) - TimeSpan.Parse(startTime.ToString("HH:mm"));
        //        startLoading = startLoading.Add(s);
        //        plane.StartLoadingTime = startLoading;

        //    }
            
        //}

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
        

