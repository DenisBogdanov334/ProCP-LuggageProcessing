﻿using System;
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
        public Simulation s;
        public List<Plane> planes;
        public int luggagesNo;
        public int hiredEmpNo;
        public int neededEmpNo;
        public int neededWagons;

        public StatisticsForm(Simulation sm)
        {
            InitializeComponent();
            s = sm;
            planes = sm.GetPlanes();
            luggagesNo = sm.GetAllLuggages();
            hiredEmpNo = sm.TotalEmp;
            neededEmpNo = sm.GetNeedeEmp();
            neededWagons = sm.GetNeededWagons();

            //Display info on screen
            timer1.Start();
            
        }

        public void DisplayEmpInfo()
        {
            lbEmpHired.Text = s.TotalEmp.ToString();
            string result;
            int emp = s.GetNeedeEmp();
            foreach (var e in s.GetEmployees())
            {
                if (e.TimesUsed > 1)
                {
                    emp -= e.TimesUsed;
                    emp++;
                }
            }
            if (s.MoreEmployees > 0)
            {
                lbEmpNeeded.Text = (s.TotalEmp+s.MoreEmployees).ToString();
                result = s.MoreEmployees + " more employee(s) needed.";
            }
            else
            {
                lbEmpNeeded.Text = emp.ToString();
                if (s.TotalEmp > emp)
                {
                    result = (s.TotalEmp - emp) + " employee(s) too much.";
                }
                else if (s.TotalEmp < emp)
                {
                    result = (emp - s.TotalEmp) + " more employee(s) needed.";
                }
                else
                {
                    result = "No actions needed";
                }
            }
            if (s.GetPlanes().All(Planes => Planes.Departed.Equals(true)))
            {
                lbEmpSuggestion.Text = result;
            }
                               
        }

        public void DisplayWaggonsInfo()
        {
            lbAvailableWagons.Text = s.TotalWagons.ToString();
            string result;
            int wag = s.GetNeededWagons();
            foreach (var w in s.GetWagons())
            {
                if (w.TimesUsed > 1)
                {
                    wag -= w.TimesUsed;
                    wag++;
                }
            }
            if (s.MoreWaggons > 0)
            {
                lbNeededWagons.Text = (s.TotalWagons+s.MoreWaggons).ToString();
                result = s.MoreWaggons + " more waggon(s) needed.";
            }
            else
            {
                
                lbNeededWagons.Text = wag.ToString();
                if (s.TotalWagons > wag)
                {
                    
                    result = (s.TotalWagons - wag) + " waggon(s) too much.";
                }
                else
                {
                    result = "No actions needed";
                }
            }
            if (s.GetPlanes().All(Planes => Planes.Departed.Equals(true)))
            {
                lbSuggestionWagons.Text = result;
            }
        }
        public void DisplayLuggageInfo()
        {
            lbLuggageNo.Text = s.GetAllLuggages().ToString();
        }
        public void DisplayFlightInfo()
        {
            lbFlightsInfo.Items.Clear();
            foreach (Plane p in s.GetPlanes())
            {
                if (p.Delay != null)
                {
                    lbFlightsInfo.Items.Add(p.NrFlight + "                       " + p.NeededEmployees.ToString() + "                              "+ p.Delay.ToString("HH:mm"));
                }
                else
                {
                    lbFlightsInfo.Items.Add(p.NrFlight + "                       " + p.NeededEmployees.ToString() + "                                 n/a");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            DisplayEmpInfo();
            DisplayLuggageInfo();
            DisplayFlightInfo();
            DisplayWaggonsInfo();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
