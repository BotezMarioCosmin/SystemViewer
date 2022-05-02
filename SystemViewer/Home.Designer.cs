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
            this.helpCpu = new System.Windows.Forms.Button();
            this.lblGPU = new System.Windows.Forms.Label();
            this.btnINFOGPU = new System.Windows.Forms.Button();
            this.btnINFOHDD = new System.Windows.Forms.Button();
            this.lblgpumodel = new System.Windows.Forms.Label();
            this.lblhddtotal = new System.Windows.Forms.Label();
            this.crclrprgrsbrHddUsed = new CircularProgressBar.CircularProgressBar();
            this.lblhddfree = new System.Windows.Forms.Label();
            this.btnINFORAM = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.helpCpuTemp = new System.Windows.Forms.Button();
            this.helpHddActivity = new System.Windows.Forms.Button();
            this.lblGPUTEMP = new System.Windows.Forms.Label();
            this.lblGpuVram = new System.Windows.Forms.Label();
            this.helpGpuTemp = new System.Windows.Forms.Button();
            this.lblCPUTEMP = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crclprgrsbHdd
            // 
            this.crclprgrsbHdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crclprgrsbHdd.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbHdd.AnimationSpeed = 100;
            this.crclprgrsbHdd.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbHdd.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbHdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbHdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbHdd.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbHdd.InnerMargin = 2;
            this.crclprgrsbHdd.InnerWidth = -1;
            this.crclprgrsbHdd.Location = new System.Drawing.Point(591, 421);
            this.crclprgrsbHdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crclprgrsbHdd.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbHdd.Name = "crclprgrsbHdd";
            this.crclprgrsbHdd.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbHdd.OuterMargin = -25;
            this.crclprgrsbHdd.OuterWidth = 26;
            this.crclprgrsbHdd.ProgressColor = System.Drawing.Color.BlueViolet;
            this.crclprgrsbHdd.ProgressWidth = 15;
            this.crclprgrsbHdd.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbHdd.Size = new System.Drawing.Size(167, 154);
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
            this.crclprgrsbHdd.Click += new System.EventHandler(this.crclprgrsbHdd_Click);
            // 
            // btnINFO
            // 
            this.btnINFO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnINFO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFO.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnINFO.Location = new System.Drawing.Point(364, 146);
            this.btnINFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(67, 31);
            this.btnINFO.TabIndex = 55;
            this.btnINFO.Text = "INFO";
            this.btnINFO.UseVisualStyleBackColor = false;
            this.btnINFO.Click += new System.EventHandler(this.btnINFO_Click);
            // 
            // lblmodel
            // 
            this.lblmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblmodel.Location = new System.Drawing.Point(256, 181);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(66, 25);
            this.lblmodel.TabIndex = 54;
            this.lblmodel.Text = "Model";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbltotal.Location = new System.Drawing.Point(252, 460);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(68, 29);
            this.lbltotal.TabIndex = 52;
            this.lbltotal.Text = "Total";
            // 
            // lblHDD
            // 
            this.lblHDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHDD.Location = new System.Drawing.Point(813, 409);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(115, 51);
            this.lblHDD.TabIndex = 50;
            this.lblHDD.Text = "HDD";
            // 
            // lblCPU
            // 
            this.lblCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCPU.Location = new System.Drawing.Point(248, 132);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(113, 51);
            this.lblCPU.TabIndex = 46;
            this.lblCPU.Text = "CPU";
            // 
            // lblbaseclock
            // 
            this.lblbaseclock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbaseclock.AutoSize = true;
            this.lblbaseclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaseclock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblbaseclock.Location = new System.Drawing.Point(253, 208);
            this.lblbaseclock.Name = "lblbaseclock";
            this.lblbaseclock.Size = new System.Drawing.Size(157, 32);
            this.lblbaseclock.TabIndex = 51;
            this.lblbaseclock.Text = "Base Clock";
            // 
            // lblused
            // 
            this.lblused.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblused.AutoSize = true;
            this.lblused.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblused.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblused.Location = new System.Drawing.Point(253, 542);
            this.lblused.Name = "lblused";
            this.lblused.Size = new System.Drawing.Size(70, 29);
            this.lblused.TabIndex = 53;
            this.lblused.Text = "Used";
            // 
            // lblRAM
            // 
            this.lblRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRAM.Location = new System.Drawing.Point(248, 409);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(118, 51);
            this.lblRAM.TabIndex = 49;
            this.lblRAM.Text = "RAM";
            // 
            // lblusage
            // 
            this.lblusage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblusage.AutoSize = true;
            this.lblusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblusage.Location = new System.Drawing.Point(253, 240);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(96, 32);
            this.lblusage.TabIndex = 47;
            this.lblusage.Text = "Usage";
            // 
            // lblavailable
            // 
            this.lblavailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblavailable.Location = new System.Drawing.Point(253, 500);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(111, 29);
            this.lblavailable.TabIndex = 48;
            this.lblavailable.Text = "Available";
            // 
            // lblhddused
            // 
            this.lblhddused.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhddused.AutoSize = true;
            this.lblhddused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddused.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblhddused.Location = new System.Drawing.Point(821, 513);
            this.lblhddused.Name = "lblhddused";
            this.lblhddused.Size = new System.Drawing.Size(58, 25);
            this.lblhddused.TabIndex = 45;
            this.lblhddused.Text = "Used";
            // 
            // lblhddactivity
            // 
            this.lblhddactivity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhddactivity.AutoSize = true;
            this.lblhddactivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddactivity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblhddactivity.Location = new System.Drawing.Point(821, 464);
            this.lblhddactivity.Name = "lblhddactivity";
            this.lblhddactivity.Size = new System.Drawing.Size(74, 25);
            this.lblhddactivity.TabIndex = 43;
            this.lblhddactivity.Text = "Activity";
            // 
            // crclprgrsbrCpu
            // 
            this.crclprgrsbrCpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crclprgrsbrCpu.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbrCpu.AnimationSpeed = 100;
            this.crclprgrsbrCpu.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbrCpu.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbrCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbrCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbrCpu.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbrCpu.InnerMargin = 2;
            this.crclprgrsbrCpu.InnerWidth = -1;
            this.crclprgrsbrCpu.Location = new System.Drawing.Point(39, 146);
            this.crclprgrsbrCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crclprgrsbrCpu.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbrCpu.Name = "crclprgrsbrCpu";
            this.crclprgrsbrCpu.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbrCpu.OuterMargin = -25;
            this.crclprgrsbrCpu.OuterWidth = 26;
            this.crclprgrsbrCpu.ProgressColor = System.Drawing.Color.Gainsboro;
            this.crclprgrsbrCpu.ProgressWidth = 15;
            this.crclprgrsbrCpu.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbrCpu.Size = new System.Drawing.Size(167, 154);
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
            this.crclprgrsbrRam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crclprgrsbrRam.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclprgrsbrRam.AnimationSpeed = 750;
            this.crclprgrsbrRam.BackColor = System.Drawing.Color.Transparent;
            this.crclprgrsbrRam.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclprgrsbrRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclprgrsbrRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclprgrsbrRam.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclprgrsbrRam.InnerMargin = 2;
            this.crclprgrsbrRam.InnerWidth = -1;
            this.crclprgrsbrRam.Location = new System.Drawing.Point(39, 421);
            this.crclprgrsbrRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crclprgrsbrRam.MarqueeAnimationSpeed = 2000;
            this.crclprgrsbrRam.Name = "crclprgrsbrRam";
            this.crclprgrsbrRam.OuterColor = System.Drawing.Color.Gray;
            this.crclprgrsbrRam.OuterMargin = -25;
            this.crclprgrsbrRam.OuterWidth = 26;
            this.crclprgrsbrRam.ProgressColor = System.Drawing.Color.BlueViolet;
            this.crclprgrsbrRam.ProgressWidth = 15;
            this.crclprgrsbrRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclprgrsbrRam.Size = new System.Drawing.Size(167, 154);
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
            this.crclprgrsbrRam.Click += new System.EventHandler(this.crclprgrsbrRam_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.informationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1312, 36);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.settingsToolStripMenuItem.Image = global::SystemViewer.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.informationsToolStripMenuItem.Image = global::SystemViewer.Properties.Resources.info;
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.informationsToolStripMenuItem.Text = "Informations";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpCpu
            // 
            this.helpCpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpCpu.BackColor = System.Drawing.Color.Transparent;
            this.helpCpu.ForeColor = System.Drawing.Color.Transparent;
            this.helpCpu.Location = new System.Drawing.Point(213, 208);
            this.helpCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpCpu.Name = "helpCpu";
            this.helpCpu.Size = new System.Drawing.Size(35, 34);
            this.helpCpu.TabIndex = 66;
            this.helpCpu.UseVisualStyleBackColor = false;
            this.helpCpu.Click += new System.EventHandler(this.helpCpu_Click);
            // 
            // lblGPU
            // 
            this.lblGPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGPU.Location = new System.Drawing.Point(813, 146);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(115, 51);
            this.lblGPU.TabIndex = 67;
            this.lblGPU.Text = "GPU";
            // 
            // btnINFOGPU
            // 
            this.btnINFOGPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnINFOGPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFOGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFOGPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnINFOGPU.Location = new System.Drawing.Point(924, 160);
            this.btnINFOGPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINFOGPU.Name = "btnINFOGPU";
            this.btnINFOGPU.Size = new System.Drawing.Size(67, 31);
            this.btnINFOGPU.TabIndex = 68;
            this.btnINFOGPU.Text = "INFO";
            this.btnINFOGPU.UseVisualStyleBackColor = false;
            this.btnINFOGPU.Click += new System.EventHandler(this.btnINFOGPU_Click);
            // 
            // btnINFOHDD
            // 
            this.btnINFOHDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnINFOHDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFOHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFOHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnINFOHDD.Location = new System.Drawing.Point(925, 421);
            this.btnINFOHDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINFOHDD.Name = "btnINFOHDD";
            this.btnINFOHDD.Size = new System.Drawing.Size(67, 31);
            this.btnINFOHDD.TabIndex = 69;
            this.btnINFOHDD.Text = "INFO";
            this.btnINFOHDD.UseVisualStyleBackColor = false;
            this.btnINFOHDD.Click += new System.EventHandler(this.btnINFOHDD_Click_1);
            // 
            // lblgpumodel
            // 
            this.lblgpumodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblgpumodel.AutoSize = true;
            this.lblgpumodel.BackColor = System.Drawing.Color.Transparent;
            this.lblgpumodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgpumodel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblgpumodel.Location = new System.Drawing.Point(820, 197);
            this.lblgpumodel.Name = "lblgpumodel";
            this.lblgpumodel.Size = new System.Drawing.Size(66, 25);
            this.lblgpumodel.TabIndex = 70;
            this.lblgpumodel.Text = "Model";
            // 
            // lblhddtotal
            // 
            this.lblhddtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhddtotal.AutoSize = true;
            this.lblhddtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddtotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblhddtotal.Location = new System.Drawing.Point(821, 487);
            this.lblhddtotal.Name = "lblhddtotal";
            this.lblhddtotal.Size = new System.Drawing.Size(56, 25);
            this.lblhddtotal.TabIndex = 71;
            this.lblhddtotal.Text = "Total";
            // 
            // crclrprgrsbrHddUsed
            // 
            this.crclrprgrsbrHddUsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crclrprgrsbrHddUsed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclrprgrsbrHddUsed.AnimationSpeed = 100;
            this.crclrprgrsbrHddUsed.BackColor = System.Drawing.Color.Transparent;
            this.crclrprgrsbrHddUsed.Cursor = System.Windows.Forms.Cursors.Help;
            this.crclrprgrsbrHddUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crclrprgrsbrHddUsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crclrprgrsbrHddUsed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclrprgrsbrHddUsed.InnerMargin = 2;
            this.crclrprgrsbrHddUsed.InnerWidth = -1;
            this.crclrprgrsbrHddUsed.Location = new System.Drawing.Point(1039, 463);
            this.crclrprgrsbrHddUsed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crclrprgrsbrHddUsed.MarqueeAnimationSpeed = 2000;
            this.crclrprgrsbrHddUsed.Name = "crclrprgrsbrHddUsed";
            this.crclrprgrsbrHddUsed.OuterColor = System.Drawing.Color.Gray;
            this.crclrprgrsbrHddUsed.OuterMargin = -10;
            this.crclrprgrsbrHddUsed.OuterWidth = 10;
            this.crclrprgrsbrHddUsed.ProgressColor = System.Drawing.Color.BlueViolet;
            this.crclrprgrsbrHddUsed.ProgressWidth = 10;
            this.crclrprgrsbrHddUsed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclrprgrsbrHddUsed.Size = new System.Drawing.Size(100, 92);
            this.crclrprgrsbrHddUsed.StartAngle = 270;
            this.crclrprgrsbrHddUsed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.crclrprgrsbrHddUsed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclrprgrsbrHddUsed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclrprgrsbrHddUsed.SubscriptText = "";
            this.crclrprgrsbrHddUsed.SuperscriptColor = System.Drawing.Color.Red;
            this.crclrprgrsbrHddUsed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclrprgrsbrHddUsed.SuperscriptText = "";
            this.crclrprgrsbrHddUsed.TabIndex = 72;
            this.crclrprgrsbrHddUsed.Text = "N/D%";
            this.crclrprgrsbrHddUsed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crclrprgrsbrHddUsed.Value = 68;
            this.crclrprgrsbrHddUsed.Click += new System.EventHandler(this.crclrprgrsbrHddUsed_Click);
            // 
            // lblhddfree
            // 
            this.lblhddfree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhddfree.AutoSize = true;
            this.lblhddfree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddfree.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblhddfree.Location = new System.Drawing.Point(821, 537);
            this.lblhddfree.Name = "lblhddfree";
            this.lblhddfree.Size = new System.Drawing.Size(52, 25);
            this.lblhddfree.TabIndex = 73;
            this.lblhddfree.Text = "Free";
            // 
            // btnINFORAM
            // 
            this.btnINFORAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnINFORAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFORAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFORAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnINFORAM.Location = new System.Drawing.Point(364, 421);
            this.btnINFORAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINFORAM.Name = "btnINFORAM";
            this.btnINFORAM.Size = new System.Drawing.Size(67, 31);
            this.btnINFORAM.TabIndex = 74;
            this.btnINFORAM.Text = "INFO";
            this.btnINFORAM.UseVisualStyleBackColor = false;
            this.btnINFORAM.Click += new System.EventHandler(this.btnINFORAM_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSystemName.Location = new System.Drawing.Point(12, 48);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(158, 29);
            this.lblSystemName.TabIndex = 75;
            this.lblSystemName.Text = "System name";
            // 
            // helpCpuTemp
            // 
            this.helpCpuTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpCpuTemp.Location = new System.Drawing.Point(213, 270);
            this.helpCpuTemp.Margin = new System.Windows.Forms.Padding(4);
            this.helpCpuTemp.Name = "helpCpuTemp";
            this.helpCpuTemp.Size = new System.Drawing.Size(35, 34);
            this.helpCpuTemp.TabIndex = 77;
            this.helpCpuTemp.UseVisualStyleBackColor = false;
            this.helpCpuTemp.Click += new System.EventHandler(this.helpCpuTemp_Click);
            // 
            // helpHddActivity
            // 
            this.helpHddActivity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpHddActivity.Location = new System.Drawing.Point(781, 460);
            this.helpHddActivity.Margin = new System.Windows.Forms.Padding(4);
            this.helpHddActivity.Name = "helpHddActivity";
            this.helpHddActivity.Size = new System.Drawing.Size(35, 34);
            this.helpHddActivity.TabIndex = 83;
            this.helpHddActivity.UseVisualStyleBackColor = false;
            // 
            // lblGPUTEMP
            // 
            this.lblGPUTEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGPUTEMP.AutoSize = true;
            this.lblGPUTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUTEMP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGPUTEMP.Location = new System.Drawing.Point(821, 251);
            this.lblGPUTEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUTEMP.Name = "lblGPUTEMP";
            this.lblGPUTEMP.Size = new System.Drawing.Size(153, 29);
            this.lblGPUTEMP.TabIndex = 84;
            this.lblGPUTEMP.Text = "Temperature";
            // 
            // lblGpuVram
            // 
            this.lblGpuVram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGpuVram.AutoSize = true;
            this.lblGpuVram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpuVram.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGpuVram.Location = new System.Drawing.Point(821, 222);
            this.lblGpuVram.Name = "lblGpuVram";
            this.lblGpuVram.Size = new System.Drawing.Size(80, 29);
            this.lblGpuVram.TabIndex = 86;
            this.lblGpuVram.Text = "VRAM";
            // 
            // helpGpuTemp
            // 
            this.helpGpuTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpGpuTemp.Location = new System.Drawing.Point(781, 251);
            this.helpGpuTemp.Margin = new System.Windows.Forms.Padding(4);
            this.helpGpuTemp.Name = "helpGpuTemp";
            this.helpGpuTemp.Size = new System.Drawing.Size(35, 34);
            this.helpGpuTemp.TabIndex = 87;
            this.helpGpuTemp.UseVisualStyleBackColor = false;
            this.helpGpuTemp.Click += new System.EventHandler(this.helpGpuTemp_Click);
            // 
            // lblCPUTEMP
            // 
            this.lblCPUTEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPUTEMP.AutoSize = true;
            this.lblCPUTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUTEMP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCPUTEMP.Location = new System.Drawing.Point(255, 272);
            this.lblCPUTEMP.Name = "lblCPUTEMP";
            this.lblCPUTEMP.Size = new System.Drawing.Size(176, 32);
            this.lblCPUTEMP.TabIndex = 88;
            this.lblCPUTEMP.Text = "Temperature";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.lblCPUTEMP);
            this.Controls.Add(this.helpGpuTemp);
            this.Controls.Add(this.lblGpuVram);
            this.Controls.Add(this.lblGPUTEMP);
            this.Controls.Add(this.helpHddActivity);
            this.Controls.Add(this.helpCpuTemp);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.btnINFORAM);
            this.Controls.Add(this.lblhddfree);
            this.Controls.Add(this.crclrprgrsbrHddUsed);
            this.Controls.Add(this.lblhddtotal);
            this.Controls.Add(this.lblgpumodel);
            this.Controls.Add(this.btnINFOHDD);
            this.Controls.Add(this.btnINFOGPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.helpCpu);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Viewer - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button helpCpu;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Button btnINFOGPU;
        private System.Windows.Forms.Button btnINFOHDD;
        private System.Windows.Forms.Label lblgpumodel;
        private System.Windows.Forms.Label lblhddtotal;
        private CircularProgressBar.CircularProgressBar crclrprgrsbrHddUsed;
        private System.Windows.Forms.Label lblhddfree;
        private System.Windows.Forms.Button btnINFORAM;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button helpCpuTemp;
        private System.Windows.Forms.Button helpHddActivity;
        private System.Windows.Forms.Label lblGPUTEMP;
        private System.Windows.Forms.Label lblGpuVram;
        private System.Windows.Forms.Button helpGpuTemp;
        private System.Windows.Forms.Label lblCPUTEMP;
    }
}