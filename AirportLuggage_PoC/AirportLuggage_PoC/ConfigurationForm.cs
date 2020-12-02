using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.Win32;


namespace AirportLuggage_PoC
{
    public partial class ConfigurationForm : Form
    { 
        private string filePath = string.Empty;
    
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Please select a file!" + ex.Message+ex.HelpLink);
            }
        }

        private void ManualBox_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            int trailers=0;
            int wagons=0;
            int employees=0;
            try
            {
                if (tbTrailer != null)
                {
                    trailers = Convert.ToInt32(tbTrailer.Text);
                }
                else
                {
                    MessageBox.Show("Please enter the number of trailers!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Trailers in wrong format! Please enter an integer!");
                return;
            }
            try
            {
                if (tbWagons != null)
                {
                    wagons = Convert.ToInt32(tbWagons.Text);
                }
                else
                {
                    MessageBox.Show("Please enter the number of wagons!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wagons in wrong format! Please enter an integer!");
                return;
            }
            try
            {
                if (tbEmployees != null)
                {
                    employees = Convert.ToInt32(tbEmployees.Text);
                }
                else
                {
                    MessageBox.Show("Please enter the number of employees!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Employees in wrong format! Please enter an integer!");
                return;
            }


            SimulationForm simF = new SimulationForm(filePath, trailers, wagons, employees);
            simF.Show();
        }
    }
}
