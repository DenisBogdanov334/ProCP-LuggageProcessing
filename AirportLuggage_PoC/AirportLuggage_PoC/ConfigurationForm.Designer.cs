namespace AirportLuggage_PoC
{
    partial class ConfigurationForm
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.manualBox = new System.Windows.Forms.GroupBox();
            this.cbWagons = new System.Windows.Forms.ComboBox();
            this.cbTrailer = new System.Windows.Forms.ComboBox();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmployees = new System.Windows.Forms.TextBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.manualBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(145, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(501, 52);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload flights schedule";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.Button1_Click);
            // 
            // manualBox
            // 
            this.manualBox.Controls.Add(this.cbWagons);
            this.manualBox.Controls.Add(this.cbTrailer);
            this.manualBox.Controls.Add(this.dtPick);
            this.manualBox.Controls.Add(this.label4);
            this.manualBox.Controls.Add(this.label3);
            this.manualBox.Controls.Add(this.label2);
            this.manualBox.Controls.Add(this.label1);
            this.manualBox.Controls.Add(this.tbEmployees);
            this.manualBox.Location = new System.Drawing.Point(145, 81);
            this.manualBox.Name = "manualBox";
            this.manualBox.Size = new System.Drawing.Size(501, 284);
            this.manualBox.TabIndex = 1;
            this.manualBox.TabStop = false;
            // 
            // cbWagons
            // 
            this.cbWagons.FormattingEnabled = true;
            this.cbWagons.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbWagons.Location = new System.Drawing.Point(28, 148);
            this.cbWagons.Name = "cbWagons";
            this.cbWagons.Size = new System.Drawing.Size(121, 24);
            this.cbWagons.TabIndex = 10;
            // 
            // cbTrailer
            // 
            this.cbTrailer.FormattingEnabled = true;
            this.cbTrailer.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbTrailer.Location = new System.Drawing.Point(28, 54);
            this.cbTrailer.Name = "cbTrailer";
            this.cbTrailer.Size = new System.Drawing.Size(121, 24);
            this.cbTrailer.TabIndex = 9;
            // 
            // dtPick
            // 
            this.dtPick.CustomFormat = "HH:mm";
            this.dtPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPick.Location = new System.Drawing.Point(239, 56);
            this.dtPick.Name = "dtPick";
            this.dtPick.ShowUpDown = true;
            this.dtPick.Size = new System.Drawing.Size(200, 22);
            this.dtPick.TabIndex = 8;
            this.dtPick.Value = new System.DateTime(2021, 1, 16, 6, 0, 0, 0);
            this.dtPick.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting time";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of wagons";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of trailers";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tbEmployees
            // 
            this.tbEmployees.Location = new System.Drawing.Point(28, 235);
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.Size = new System.Drawing.Size(100, 22);
            this.tbEmployees.TabIndex = 2;
            this.tbEmployees.Text = "10";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(22, 81);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(75, 21);
            this.rbManual.TabIndex = 3;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(22, 121);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(58, 21);
            this.rbAuto.TabIndex = 4;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(542, 400);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.rbAuto);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.manualBox);
            this.Controls.Add(this.btnUpload);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.manualBox.ResumeLayout(false);
            this.manualBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox manualBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmployees;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPick;
        private System.Windows.Forms.ComboBox cbWagons;
        private System.Windows.Forms.ComboBox cbTrailer;
    }
}