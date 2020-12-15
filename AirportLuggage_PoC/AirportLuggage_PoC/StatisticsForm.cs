using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AirportLuggage_PoC
{
    public partial class StatisticsForm : Form
    {
        public LuggageManagement lmc;
        public List<UpcomingFlight> flights;
        public List<Luggage> luggages;
        public List<Luggage> loadedL;
        public List<Luggage> unloadedL;

        FileStream fs;
        StreamWriter sw; 
        public StatisticsForm(LuggageManagement lm)
        {
            InitializeComponent();
            lmc = lm;
            this.flights = lm.GetAllFlights();
            this.luggages = lm.GetAllLuggages();
            this.loadedL = lm.GetLuggagesLoadedInTrailer();
            this.unloadedL = lm.GetLuggagesWaitingForLoading();



            //Hardcoded random data for statistics elements


            chart1.Series["Belt ocupancy"].Points.AddXY("Belt B", lm.totalLuggageBeltB);
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt C", lm.totalLuggageBeltC);

            chart2.Series["luggageChart"].Points.AddXY("Loaded", loadedL.Count());
            chart2.Series["luggageChart"].Points.AddXY("Waiting", luggages.Count()-loadedL.Count());

            lblTotalLuggage.Text = luggages.Count.ToString();
            lblTotalLuggagewaiting.Text = (luggages.Count - loadedL.Count - unloadedL.Count).ToString();
            lblLuggageOnbelt.Text = loadedL.Count.ToString();

            lbEmpName.Items.Add("John Michael");
            lbEmpName.Items.Add("Joe Jonas");
            lbEmpName.Items.Add("Mike Tyson");
            lbEmpName.Items.Add("Ashley Jones");

            lbEmpStation.Items.Add("Loading belt");
            lbEmpStation.Items.Add("Unloading belt");
            lbEmpStation.Items.Add("Loading plane");
            lbEmpStation.Items.Add("Check-in desk");

            
            DisplayFlightInfo(flights);
            DisplayAllLuggage(luggages);
            DisplayLoadedLuggage(loadedL);
            DisplayUnloadedLuggage(unloadedL);

            //Setting color of points in the chart

            foreach (Series s in chart1.Series)
            {
                foreach (DataPoint point in s.Points)
                {
                    if (point.YValues[0] <= 50)
                    {
                        point.Color = Color.Green;
                        point.BorderColor = Color.Black;
                    }
                    if (point.YValues[0] <= 70 && point.YValues[0] > 50)
                    {
                        point.Color = Color.Yellow;
                        point.BorderColor = Color.Black;
                    }
                    if (point.YValues[0] <= 90 && point.YValues[0] > 70)
                    {
                        point.Color = Color.Orange;
                        point.BorderColor = Color.Black;
                    }
                    if (point.YValues[0] > 90)
                    {
                        point.Color = Color.Red;
                        point.BorderColor = Color.Black;
                    }
                }
            }

            timer1.Start();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void DisplayFlightInfo(List<UpcomingFlight> fl)
        {
            foreach (UpcomingFlight f in fl)
            {
                lbFlightinfo.Items.Add(f.FlightNo + "                " + f.Zone);
            }
        }

        public void DisplayAllLuggage(List<Luggage> l)
        {
            lblTotalLuggage.Text = l.Count().ToString();
        }

        public void DisplayLoadedLuggage(List<Luggage> l)
        {
            lblLuggageOnbelt.Text = l.Count().ToString();
        }
        public void DisplayUnloadedLuggage(List<Luggage> l)
        {
            lblTotalLuggagewaiting.Text = l.Count().ToString();
        }

        public void updateAll(List<Luggage> l, List<UpcomingFlight> fl)
        {
            DisplayFlightInfo(fl);
            DisplayAllLuggage(l);
            DisplayLoadedLuggage(l);
            DisplayUnloadedLuggage(l);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
            string title = "Airport Data Report " + string.Format("{0:yyyy-MM-dd HH-mm-ss}", DateTime.Now); // adds the date to the path
            try
            {
                fs = new FileStream(title,
                   FileMode.OpenOrCreate,
                   FileAccess.Write);
                sw = new StreamWriter(fs);
            }

            catch (IOException)
            {
                MessageBox.Show("There was an error while opening the file");
            }

            try
            {
                sw.WriteLine("Flights info: ");
                foreach (UpcomingFlight f in flights)
                {
                    sw.WriteLine(f.GetInfo());
                }
                sw.WriteLine("--------------");
                sw.WriteLine("Luggage info: ");

                foreach (Luggage l in luggages)
                {
                    sw.WriteLine(l.GetInfo());
                }
                sw.WriteLine("--------------");
                sw.WriteLine("Total amount of luggage: " + luggages.Count.ToString());
                sw.WriteLine("Loaded luggage: " + loadedL.Count.ToString());
                sw.WriteLine("Unloaded luggage: " + luggages.Count.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show("File has already been saved");
            }

            try
            {
                if (sw != null)
                    sw.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error closing file");
            }

        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        public int currA;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.updateAll(luggages, flights);
            //SimulationForm sim = new SimulationForm();
            //currA = sim.getLuggageOnBeltA();
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt A", currA);
            UpdateLuggagesStatus();
        }

        private void UpdateLuggagesStatus()
        {
            lblTotalLuggagewaiting.Text = lmc.GetLuggagesWaitingForLoading().Count.ToString();
            lblLuggageOnbelt.Text = lmc.GetLuggagesLoadedOnBelt().Count.ToString();
            lblLuggageInTrailer.Text = lmc.GetLuggagesLoadedInTrailer().Count.ToString();
            lblLuggageInPlane.Text = lmc.GetLuggagesLoadedInAirplane().Count.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}
