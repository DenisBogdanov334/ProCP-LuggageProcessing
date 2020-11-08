using System;
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
        public StatisticsForm()
        {
            InitializeComponent();

            //Hardcoded random data for statistics elements

            chart1.Series["Belt ocupancy"].Points.AddXY("Belt A", 70);
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt B", 20);
            chart1.Series["Belt ocupancy"].Points.AddXY("Belt C", 95);

            lblTotalLuggage.Text = "1329";
            lblLugWeight.Text = "22.4";
            lblAvgLugPerson.Text = "1.4";

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

            //Setting color of points in the chart

            foreach (Series s in chart1.Series)
            {
                foreach (DataPoint point in s.Points)
                {
                    if(point.YValues[0] <= 50)
                    {
                        point.Color = Color.Green;
                        point.BorderColor = Color.Black;
                    }
                    if (point.YValues[0] <= 70 && point.YValues[0] >50)
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
    }
}
