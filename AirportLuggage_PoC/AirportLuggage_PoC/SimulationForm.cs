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
        private Simulation simulation;
        private System.Windows.Forms.Timer currentTimeTimer = null;
        private DateTime currentTime;
        bool flag = true;

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
            
            StartSim();
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
                while (p.FlightTime.AddHours(-2).ToString("HH:mm") != GetCurrentTime())
                {
                    if (flag)
                    {
                        flag = false;
                    }
                    await Task.Delay(1);
                }
                simulation.AssignZone(p);
                simulation.AssignBelt(p);
                simulation.AssignTrailer(p);
                simulation.AssignEmployees(p);
                lbDropoff.Items.Add($"Flight with number {p.NrFlight} will depart from zone {p.Zone.Id}");
                lbDropoff.Items.Add($"Luggages from band {p.Belt.Id}");
                lbDropoff.Items.Add($"Trailer with id {p.Trailer.Id}");
                lbDropoff.Items.Add($"Needed employees: {p.NeededEmployees}");
                timerMoveLuggages.Start();
                //timerSetBelt.Start();
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
                    
                    flag = false;
                }
                await Task.Delay(1);
            }
            p.Belt.Available = true;
            p.Trailer.IsTransporting = true;
            lbStatus.Items.Add($"All luggages from flight {p.NrFlight} have been loaded into trailer!");
            
        }
        private void pauzeButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            timerSetBelt.Stop();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm frm = new StatisticsForm(simulation);
            frm.Show();
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
                    luggage.Belt = plane.Belt;
                    luggage.Flight = plane;
                }
            }
        }

      
        private void ReDrawSimulation()
        {
            foreach (var control in this.Controls)
            {
                if (control is PictureBox pb)
                {
                    if (pb.Tag != null)
                    {
                        if (pb.Tag is Luggage luggage)
                        {
                            if (luggage.Belt != null)
                            {
                                if (GetCurrentTime() != luggage.Flight.EndLoadingTime)
                                {
                                    pb.Location = luggage.position;
                                    if (luggage.position.X > 0 && luggage.status != Status.LoadedInTrailer && luggage.status != Status.LoadedInAirplane)
                                        pb.Visible = true;
                                    else if (luggage.status == Status.LoadedInTrailer)
                                    {

                                        pb.Visible = false;
                                        luggage.position = luggage.Belt.startPos;
                                        luggage.status = Status.InTransfer;
                                    }
                                }
                                else
                                {
                                    pb.Visible = false;
                                    this.Controls.Remove(pb);
                                    this.pbs.Remove(pb);
                                }
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
            timerSetBelt.Stop();
            //this.lm = new LuggageManagement();
            clearLuggage_pbs();
            //clearNrLoadedLuggages_lbs();
            //UpdateLbUnloadedLuggages();
            //UpdateLbLoadedLuggaes();
            lbLoadToFlight.Items.Clear();
            DrawSimulation();
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
            //foreach (var p in simulation.GetPlanes())
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
            timerSetBelt.Start();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void pauzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            timerSetBelt.Stop();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            timerSetBelt.Stop();
            //this.lm = new LuggageManagement();
            clearLuggage_pbs();
            //UpdateLbUnloadedLuggages();
            //UpdateLbLoadedLuggaes();
            DrawSimulation();
            //currentLuggage = 0;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            pauzeToolStripMenuItem.Enabled = false;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
        

