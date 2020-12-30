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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbFlightinfo = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.ListBox();
            this.lblLuggageOnbelt = new System.Windows.Forms.Label();
            this.lblTotalLuggagewaiting = new System.Windows.Forms.Label();
            this.lblTotalLuggage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpStation = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLuggageInPlane = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblLuggageInTrailer = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTotalA = new System.Windows.Forms.Label();
            this.lbTotalB = new System.Windows.Forms.Label();
            this.lbTotalC = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFlightinfo
            // 
            this.lbFlightinfo.FormattingEnabled = true;
            this.lbFlightinfo.ItemHeight = 16;
            this.lbFlightinfo.Location = new System.Drawing.Point(8, 39);
            this.lbFlightinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFlightinfo.Name = "lbFlightinfo";
            this.lbFlightinfo.Size = new System.Drawing.Size(255, 84);
            this.lbFlightinfo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Flight No.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lbFlightinfo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(600, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(272, 172);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flight information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Assigned belt";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 466);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(857, 66);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Emoloyee name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Working at station";
            // 
            // lbEmpName
            // 
            this.lbEmpName.FormattingEnabled = true;
            this.lbEmpName.ItemHeight = 16;
            this.lbEmpName.Location = new System.Drawing.Point(7, 55);
            this.lbEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(143, 180);
            this.lbEmpName.TabIndex = 14;
            // 
            // lblLuggageOnbelt
            // 
            this.lblLuggageOnbelt.AutoSize = true;
            this.lblLuggageOnbelt.Location = new System.Drawing.Point(163, 89);
            this.lblLuggageOnbelt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuggageOnbelt.Name = "lblLuggageOnbelt";
            this.lblLuggageOnbelt.Size = new System.Drawing.Size(46, 17);
            this.lblLuggageOnbelt.TabIndex = 5;
            this.lblLuggageOnbelt.Text = "label6";
            // 
            // lblTotalLuggagewaiting
            // 
            this.lblTotalLuggagewaiting.AutoSize = true;
            this.lblTotalLuggagewaiting.Location = new System.Drawing.Point(163, 62);
            this.lblTotalLuggagewaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLuggagewaiting.Name = "lblTotalLuggagewaiting";
            this.lblTotalLuggagewaiting.Size = new System.Drawing.Size(46, 17);
            this.lblTotalLuggagewaiting.TabIndex = 4;
            this.lblTotalLuggagewaiting.Text = "label5";
            // 
            // lblTotalLuggage
            // 
            this.lblTotalLuggage.AutoSize = true;
            this.lblTotalLuggage.Location = new System.Drawing.Point(163, 33);
            this.lblTotalLuggage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLuggage.Name = "lblTotalLuggage";
            this.lblTotalLuggage.Size = new System.Drawing.Size(46, 17);
            this.lblTotalLuggage.TabIndex = 3;
            this.lblTotalLuggage.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total luggage on belt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total luggage waiting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total luggage";
            // 
            // lbEmpStation
            // 
            this.lbEmpStation.FormattingEnabled = true;
            this.lbEmpStation.ItemHeight = 16;
            this.lbEmpStation.Location = new System.Drawing.Point(165, 57);
            this.lbEmpStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEmpStation.Name = "lbEmpStation";
            this.lbEmpStation.Size = new System.Drawing.Size(125, 180);
            this.lbEmpStation.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblLuggageInPlane);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblLuggageInTrailer);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Controls.Add(this.lblLuggageOnbelt);
            this.groupBox1.Controls.Add(this.lblTotalLuggagewaiting);
            this.groupBox1.Controls.Add(this.lblTotalLuggage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(568, 172);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luggage information";
            // 
            // lblLuggageInPlane
            // 
            this.lblLuggageInPlane.AutoSize = true;
            this.lblLuggageInPlane.Location = new System.Drawing.Point(164, 149);
            this.lblLuggageInPlane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuggageInPlane.Name = "lblLuggageInPlane";
            this.lblLuggageInPlane.Size = new System.Drawing.Size(46, 17);
            this.lblLuggageInPlane.TabIndex = 10;
            this.lblLuggageInPlane.Text = "label6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Total luggage loaded";
            // 
            // lblLuggageInTrailer
            // 
            this.lblLuggageInTrailer.AutoSize = true;
            this.lblLuggageInTrailer.Location = new System.Drawing.Point(164, 119);
            this.lblLuggageInTrailer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuggageInTrailer.Name = "lblLuggageInTrailer";
            this.lblLuggageInTrailer.Size = new System.Drawing.Size(46, 17);
            this.lblLuggageInTrailer.TabIndex = 8;
            this.lblLuggageInTrailer.Text = "label6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 119);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Total luggage in trailer";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(264, 12);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.LabelForeColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "luggageChart";
            series3.SmartLabelStyle.Enabled = false;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(285, 153);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(7, 22);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Belt ocupancy";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(363, 219);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lbEmpName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbEmpStation);
            this.groupBox3.Location = new System.Drawing.Point(15, 201);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(325, 258);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employees information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.lbTotalA);
            this.groupBox4.Controls.Add(this.lbTotalB);
            this.groupBox4.Controls.Add(this.lbTotalC);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(347, 201);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(525, 258);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Belts information";
            // 
            // lbTotalA
            // 
            this.lbTotalA.AutoSize = true;
            this.lbTotalA.Location = new System.Drawing.Point(439, 76);
            this.lbTotalA.Name = "lbTotalA";
            this.lbTotalA.Size = new System.Drawing.Size(78, 17);
            this.lbTotalA.TabIndex = 19;
            this.lbTotalA.Text = "Total loads";
            // 
            // lbTotalB
            // 
            this.lbTotalB.AutoSize = true;
            this.lbTotalB.Location = new System.Drawing.Point(439, 105);
            this.lbTotalB.Name = "lbTotalB";
            this.lbTotalB.Size = new System.Drawing.Size(78, 17);
            this.lbTotalB.TabIndex = 18;
            this.lbTotalB.Text = "Total loads";
            // 
            // lbTotalC
            // 
            this.lbTotalC.AutoSize = true;
            this.lbTotalC.Location = new System.Drawing.Point(439, 135);
            this.lbTotalC.Name = "lbTotalC";
            this.lbTotalC.Size = new System.Drawing.Size(78, 17);
            this.lbTotalC.TabIndex = 17;
            this.lbTotalC.Text = "Total loads";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Belt A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Belt B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Belt C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total loads";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFlightinfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbEmpName;
        private System.Windows.Forms.Label lblLuggageOnbelt;
        private System.Windows.Forms.Label lblTotalLuggagewaiting;
        private System.Windows.Forms.Label lblTotalLuggage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEmpStation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalA;
        private System.Windows.Forms.Label lbTotalB;
        private System.Windows.Forms.Label lbTotalC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblLuggageInPlane;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblLuggageInTrailer;
        private System.Windows.Forms.Label label16;
    }
}