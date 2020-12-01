namespace AirportLuggage_PoC
{
    partial class SimulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDropoff = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.timerMoveLuggages = new System.Windows.Forms.Timer(this.components);
            this.timerSetBelt = new System.Windows.Forms.Timer(this.components);
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbTrailerA = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbZoneC = new System.Windows.Forms.PictureBox();
            this.pbZoneB = new System.Windows.Forms.PictureBox();
            this.pbZoneA = new System.Windows.Forms.PictureBox();
            this.pbTrailerB = new System.Windows.Forms.PictureBox();
            this.pbTrailerC = new System.Windows.Forms.PictureBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLoadToFlight = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLoadedA = new System.Windows.Forms.Label();
            this.lbLoadedB = new System.Windows.Forms.Label();
            this.lbLoadedC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(370, 107);
            this.progressBar1.MarqueeAnimationSpeed = 750;
            this.progressBar1.Maximum = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(333, 230);
            this.progressBar2.Maximum = 170;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(438, 14);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(261, 364);
            this.progressBar3.Maximum = 225;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(510, 14);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Belt A = 150m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Belt B = 170m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Belt C  = 225m";
            // 
            // lbDropoff
            // 
            this.lbDropoff.FormattingEnabled = true;
            this.lbDropoff.Location = new System.Drawing.Point(15, 39);
            this.lbDropoff.Name = "lbDropoff";
            this.lbDropoff.Size = new System.Drawing.Size(368, 225);
            this.lbDropoff.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Control Panel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1156, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Zone A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1156, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zone B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1156, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Zone C";
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(388, 39);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(356, 225);
            this.lbStatus.TabIndex = 24;
            // 
            // timerMoveLuggages
            // 
            this.timerMoveLuggages.Tick += new System.EventHandler(this.timerMoveLuggages_Tick);
            // 
            // timerSetBelt
            // 
            this.timerSetBelt.Interval = 1000;
            this.timerSetBelt.Tick += new System.EventHandler(this.timerSetBelt_Tick);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(22, 196);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(193, 23);
            this.btnStatistics.TabIndex = 32;
            this.btnStatistics.Text = "Show statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(22, 138);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(193, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset simulation";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(22, 80);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(192, 23);
            this.btnPause.TabIndex = 30;
            this.btnPause.Text = "Pause simulation";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.pauzeButton_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 23);
            this.btnStart.TabIndex = 29;
            this.btnStart.Text = "Start simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pbTrailerA
            // 
            this.pbTrailerA.Image = global::AirportLuggage_PoC.Properties.Resources.trailer;
            this.pbTrailerA.Location = new System.Drawing.Point(814, 87);
            this.pbTrailerA.Name = "pbTrailerA";
            this.pbTrailerA.Size = new System.Drawing.Size(65, 50);
            this.pbTrailerA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrailerA.TabIndex = 33;
            this.pbTrailerA.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(777, 354);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(777, 218);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(777, 99);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(261, 332);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(294, 220);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(334, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pbZoneC
            // 
            this.pbZoneC.Image = ((System.Drawing.Image)(resources.GetObject("pbZoneC.Image")));
            this.pbZoneC.Location = new System.Drawing.Point(1123, 297);
            this.pbZoneC.Name = "pbZoneC";
            this.pbZoneC.Size = new System.Drawing.Size(198, 111);
            this.pbZoneC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbZoneC.TabIndex = 5;
            this.pbZoneC.TabStop = false;
            // 
            // pbZoneB
            // 
            this.pbZoneB.Image = ((System.Drawing.Image)(resources.GetObject("pbZoneB.Image")));
            this.pbZoneB.Location = new System.Drawing.Point(1123, 167);
            this.pbZoneB.Name = "pbZoneB";
            this.pbZoneB.Size = new System.Drawing.Size(198, 107);
            this.pbZoneB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbZoneB.TabIndex = 4;
            this.pbZoneB.TabStop = false;
            // 
            // pbZoneA
            // 
            this.pbZoneA.Image = ((System.Drawing.Image)(resources.GetObject("pbZoneA.Image")));
            this.pbZoneA.Location = new System.Drawing.Point(1123, 47);
            this.pbZoneA.Name = "pbZoneA";
            this.pbZoneA.Size = new System.Drawing.Size(198, 107);
            this.pbZoneA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbZoneA.TabIndex = 3;
            this.pbZoneA.TabStop = false;
            // 
            // pbTrailerB
            // 
            this.pbTrailerB.Image = global::AirportLuggage_PoC.Properties.Resources.trailer;
            this.pbTrailerB.Location = new System.Drawing.Point(814, 206);
            this.pbTrailerB.Name = "pbTrailerB";
            this.pbTrailerB.Size = new System.Drawing.Size(65, 50);
            this.pbTrailerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrailerB.TabIndex = 36;
            this.pbTrailerB.TabStop = false;
            // 
            // pbTrailerC
            // 
            this.pbTrailerC.Image = global::AirportLuggage_PoC.Properties.Resources.trailer;
            this.pbTrailerC.Location = new System.Drawing.Point(814, 341);
            this.pbTrailerC.Name = "pbTrailerC";
            this.pbTrailerC.Size = new System.Drawing.Size(65, 50);
            this.pbTrailerC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrailerC.TabIndex = 37;
            this.pbTrailerC.TabStop = false;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(813, 107);
            this.progressBar4.MarqueeAnimationSpeed = 750;
            this.progressBar4.Maximum = 150;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(301, 14);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 38;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(814, 230);
            this.progressBar5.MarqueeAnimationSpeed = 750;
            this.progressBar5.Maximum = 150;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(300, 14);
            this.progressBar5.Step = 1;
            this.progressBar5.TabIndex = 39;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(813, 364);
            this.progressBar6.MarqueeAnimationSpeed = 750;
            this.progressBar6.Maximum = 150;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(301, 14);
            this.progressBar6.Step = 1;
            this.progressBar6.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbDropoff);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbLoadToFlight);
            this.panel1.Location = new System.Drawing.Point(9, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 279);
            this.panel1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Information Panel";
            // 
            // lbLoadToFlight
            // 
            this.lbLoadToFlight.FormattingEnabled = true;
            this.lbLoadToFlight.Location = new System.Drawing.Point(749, 39);
            this.lbLoadToFlight.Name = "lbLoadToFlight";
            this.lbLoadToFlight.Size = new System.Drawing.Size(356, 225);
            this.lbLoadToFlight.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnStatistics);
            this.panel2.Location = new System.Drawing.Point(9, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 308);
            this.panel2.TabIndex = 42;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(22, 254);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(193, 23);
            this.btnConfig.TabIndex = 33;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauzeToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1395, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauzeToolStripMenuItem
            // 
            this.pauzeToolStripMenuItem.Name = "pauzeToolStripMenuItem";
            this.pauzeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauzeToolStripMenuItem.Text = "Pause";
            this.pauzeToolStripMenuItem.Click += new System.EventHandler(this.pauzeToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 723);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1395, 41);
            this.panel3.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "SIM Simulation Company 2020";
            // 
            // lbLoadedA
            // 
            this.lbLoadedA.AutoSize = true;
            this.lbLoadedA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadedA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLoadedA.Location = new System.Drawing.Point(782, 79);
            this.lbLoadedA.Name = "lbLoadedA";
            this.lbLoadedA.Size = new System.Drawing.Size(21, 13);
            this.lbLoadedA.TabIndex = 45;
            this.lbLoadedA.Text = "+0";
            // 
            // lbLoadedB
            // 
            this.lbLoadedB.AutoSize = true;
            this.lbLoadedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadedB.Location = new System.Drawing.Point(782, 195);
            this.lbLoadedB.Name = "lbLoadedB";
            this.lbLoadedB.Size = new System.Drawing.Size(21, 13);
            this.lbLoadedB.TabIndex = 46;
            this.lbLoadedB.Text = "+0";
            // 
            // lbLoadedC
            // 
            this.lbLoadedC.AutoSize = true;
            this.lbLoadedC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadedC.Location = new System.Drawing.Point(782, 332);
            this.lbLoadedC.Name = "lbLoadedC";
            this.lbLoadedC.Size = new System.Drawing.Size(21, 13);
            this.lbLoadedC.TabIndex = 47;
            this.lbLoadedC.Text = "+0";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 764);
            this.Controls.Add(this.lbLoadedC);
            this.Controls.Add(this.lbLoadedB);
            this.Controls.Add(this.lbLoadedA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbTrailerC);
            this.Controls.Add(this.pbTrailerB);
            this.Controls.Add(this.pbTrailerA);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbZoneC);
            this.Controls.Add(this.pbZoneB);
            this.Controls.Add(this.pbZoneA);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimulationForm";
            this.Text = "Eindhoven Aiport Luggages Transport Simulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoneA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrailerC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.PictureBox pbZoneA;
        private System.Windows.Forms.PictureBox pbZoneB;
        private System.Windows.Forms.PictureBox pbZoneC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDropoff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Timer timerMoveLuggages;
        private System.Windows.Forms.Timer timerSetBelt;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbTrailerA;
        private System.Windows.Forms.PictureBox pbTrailerB;
        private System.Windows.Forms.PictureBox pbTrailerC;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ListBox lbLoadToFlight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbLoadedA;
        private System.Windows.Forms.Label lbLoadedB;
        private System.Windows.Forms.Label lbLoadedC;
    }
}

