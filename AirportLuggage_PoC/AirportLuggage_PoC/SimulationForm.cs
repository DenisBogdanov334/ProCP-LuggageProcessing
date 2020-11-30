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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Start();
            timerSetBelt.Start();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
        }


        private void pauzeButton_Click(object sender, EventArgs e)
        {
            timerMoveLuggages.Stop();
            timerSetBelt.Stop();
            btnStart.Enabled = !btnStart.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm frm = new StatisticsForm(lm);
            frm.Show();
        }
       
        private void DrawSimulation()
        {
            var belts = lm.GetBelts();
            belts[0].startPos = new Point(progressBar1.Location.X, progressBar1.Location.Y + 10);
            belts[1].startPos = new Point(progressBar2.Location.X, progressBar2.Location.Y + 10);
            belts[2].startPos = new Point(progressBar3.Location.X, progressBar3.Location.Y + 10);

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
                        Luggage luggage = (Luggage)pb.Tag;
                        pb.Location = luggage.position;
                        if (luggage.position.X > 0 && luggage.status != Status.Loaded)
                            pb.Visible = true;
                        else if(luggage.status == Status.Loaded)
                        {
                            pb.Visible = false;
                            lbStatus.Items.Add(pb.Tag);
                            this.Controls.Remove(pb);
                            this.pbs.Remove(pb);
                            if(lm.GetAllLoadedLuggages().Count == lm.GetAllLuggages().Count)
                            {
                                this.lbStatus.Items.Add("____________________________________________________________");
                                this.lbStatus.Items.Add("All luggages have been transported to departure zone!");
                            }    
                        }                            
                    }
                }
            }
            this.Invalidate();
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
            UpdateLbUnloadedLuggages();
            UpdateLbLoadedLuggaes();
            DrawSimulation();
            currentLuggage = 0;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
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
    }
    
}

