﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public StatisticsForm(LuggageManagement lm)
        {
            InitializeComponent();
            lmc = lm;
            this.flights = lm.GetAllFlights();
            this.luggages = lm.GetAllLuggages();
            this.loadedL = lm.GetAllLoadedLuggages();
            this.unloadedL = lm.GetAllUnLoadedLuggages();



            //Hardcoded random data for statistics elements

            chart1.Series["Belt ocupancy"].Points.AddXY("Belt A", lm.totalLuggageBeltA);
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt B", lm.totalLuggageBeltB);
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt C", lm.totalLuggageBeltC);

            lblTotalLuggage.Text = "1329";
            lblLuggageLoaded.Text = "22.4";
            lblTotalLuggagewaiting.Text = "1.4";

            lbEmpName.Items.Add("John Michael");
            lbEmpName.Items.Add("Joe Jonas");
            lbEmpName.Items.Add("Mike Tyson");
            lbEmpName.Items.Add("Ashley Jones");

            lbEmpStation.Items.Add("Loading belt");
            lbEmpStation.Items.Add("Unloading belt");
            lbEmpStation.Items.Add("Loading plane");
            lbEmpStation.Items.Add("Check-in desk");

            lbEmpHoursWorked.Items.Add("7");
            lbEmpHoursWorked.Items.Add("6.5");
            lbEmpHoursWorked.Items.Add("9");
            lbEmpHoursWorked.Items.Add("9.5");

            lbHourlySalary.Items.Add("€ 8.4");
            lbHourlySalary.Items.Add("€ 8.7");
            lbHourlySalary.Items.Add("€ 10.3");
            lbHourlySalary.Items.Add("€ 13.0");

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
            lblLuggageLoaded.Text = l.Count().ToString();
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

    }


}
