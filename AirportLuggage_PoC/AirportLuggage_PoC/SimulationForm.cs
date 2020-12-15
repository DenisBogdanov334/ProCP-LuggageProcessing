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
        private LuggageManagement lm;
        private List<PictureBox> pbs;
        private int currentLuggage;
        

        public SimulationForm()
        {
            InitializeComponent();
            lm = new LuggageManagement();
            pbs = new List<PictureBox>();
            DrawSimulation();
            UpdateLbUnloadedLuggages();
            btnPause.Enabled = false;
            pauzeToolStripMenuItem.Enabled = false;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Start();
            timerSetBelt.Start();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            startToolStripMenuItem.Enabled = !startToolStripMenuItem.Enabled;
            pauzeToolStripMenuItem.Enabled = !pauzeToolStripMenuItem.Enabled;
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
            StatisticsForm frm = new StatisticsForm(lm);
            frm.Show();
        }
       
        private void DrawSimulation()
        {
            //bind belts to grogressBar_belts
            var belts = lm.GetBelts();
            belts[0].startPos = new Point(progressBar1.Location.X, progressBar1.Location.Y - 30);
            belts[1].startPos = new Point(progressBar2.Location.X, progressBar2.Location.Y - 30);
            belts[2].startPos = new Point(progressBar3.Location.X, progressBar3.Location.Y - 30);

            //bind trainers to picturebox_trailers
            var trailers = lm.GetTrailers();
            trailers[0].position = new Point(progressBar4.Location.X, progressBar4.Location.Y -20);
            trailers[1].position = new Point(progressBar5.Location.X, progressBar5.Location.Y -20);
            trailers[2].position = new Point(progressBar6.Location.X, progressBar6.Location.Y -20);

            pbTrailerA.Location = trailers[0].position;
            pbTrailerB.Location = trailers[1].position;
            pbTrailerC.Location = trailers[2].position;

            pbTrailerA.Tag = trailers[0];
            pbTrailerB.Tag = trailers[1];
            pbTrailerC.Tag = trailers[2];
 

            //bind luggages to picturebox_luggages
            foreach (var luggage in lm.GetAllLuggages())
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

        private void ReDrawSimulation()
        {
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pb = (PictureBox)control;
                    if (pb.Tag != null)
                    {
                        if(pb.Tag is Luggage luggage)
                        {
                            pb.Location = luggage.position;
                            if (luggage.position.X > 0 && luggage.status != Status.LoadedInTrailer && luggage.status != Status.LoadedInAirplane)
                                pb.Visible = true;
                            // might be here
                            //create a statement that 
                            else if (luggage.status == Status.LoadedInTrailer)
                            {
                                pb.Visible = false;
                                lbStatus.Items.Add(pb.Tag);
                                this.Controls.Remove(pb);
                                this.pbs.Remove(pb);
                                if (lm.GetAllLoadedLuggages().Count == lm.GetAllLuggages().Count)
                                {
                                    this.lbDropoff.Items.Add("All luggages have been sent to belt!");
                                    this.lbStatus.Items.Add("All luggages have been transported to trailer!");
                                }

                                //update number of loaded luggages for each trailor
                                lm.AddLoadedLuggageToTrailer(luggage);
                                UpdateNrOfLoadedLuggages(luggage);
                            }
                        }
                       
                        else if(pb.Tag is Trailer trailer) // otherwise it is a trailer
                        {
                            pb.Location = trailer.position;

                            //check if trailer already arrived at departure zone: if yes, update information listbox
                            if (trailer.position.X >= pbZoneA.Location.X && trailer.IsTransporting)
                            {
                                trailer.IsTransporting = false;
                                this.lbLoadToFlight.Items.Add($"Trailer {trailer.Id} has arrived at the departure zone!");
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

        private void UpdateNrOfLoadedLuggages(Luggage luggage)
        {
            switch (luggage.Belt.Id)
            {
                case "beltA":
                    lbLoadedA.Text = "+" + lm.GetTrailers()[0].CurrentLoad.ToString();
                    return;
                case "beltB":
                    lbLoadedB.Text = "+" + lm.GetTrailers()[1].CurrentLoad;
                    return;
                case "beltC":
                    lbLoadedC.Text = "+" + lm.GetTrailers()[2].CurrentLoad;
                    return;
                default:
                    break;
            }
           
            
        }


        private void UpdateLbUnloadedLuggages()
        {
            lbDropoff.Items.Clear();
            foreach (var item in lm.GetAllUnLoadedLuggages())
            {
                lbDropoff.Items.Add(item);
            }
        }

        private void UpdateLbLoadedLuggaes()
        {
            lbStatus.Items.Clear();
            foreach (var item in lm.GetAllLoadedLuggages())
            {
                lbStatus.Items.Add(item);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            timerSetBelt.Stop();
            this.lm = new LuggageManagement();
            clearLuggage_pbs();
            clearNrLoadedLuggages_lbs();
            UpdateLbUnloadedLuggages();
            UpdateLbLoadedLuggaes();
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
            lm.MoveAllLuggage();
            lm.MoveTrailers(pbZoneA.Location.X);
            ReDrawSimulation();
        }

        private void timerSetBelt_Tick(object sender, EventArgs e)
        {
            if (currentLuggage < lm.GetAllLuggages().Count)
            {
                lm.SetBelt(lm.GetAllLuggages()[currentLuggage]);
                currentLuggage++;
                UpdateLbUnloadedLuggages();
            }
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
            this.lm = new LuggageManagement();
            clearLuggage_pbs();
            UpdateLbUnloadedLuggages();
            UpdateLbLoadedLuggaes();
            DrawSimulation();
            currentLuggage = 0;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            pauzeToolStripMenuItem.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public int getLuggageOnBeltA()
        {
            return lm.GetBelts()[0].CurrentLoad;
        }
    }
    
}

