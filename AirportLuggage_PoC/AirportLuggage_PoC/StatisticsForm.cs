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
        private LuggageManagement lmc;
        public List<UpcomingFlight> flights;
        public List<Luggage> luggages;
        public List<Luggage> loadedL;
        public List<Luggage> unloadedL;

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

            chart2.Series["luggageChart"].Points.AddXY("Loaded", lmc.GetLuggagesLoadedInAirplane().Count);
            chart2.Series["luggageChart"].Points.AddXY("Waiting", lmc.GetLuggagesWaitingForLoading().Count);
            chart2.Series["luggageChart"].Points.AddXY("In transport", lmc.GetAllLuggages().Count - lmc.GetLuggagesLoadedInAirplane().Count - lmc.GetLuggagesWaitingForLoading().Count);

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
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save statistics";
                    saveFileDialog.Filter = "Airport file|*.txt";
                    saveFileDialog.FileName = "myAirport";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        using (var streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.WriteLine("Flights info: " + DateTime.Now.ToString());
                            foreach (UpcomingFlight f in lmc.GetAllFlights())
                            {
                                streamWriter.WriteLine(f);
                            }
                            streamWriter.WriteLine("---------------------------------------------------------");
                            streamWriter.WriteLine("Luggage info: ");

                            foreach (Luggage l in lmc.GetAllLuggages())
                            {
                                streamWriter.WriteLine(l);
                            }
                            streamWriter.WriteLine("----------------------------------------------------------");
                            streamWriter.WriteLine("Total amount of luggage: " + lmc.GetAllLuggages().Count.ToString());
                            streamWriter.WriteLine("Luggages waiting for loading: " + lmc.GetLuggagesWaitingForLoading().Count.ToString());
                            streamWriter.WriteLine("Luggages loaded to belt: " + lmc.GetLuggagesLoadedOnBelt().Count.ToString());
                            streamWriter.WriteLine("Luggages loaded to trailers: " + lmc.GetLuggagesLoadedInTrailer().Count.ToString()); ;
                            streamWriter.WriteLine("Luggages loaded to airplanes: " + lmc.GetLuggagesLoadedInAirplane().Count.ToString());
                        }
                    }
                }
                MessageBox.Show("Data is saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            chart2.Series["luggageChart"].Points.Clear();
            chart2.Series["luggageChart"].Points.AddXY("Loaded", lmc.GetLuggagesLoadedInAirplane().Count);
            chart2.Series["luggageChart"].Points.AddXY("Waiting", lmc.GetLuggagesWaitingForLoading().Count);
            chart2.Series["luggageChart"].Points.AddXY("In transport", lmc.GetAllLuggages().Count - lmc.GetLuggagesLoadedInAirplane().Count - lmc.GetLuggagesWaitingForLoading().Count);

            lbTotalA.Text = lmc.GetBelts()[0].Loaded.ToString();
            lbTotalB.Text = lmc.GetBelts()[1].Loaded.ToString();
            lbTotalC.Text = lmc.GetBelts()[2].Loaded.ToString();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}
