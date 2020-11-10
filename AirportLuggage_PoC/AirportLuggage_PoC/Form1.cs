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
    public partial class Form1 : Form
    {
        private LuggageManagement lm;
        Airport EindhovenAirport;

        public StatisticsForm statsForm = new StatisticsForm();

        public Luggage l1 = new Luggage(1, 22.4, 10.5, 1001);
        public Luggage l2 = new Luggage(2, 22.4, 10.5, 1002);
        public Luggage l3 = new Luggage(3, 22.4, 13.5, 1003);
        public Luggage l4 = new Luggage(4, 22.7, 10.5, 1004);
        public Luggage l5 = new Luggage(5, 25.4, 10.5, 1005);


        public List<Luggage> luggages = new List<Luggage>();


        public Form1()
        {
            InitializeComponent();

            #region Ling
            //luggages.Add(l1);
            //luggages.Add(l2);
            //luggages.Add(l3);
            //luggages.Add(l4);
            //luggages.Add(l5);

            //foreach (Luggage l in luggages)
            //{
            //    listBox1.Items.Add(l.displayInfo());
            //}

            lm = new LuggageManagement();
            #endregion

            EindhovenAirport = new Airport(Factory.FakeBelts(), Factory.FakeFlights(), Factory.FakeEmployees());
            foreach (Flight flight in EindhovenAirport.Flights)
            {
                listBox1.Items.Add($"{flight.FlightId} with {flight.Passengers.Count} passengers, leaving {flight.Departure} with load {flight.Luggages.Count}");
            }


            //DrawSimulation();
            //UpdateListBoxes();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            #region Ling
            //AirportBelt beltA = new AirportBelt(150, 50, 75);
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (beltA.AddLuggage(luggages[i].weight))
            //    {
            //        lbStatus.Items.Add("Luggage" + luggages[i].id + " moved to belt A");

            //        beltA.currentLoad += luggages[i].weight;

            //        listBox1.Items.RemoveAt(i);
            //        progressBar1.Style = ProgressBarStyle.Marquee;
            //        progressBar1.MarqueeAnimationSpeed = 50;

            //        i++;
            //    }
            //    else
            //    {
            //        lbStatus.Items.Add("Luggage is too heavy. Waiting for belt to clear");
            //    }
            //}
            #endregion
            timer1.Start();

            for (int i = 0; i < EindhovenAirport.Belts.Count; i++)
            {
                EindhovenAirport.Belts[i].OnProcessedLuggageEvent += Form1_OnProcessedLuggage;
                EindhovenAirport.Belts[i].OnReadyToLoad += Form1_OnReadyToLoad; ;
                await EindhovenAirport.Employees[i].PutOnBelt(EindhovenAirport.Belts[i], EindhovenAirport.Flights[i]);
            }

        }

        private void Form1_OnReadyToLoad(object sender, Flight e)
        {
            lbStatus.Items.Add($"{e.FlightId} which departs at {e.Departure} is ready to load");
            lbStatus.Refresh();
        }

        private void Form1_OnProcessedLuggage(object sender, string e)
        {
            var label = groupBox1.Controls.OfType<Label>().FirstOrDefault(x => x.Name == (sender as DenisProCP.AirportBelt).Name);
            label.Text = e;
            groupBox1.Refresh();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statsForm.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            //lm.MoveLuggagePerFlight("F100A");
            //ReDrawSimulation();
            //UpdateListBoxes();
        }

        #region Ling
        private void DrawSimulation()
        {
            var belts = lm.GetBelts();
            belts[0].startPos = new Point(progressBar1.Location.X, progressBar1.Location.Y + 10);
            belts[1].startPos = new Point(progressBar2.Location.X, progressBar2.Location.Y + 10);
            belts[2].startPos = new Point(progressBar3.Location.X, progressBar3.Location.Y + 10);

            foreach (var luggage in lm.GetAllLuggages("F100A"))
            {
                PictureBox pb = new PictureBox();
                pb.BackgroundImage = Resources.luggage;
                pb.Location = new Point(0, 0);
                pb.Size = new Size(30, 30);
                pb.Tag = luggage;
                this.Controls.Add(pb);
                if (luggage.position.X == 0)
                    pb.Visible = false;
            }
        }
        #endregion

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
                        else
                            pb.Visible = false;
                    }
                }
            }
            this.Invalidate();
        }

        private void UpdateListBoxes()
        {
            listBox1.Items.Clear();
            foreach (var item in lm.GetAllUnLoadedLuggages())
            {
                listBox1.Items.Add(item);
            }

            lbStatus.Items.Clear();
            foreach (var item in lm.GetAllLoadedLuggages())
            {
                lbStatus.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lm = new LuggageManagement();
            UpdateListBoxes();
            DrawSimulation();
        }
    }
}

