using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportLuggage_PoC
{
    public partial class Form1 : Form
    {

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

            luggages.Add(l1);
            luggages.Add(l2);
            luggages.Add(l3);
            luggages.Add(l4);
            luggages.Add(l5);

            foreach (Luggage l in luggages)
            {
                listBox1.Items.Add(l.displayInfo());
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirportBelt beltA = new AirportBelt(150, 50, 75);

            for (int i = 0; i < listBox1.Items.Count; i++)   
            {

                if(beltA.AddLuggage(luggages[i].weight))
                {
                    lbStatus.Items.Add("Luggage" + luggages[i].id+ " moved to belt A");

                    beltA.currentLoad += luggages[i].weight;

                    listBox1.Items.RemoveAt(i);
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    progressBar1.MarqueeAnimationSpeed = 50;
                    
                    i++;
                }
                else
                {
                    lbStatus.Items.Add("Luggage is too heavy. Waiting for belt to clear");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statsForm.Show();
        }
    }
}
