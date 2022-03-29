namespace SystemViewer
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.crclprgrsbHdd = new CircularProgressBar.CircularProgressBar();
            this.btnINFO = new System.Windows.Forms.Button();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblbaseclock = new System.Windows.Forms.Label();
            this.lblused = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.lblhddused = new System.Windows.Forms.Label();
            this.lblhddactivity = new System.Windows.Forms.Label();
            this.crclprgrsbrCpu = new CircularProgressBar.CircularProgressBar();
            this.crclprgrsbrRam = new CircularProgressBar.CircularProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbtnita = new System.Windows.Forms.RadioButton();
            this.rdbtneng = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtnCustom = new System.Windows.Forms.RadioButton();
            this.rdbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rdbtnCpuDefault = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crclprgrsbHdd
            // 
            this.crclprgrsbHdd.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbHdd.AnimationSpeed = 100;
            this.crclprgrsbHdd.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbHdd.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbHdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbHdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbHdd.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbHdd.InnerMargin = 2;
            this.crclprgrsbHdd.InnerWidth = -1;
            this.crclprgrsbHdd.Location = new System.Drawing.Point(11, 395);
            this.crclprgrsbHdd.Margin = new System.Windows.Forms.Padding(2);
            this.crclprgrsbHdd.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbHdd.Name = "crclprgrsbHdd";
            this.crclprgrsbHdd.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbHdd.OuterMargin = -25;
            this.crclprgrsbHdd.OuterWidth = 26;
            this.crclprgrsbHdd.ProgressColor = System.Drawing.Color.BlueViolet;
            this.crclprgrsbHdd.ProgressWidth = 15;
            this.crclprgrsbHdd.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbHdd.Size = new System.Drawing.Size(125, 125);
            this.crclprgrsbHdd.StartAngle = 270;
            this.crclprgrsbHdd.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.crclprgrsbHdd.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclprgrsbHdd.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclprgrsbHdd.SubscriptText = "";
            this.crclprgrsbHdd.SuperscriptColor = System.Drawing.Color.Red;
            this.crclprgrsbHdd.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclprgrsbHdd.SuperscriptText = "";
            this.crclprgrsbHdd.TabIndex = 56;
            this.crclprgrsbHdd.Text = "N/D%";
            this.crclprgrsbHdd.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crclprgrsbHdd.Value = 68;
            // 
            // btnINFO
            // 
            this.btnINFO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFO.Location = new System.Drawing.Point(165, 207);
            this.btnINFO.Margin = new System.Windows.Forms.Padding(2);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(68, 28);
            this.btnINFO.TabIndex = 55;
            this.btnINFO.Text = "INFO";
            this.btnINFO.UseVisualStyleBackColor = false;
            this.btnINFO.Click += new System.EventHandler(this.btnINFO_Click);
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(160, 120);
            this.lblmodel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(66, 25);
            this.lblmodel.TabIndex = 54;
            this.lblmodel.Text = "Model";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(163, 330);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(56, 25);
            this.lbltotal.TabIndex = 52;
            this.lbltotal.Text = "Total";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(155, 395);
            this.lblHDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(115, 51);
            this.lblHDD.TabIndex = 50;
            this.lblHDD.Text = "HDD";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(152, 69);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(113, 51);
            this.lblCPU.TabIndex = 46;
            this.lblCPU.Text = "CPU";
            // 
            // lblbaseclock
            // 
            this.lblbaseclock.AutoSize = true;
            this.lblbaseclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaseclock.Location = new System.Drawing.Point(160, 145);
            this.lblbaseclock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaseclock.Name = "lblbaseclock";
            this.lblbaseclock.Size = new System.Drawing.Size(112, 25);
            this.lblbaseclock.TabIndex = 51;
            this.lblbaseclock.Text = "Base Clock";
            // 
            // lblused
            // 
            this.lblused.AutoSize = true;
            this.lblused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblused.Location = new System.Drawing.Point(164, 360);
            this.lblused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblused.Name = "lblused";
            this.lblused.Size = new System.Drawing.Size(58, 25);
            this.lblused.TabIndex = 53;
            this.lblused.Text = "Used";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(152, 248);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(118, 51);
            this.lblRAM.TabIndex = 49;
            this.lblRAM.Text = "RAM";
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusage.Location = new System.Drawing.Point(158, 173);
            this.lblusage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(96, 32);
            this.lblusage.TabIndex = 47;
            this.lblusage.Text = "Usage";
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.Location = new System.Drawing.Point(163, 299);
            this.lblavailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(111, 29);
            this.lblavailable.TabIndex = 48;
            this.lblavailable.Text = "Available";
            // 
            // lblhddused
            // 
            this.lblhddused.AutoSize = true;
            this.lblhddused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddused.Location = new System.Drawing.Point(163, 476);
            this.lblhddused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhddused.Name = "lblhddused";
            this.lblhddused.Size = new System.Drawing.Size(58, 25);
            this.lblhddused.TabIndex = 45;
            this.lblhddused.Text = "Used";
            // 
            // lblhddactivity
            // 
            this.lblhddactivity.AutoSize = true;
            this.lblhddactivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddactivity.Location = new System.Drawing.Point(164, 446);
            this.lblhddactivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhddactivity.Name = "lblhddactivity";
            this.lblhddactivity.Size = new System.Drawing.Size(74, 25);
            this.lblhddactivity.TabIndex = 43;
            this.lblhddactivity.Text = "Activity";
            // 
            // crclprgrsbrCpu
            // 
            this.crclprgrsbrCpu.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbrCpu.AnimationSpeed = 100;
            this.crclprgrsbrCpu.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbrCpu.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbrCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbrCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbrCpu.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbrCpu.InnerMargin = 2;
            this.crclprgrsbrCpu.InnerWidth = -1;
            this.crclprgrsbrCpu.Location = new System.Drawing.Point(11, 69);
            this.crclprgrsbrCpu.Margin = new System.Windows.Forms.Padding(2);
            this.crclprgrsbrCpu.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbrCpu.Name = "crclprgrsbrCpu";
            this.crclprgrsbrCpu.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbrCpu.OuterMargin = -25;
            this.crclprgrsbrCpu.OuterWidth = 26;
            this.crclprgrsbrCpu.ProgressColor = System.Drawing.Color.Gainsboro;
            this.crclprgrsbrCpu.ProgressWidth = 15;
            this.crclprgrsbrCpu.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbrCpu.Size = new System.Drawing.Size(125, 125);
            this.crclprgrsbrCpu.StartAngle = 270;
            this.crclprgrsbrCpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.crclprgrsbrCpu.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclprgrsbrCpu.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclprgrsbrCpu.SubscriptText = "";
            this.crclprgrsbrCpu.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclprgrsbrCpu.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclprgrsbrCpu.SuperscriptText = "";
            this.crclprgrsbrCpu.TabIndex = 42;
            this.crclprgrsbrCpu.Text = "N/D%";
            this.crclprgrsbrCpu.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crclprgrsbrCpu.Value = 68;
            this.crclprgrsbrCpu.Click += new System.EventHandler(this.crclprgrsbrCpu_Click);
            // 
            // crclprgrsbrRam
            // 
            this.crclprgrsbrRam.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbrRam.AnimationSpeed = 750;
            this.crclprgrsbrRam.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbrRam.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbrRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbrRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbrRam.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbrRam.InnerMargin = 2;
            this.crclprgrsbrRam.InnerWidth = -1;
            this.crclprgrsbrRam.Location = new System.Drawing.Point(11, 248);
            this.crclprgrsbrRam.Margin = new System.Windows.Forms.Padding(2);
            this.crclprgrsbrRam.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbrRam.Name = "crclprgrsbrRam";
            this.crclprgrsbrRam.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbrRam.OuterMargin = -25;
            this.crclprgrsbrRam.OuterWidth = 26;
            this.crclprgrsbrRam.ProgressColor = System.Drawing.Color.BlueViolet;
            this.crclprgrsbrRam.ProgressWidth = 15;
            this.crclprgrsbrRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbrRam.Size = new System.Drawing.Size(125, 125);
            this.crclprgrsbrRam.StartAngle = 270;
            this.crclprgrsbrRam.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.crclprgrsbrRam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclprgrsbrRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclprgrsbrRam.SubscriptText = "";
            this.crclprgrsbrRam.SuperscriptColor = System.Drawing.Color.Red;
            this.crclprgrsbrRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclprgrsbrRam.SuperscriptText = "";
            this.crclprgrsbrRam.TabIndex = 44;
            this.crclprgrsbrRam.Text = "N/D%";
            this.crclprgrsbrRam.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crclprgrsbrRam.Value = 68;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.informationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 29);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.informationsToolStripMenuItem.Text = "Informations";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbtnita);
            this.panel2.Controls.Add(this.rdbtneng);
            this.panel2.Location = new System.Drawing.Point(851, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 89);
            this.panel2.TabIndex = 59;
            // 
            // rdbtnita
            // 
            this.rdbtnita.AutoSize = true;
            this.rdbtnita.Location = new System.Drawing.Point(3, 54);
            this.rdbtnita.Name = "rdbtnita";
            this.rdbtnita.Size = new System.Drawing.Size(71, 20);
            this.rdbtnita.TabIndex = 47;
            this.rdbtnita.TabStop = true;
            this.rdbtnita.Text = "Italiano";
            this.rdbtnita.UseVisualStyleBackColor = true;
            this.rdbtnita.CheckedChanged += new System.EventHandler(this.rdbtnita_CheckedChanged);
            // 
            // rdbtneng
            // 
            this.rdbtneng.AutoSize = true;
            this.rdbtneng.Checked = true;
            this.rdbtneng.Location = new System.Drawing.Point(3, 15);
            this.rdbtneng.Name = "rdbtneng";
            this.rdbtneng.Size = new System.Drawing.Size(72, 20);
            this.rdbtneng.TabIndex = 46;
            this.rdbtneng.TabStop = true;
            this.rdbtneng.Text = "English";
            this.rdbtneng.UseVisualStyleBackColor = true;
            this.rdbtneng.CheckedChanged += new System.EventHandler(this.rdbtneng_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtnCustom);
            this.panel1.Controls.Add(this.rdbtnPercentage);
            this.panel1.Controls.Add(this.rdbtnCpuDefault);
            this.panel1.Location = new System.Drawing.Point(851, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 103);
            this.panel1.TabIndex = 58;
            // 
            // rdbtnCustom
            // 
            this.rdbtnCustom.AutoSize = true;
            this.rdbtnCustom.Location = new System.Drawing.Point(4, 75);
            this.rdbtnCustom.Name = "rdbtnCustom";
            this.rdbtnCustom.Size = new System.Drawing.Size(73, 20);
            this.rdbtnCustom.TabIndex = 2;
            this.rdbtnCustom.Text = "Custom";
            this.rdbtnCustom.UseVisualStyleBackColor = true;
            this.rdbtnCustom.CheckedChanged += new System.EventHandler(this.rdbtnCustom_CheckedChanged);
            // 
            // rdbtnPercentage
            // 
            this.rdbtnPercentage.AutoSize = true;
            this.rdbtnPercentage.Location = new System.Drawing.Point(4, 45);
            this.rdbtnPercentage.Name = "rdbtnPercentage";
            this.rdbtnPercentage.Size = new System.Drawing.Size(98, 20);
            this.rdbtnPercentage.TabIndex = 1;
            this.rdbtnPercentage.Text = "Percentage";
            this.rdbtnPercentage.UseVisualStyleBackColor = true;
            this.rdbtnPercentage.CheckedChanged += new System.EventHandler(this.rdbtnPercentage_CheckedChanged);
            // 
            // rdbtnCpuDefault
            // 
            this.rdbtnCpuDefault.AutoSize = true;
            this.rdbtnCpuDefault.Checked = true;
            this.rdbtnCpuDefault.Location = new System.Drawing.Point(4, 18);
            this.rdbtnCpuDefault.Name = "rdbtnCpuDefault";
            this.rdbtnCpuDefault.Size = new System.Drawing.Size(70, 20);
            this.rdbtnCpuDefault.TabIndex = 0;
            this.rdbtnCpuDefault.TabStop = true;
            this.rdbtnCpuDefault.Text = "Default";
            this.rdbtnCpuDefault.UseVisualStyleBackColor = true;
            this.rdbtnCpuDefault.CheckedChanged += new System.EventHandler(this.rdbtnCpuDefault_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crclprgrsbHdd);
            this.Controls.Add(this.btnINFO);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblHDD);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblbaseclock);
            this.Controls.Add(this.lblused);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.lblhddused);
            this.Controls.Add(this.lblhddactivity);
            this.Controls.Add(this.crclprgrsbrCpu);
            this.Controls.Add(this.crclprgrsbrRam);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Viewer > Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar crclprgrsbHdd;
        private System.Windows.Forms.Button btnINFO;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblbaseclock;
        private System.Windows.Forms.Label lblused;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.Label lblhddused;
        private System.Windows.Forms.Label lblhddactivity;
        private CircularProgressBar.CircularProgressBar crclprgrsbrCpu;
        private CircularProgressBar.CircularProgressBar crclprgrsbrRam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtnita;
        private System.Windows.Forms.RadioButton rdbtneng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnCustom;
        private System.Windows.Forms.RadioButton rdbtnPercentage;
        private System.Windows.Forms.RadioButton rdbtnCpuDefault;
    }
}