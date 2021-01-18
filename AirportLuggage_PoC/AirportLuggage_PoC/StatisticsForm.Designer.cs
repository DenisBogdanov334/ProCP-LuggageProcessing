namespace AirportLuggage_PoC
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpNeeded = new System.Windows.Forms.Label();
            this.lbEmpSuggestion = new System.Windows.Forms.Label();
            this.lbEmpHired = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLuggageNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbFlightsInfo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAvailableWagons = new System.Windows.Forms.Label();
            this.lbNeededWagons = new System.Windows.Forms.Label();
            this.lbSuggestionWagons = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total employees hired:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total employees needed:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.groupBox1.Controls.Add(this.lbEmpNeeded);
            this.groupBox1.Controls.Add(this.lbEmpSuggestion);
            this.groupBox1.Controls.Add(this.lbEmpHired);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(449, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees info";
            // 
            // lbEmpNeeded
            // 
            this.lbEmpNeeded.AutoSize = true;
            this.lbEmpNeeded.Location = new System.Drawing.Point(193, 55);
            this.lbEmpNeeded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmpNeeded.Name = "lbEmpNeeded";
            this.lbEmpNeeded.Size = new System.Drawing.Size(28, 17);
            this.lbEmpNeeded.TabIndex = 5;
            this.lbEmpNeeded.Text = "n/a";
            // 
            // lbEmpSuggestion
            // 
            this.lbEmpSuggestion.AutoSize = true;
            this.lbEmpSuggestion.Location = new System.Drawing.Point(193, 84);
            this.lbEmpSuggestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmpSuggestion.Name = "lbEmpSuggestion";
            this.lbEmpSuggestion.Size = new System.Drawing.Size(28, 17);
            this.lbEmpSuggestion.TabIndex = 4;
            this.lbEmpSuggestion.Text = "n/a";
            // 
            // lbEmpHired
            // 
            this.lbEmpHired.AutoSize = true;
            this.lbEmpHired.Location = new System.Drawing.Point(193, 28);
            this.lbEmpHired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmpHired.Name = "lbEmpHired";
            this.lbEmpHired.Size = new System.Drawing.Size(28, 17);
            this.lbEmpHired.TabIndex = 3;
            this.lbEmpHired.Text = "n/a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee action suggestion:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orchid;
            this.groupBox2.Controls.Add(this.lbLuggageNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(473, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(348, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luggage info";
            // 
            // lbLuggageNo
            // 
            this.lbLuggageNo.AutoSize = true;
            this.lbLuggageNo.Location = new System.Drawing.Point(165, 25);
            this.lbLuggageNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLuggageNo.Name = "lbLuggageNo";
            this.lbLuggageNo.Size = new System.Drawing.Size(28, 17);
            this.lbLuggageNo.TabIndex = 1;
            this.lbLuggageNo.Text = "n/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total luggages";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.lbFlightsInfo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(473, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(348, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flight info";
            // 
            // lbFlightsInfo
            // 
            this.lbFlightsInfo.FormattingEnabled = true;
            this.lbFlightsInfo.ItemHeight = 16;
            this.lbFlightsInfo.Location = new System.Drawing.Point(13, 55);
            this.lbFlightsInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFlightsInfo.Name = "lbFlightsInfo";
            this.lbFlightsInfo.Size = new System.Drawing.Size(309, 116);
            this.lbFlightsInfo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Delay time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Needed employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flight number";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSuggestionWagons);
            this.groupBox4.Controls.Add(this.lbNeededWagons);
            this.groupBox4.Controls.Add(this.lbAvailableWagons);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(16, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 143);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wagons info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total available wagons:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total needed wagons:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Wagons action suggestion:";
            // 
            // lbAvailableWagons
            // 
            this.lbAvailableWagons.AutoSize = true;
            this.lbAvailableWagons.Location = new System.Drawing.Point(229, 28);
            this.lbAvailableWagons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAvailableWagons.Name = "lbAvailableWagons";
            this.lbAvailableWagons.Size = new System.Drawing.Size(28, 17);
            this.lbAvailableWagons.TabIndex = 9;
            this.lbAvailableWagons.Text = "n/a";
            // 
            // lbNeededWagons
            // 
            this.lbNeededWagons.AutoSize = true;
            this.lbNeededWagons.Location = new System.Drawing.Point(229, 58);
            this.lbNeededWagons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNeededWagons.Name = "lbNeededWagons";
            this.lbNeededWagons.Size = new System.Drawing.Size(28, 17);
            this.lbNeededWagons.TabIndex = 10;
            this.lbNeededWagons.Text = "n/a";
            // 
            // lbSuggestionWagons
            // 
            this.lbSuggestionWagons.AutoSize = true;
            this.lbSuggestionWagons.Location = new System.Drawing.Point(229, 92);
            this.lbSuggestionWagons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSuggestionWagons.Name = "lbSuggestionWagons";
            this.lbSuggestionWagons.Size = new System.Drawing.Size(28, 17);
            this.lbSuggestionWagons.TabIndex = 11;
            this.lbSuggestionWagons.Text = "n/a";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(832, 296);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLuggageNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbFlightsInfo;
        private System.Windows.Forms.Label lbEmpNeeded;
        private System.Windows.Forms.Label lbEmpSuggestion;
        private System.Windows.Forms.Label lbEmpHired;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSuggestionWagons;
        private System.Windows.Forms.Label lbNeededWagons;
        private System.Windows.Forms.Label lbAvailableWagons;
    }
}