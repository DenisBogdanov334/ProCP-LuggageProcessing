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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalLuggage = new System.Windows.Forms.Label();
            this.lblAvgLugPerson = new System.Windows.Forms.Label();
            this.lblLugWeight = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.ListBox();
            this.lbEmpStation = new System.Windows.Forms.ListBox();
            this.lbEmpHoursWorked = new System.Windows.Forms.ListBox();
            this.lbHourlySalary = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(449, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Belt ocupancy";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 270);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblLugWeight);
            this.groupBox1.Controls.Add(this.lblAvgLugPerson);
            this.groupBox1.Controls.Add(this.lblTotalLuggage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luggage info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total luggage transported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average luggage per person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average luggage weight";
            // 
            // lblTotalLuggage
            // 
            this.lblTotalLuggage.AutoSize = true;
            this.lblTotalLuggage.Location = new System.Drawing.Point(192, 27);
            this.lblTotalLuggage.Name = "lblTotalLuggage";
            this.lblTotalLuggage.Size = new System.Drawing.Size(35, 13);
            this.lblTotalLuggage.TabIndex = 3;
            this.lblTotalLuggage.Text = "label4";
            // 
            // lblAvgLugPerson
            // 
            this.lblAvgLugPerson.AutoSize = true;
            this.lblAvgLugPerson.Location = new System.Drawing.Point(192, 50);
            this.lblAvgLugPerson.Name = "lblAvgLugPerson";
            this.lblAvgLugPerson.Size = new System.Drawing.Size(35, 13);
            this.lblAvgLugPerson.TabIndex = 4;
            this.lblAvgLugPerson.Text = "label5";
            // 
            // lblLugWeight
            // 
            this.lblLugWeight.AutoSize = true;
            this.lblLugWeight.Location = new System.Drawing.Point(192, 72);
            this.lblLugWeight.Name = "lblLugWeight";
            this.lblLugWeight.Size = new System.Drawing.Size(35, 13);
            this.lblLugWeight.TabIndex = 5;
            this.lblLugWeight.Text = "label6";
            // 
            // lbEmpName
            // 
            this.lbEmpName.FormattingEnabled = true;
            this.lbEmpName.Location = new System.Drawing.Point(10, 148);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(120, 147);
            this.lbEmpName.TabIndex = 2;
            // 
            // lbEmpStation
            // 
            this.lbEmpStation.FormattingEnabled = true;
            this.lbEmpStation.Location = new System.Drawing.Point(136, 148);
            this.lbEmpStation.Name = "lbEmpStation";
            this.lbEmpStation.Size = new System.Drawing.Size(120, 147);
            this.lbEmpStation.TabIndex = 3;
            // 
            // lbEmpHoursWorked
            // 
            this.lbEmpHoursWorked.FormattingEnabled = true;
            this.lbEmpHoursWorked.Location = new System.Drawing.Point(262, 148);
            this.lbEmpHoursWorked.Name = "lbEmpHoursWorked";
            this.lbEmpHoursWorked.Size = new System.Drawing.Size(78, 147);
            this.lbEmpHoursWorked.TabIndex = 4;
            // 
            // lbHourlySalary
            // 
            this.lbHourlySalary.FormattingEnabled = true;
            this.lbHourlySalary.Location = new System.Drawing.Point(346, 148);
            this.lbHourlySalary.Name = "lbHourlySalary";
            this.lbHourlySalary.Size = new System.Drawing.Size(78, 147);
            this.lbHourlySalary.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emoloyee name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Working at station";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hours worked";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hourly salary";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(778, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbHourlySalary);
            this.Controls.Add(this.lbEmpHoursWorked);
            this.Controls.Add(this.lbEmpStation);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLugWeight;
        private System.Windows.Forms.Label lblAvgLugPerson;
        private System.Windows.Forms.Label lblTotalLuggage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEmpName;
        private System.Windows.Forms.ListBox lbEmpStation;
        private System.Windows.Forms.ListBox lbEmpHoursWorked;
        private System.Windows.Forms.ListBox lbHourlySalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
    }
}