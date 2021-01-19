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
            cbWagons.SelectedIndex = 0;           
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


        private void BtnDone_Click(object sender, EventArgs e)
        {
                int wagons = 0;
                int employees = 0;
                List<Plane> planes = new List<Plane>();
                DateTime start = new DateTime();
                try
                {
                    if (!string.IsNullOrEmpty(cbWagons.Text))
                    {
                        wagons = Convert.ToInt32(cbWagons.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter the number of wagons!");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wagons in wrong format! Please enter an integer!");
                    return;
                }
                try
                {
                    if (!string.IsNullOrEmpty(tbEmployees.Text))
                    {
                        employees = Convert.ToInt32(tbEmployees.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter the number of employees!");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Employees in wrong format! Please enter an integer!");
                    return;
                }

                TimeSpan ts = TimeSpan.Parse(dtPick.Text);
                start += ts;
                if (rbManual.Checked)
                {
                SimulationForm simF = new SimulationForm(filePath, wagons, employees, planes, start);
                simF.Show();
                }
                else if (rbAuto.Checked)
            {
                SimulationForm simF = new SimulationForm(filePath, 9999, 9999, planes, start);
                simF.Show();
            }
                
            
        }


        private void RbAuto_CheckedChanged(object sender, EventArgs e)
        {
                cbWagons.Enabled = false;
                tbEmployees.Enabled = false;           
        }

        private void RbManual_CheckedChanged(object sender, EventArgs e)
        {
            cbWagons.Enabled = true;
            tbEmployees.Enabled = true;
        }
    }
}
