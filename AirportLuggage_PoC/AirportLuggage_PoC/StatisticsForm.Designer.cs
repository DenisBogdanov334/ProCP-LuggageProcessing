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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLuggageNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbFlightsInfo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmpHired = new System.Windows.Forms.Label();
            this.lbEmpSuggestion = new System.Windows.Forms.Label();
            this.lbEmpNeeded = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total employees hired:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee action suggestion:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orchid;
            this.groupBox2.Controls.Add(this.lbLuggageNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luggage info";
            // 
            // lbLuggageNo
            // 
            this.lbLuggageNo.AutoSize = true;
            this.lbLuggageNo.Location = new System.Drawing.Point(124, 20);
            this.lbLuggageNo.Name = "lbLuggageNo";
            this.lbLuggageNo.Size = new System.Drawing.Size(24, 13);
            this.lbLuggageNo.TabIndex = 1;
            this.lbLuggageNo.Text = "n/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
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
            this.groupBox3.Location = new System.Drawing.Point(355, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 150);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flight info";
            // 
            // lbFlightsInfo
            // 
            this.lbFlightsInfo.FormattingEnabled = true;
            this.lbFlightsInfo.Location = new System.Drawing.Point(10, 45);
            this.lbFlightsInfo.Name = "lbFlightsInfo";
            this.lbFlightsInfo.Size = new System.Drawing.Size(233, 95);
            this.lbFlightsInfo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Delay time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Needed employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flight number";
            // 
            // lbEmpHired
            // 
            this.lbEmpHired.AutoSize = true;
            this.lbEmpHired.Location = new System.Drawing.Point(145, 23);
            this.lbEmpHired.Name = "lbEmpHired";
            this.lbEmpHired.Size = new System.Drawing.Size(24, 13);
            this.lbEmpHired.TabIndex = 3;
            this.lbEmpHired.Text = "n/a";
            // 
            // lbEmpSuggestion
            // 
            this.lbEmpSuggestion.AutoSize = true;
            this.lbEmpSuggestion.Location = new System.Drawing.Point(145, 68);
            this.lbEmpSuggestion.Name = "lbEmpSuggestion";
            this.lbEmpSuggestion.Size = new System.Drawing.Size(24, 13);
            this.lbEmpSuggestion.TabIndex = 4;
            this.lbEmpSuggestion.Text = "n/a";
            // 
            // lbEmpNeeded
            // 
            this.lbEmpNeeded.AutoSize = true;
            this.lbEmpNeeded.Location = new System.Drawing.Point(145, 45);
            this.lbEmpNeeded.Name = "lbEmpNeeded";
            this.lbEmpNeeded.Size = new System.Drawing.Size(24, 13);
            this.lbEmpNeeded.TabIndex = 5;
            this.lbEmpNeeded.Text = "n/a";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(624, 173);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}