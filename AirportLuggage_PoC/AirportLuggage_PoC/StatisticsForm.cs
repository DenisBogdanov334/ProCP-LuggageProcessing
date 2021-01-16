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
        public Simulation s;
        public List<Plane> planes;
        public int luggagesNo;
        public int hiredEmpNo;
        public int neededEmpNo;

        public StatisticsForm(Simulation sm)
        {
            InitializeComponent();
            s = sm;
            planes = sm.GetPlanes();
            luggagesNo = sm.GetAllLuggages();
            hiredEmpNo = sm.TotalEmp;
            neededEmpNo = sm.GetNeedeEmp();


            //Display info on screen
            timer1.Start();
            
        }

        public void DisplayEmpInfo()
        {
            lbEmpHired.Text = s.TotalEmp.ToString();
            lbEmpNeeded.Text = s.GetNeedeEmp().ToString();
            string result;
            if (s.TotalEmp - s.GetNeedeEmp() > 0)
            {
                result = "Fire " + (s.TotalEmp - s.GetNeedeEmp()) + " employees";
            }
            else if (s.TotalEmp - s.GetNeedeEmp() < 0)
            {
                result = "Hire " + (s.GetNeedeEmp() - s.TotalEmp) + " employees";
            }
            else result = "No actions needed";
            lbEmpSuggestion.Text = result;
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
                lbFlightsInfo.Items.Add(p.NrFlight + "                       " + p.NeededEmployees.ToString() + "                                 n/a");
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
        }
    }
}
