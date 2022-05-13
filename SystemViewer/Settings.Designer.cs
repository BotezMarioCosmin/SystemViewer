namespace SystemViewer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblA5 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.panelCPU = new System.Windows.Forms.Panel();
            this.textBoxTempCpu = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbtnPercentageCpu = new System.Windows.Forms.RadioButton();
            this.rdbtnDefaultCPU = new System.Windows.Forms.RadioButton();
            this.lblPieChartCPU = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.lblWarningWhenCPU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.btnThemeDefault = new System.Windows.Forms.Button();
            this.btnTheme3 = new System.Windows.Forms.Button();
            this.btnTheme2 = new System.Windows.Forms.Button();
            this.btnTheme1 = new System.Windows.Forms.Button();
            this.lblApptheme = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbtnFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdbtnCelsius = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbtnita = new System.Windows.Forms.RadioButton();
            this.rdbtneng = new System.Windows.Forms.RadioButton();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGPU = new System.Windows.Forms.Panel();
            this.textBoxTempGpu = new System.Windows.Forms.TextBox();
            this.lblSetTempGPU = new System.Windows.Forms.Label();
            this.lblWarningWhenGPU = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGPU = new System.Windows.Forms.TextBox();
            this.panelRAM = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdbtnPercentageRAM = new System.Windows.Forms.RadioButton();
            this.rdbtnDefaultRAM = new System.Windows.Forms.RadioButton();
            this.lblPieChartRAM = new System.Windows.Forms.Label();
            this.panelHDD = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdbtnPercentageHDD = new System.Windows.Forms.RadioButton();
            this.rdbtnDefaultHDD = new System.Windows.Forms.RadioButton();
            this.lblPieChartHDD = new System.Windows.Forms.Label();
            this.btnNoGPU = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCPU.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSystem.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGPU.SuspendLayout();
            this.panelRAM.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelHDD.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.informationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1312, 36);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.homeToolStripMenuItem.Image = global::SystemViewer.Properties.Resources.home;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblA5);
            this.panel1.Controls.Add(this.lblA4);
            this.panel1.Controls.Add(this.lblA3);
            this.panel1.Controls.Add(this.lblA2);
            this.panel1.Controls.Add(this.lblA1);
            this.panel1.Controls.Add(this.lblHDD);
            this.panel1.Controls.Add(this.lblRAM);
            this.panel1.Controls.Add(this.lblGPU);
            this.panel1.Controls.Add(this.lblSystem);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 252);
            this.panel1.TabIndex = 59;
            // 
            // lblA5
            // 
            this.lblA5.AutoSize = true;
            this.lblA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblA5.Location = new System.Drawing.Point(131, 194);
            this.lblA5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA5.Name = "lblA5";
            this.lblA5.Size = new System.Drawing.Size(27, 29);
            this.lblA5.TabIndex = 105;
            this.lblA5.Text = ">";
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblA4.Location = new System.Drawing.Point(131, 150);
            this.lblA4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(27, 29);
            this.lblA4.TabIndex = 104;
            this.lblA4.Text = ">";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblA3.Location = new System.Drawing.Point(131, 103);
            this.lblA3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(27, 29);
            this.lblA3.TabIndex = 103;
            this.lblA3.Text = ">";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblA2.Location = new System.Drawing.Point(131, 60);
            this.lblA2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(27, 29);
            this.lblA2.TabIndex = 102;
            this.lblA2.Text = ">";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblA1.Location = new System.Drawing.Point(131, 17);
            this.lblA1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(27, 29);
            this.lblA1.TabIndex = 101;
            this.lblA1.Text = ">";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHDD.Location = new System.Drawing.Point(19, 194);
            this.lblHDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(64, 29);
            this.lblHDD.TabIndex = 91;
            this.lblHDD.Text = "HDD";
            this.lblHDD.Click += new System.EventHandler(this.lblHDD_Click);
            this.lblHDD.MouseEnter += new System.EventHandler(this.lblHDD_MouseEnter);
            this.lblHDD.MouseLeave += new System.EventHandler(this.lblHDD_MouseLeave);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRAM.Location = new System.Drawing.Point(19, 150);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(65, 29);
            this.lblRAM.TabIndex = 90;
            this.lblRAM.Text = "RAM";
            this.lblRAM.Click += new System.EventHandler(this.lblRAM_Click);
            this.lblRAM.MouseEnter += new System.EventHandler(this.lblRAM_MouseEnter);
            this.lblRAM.MouseLeave += new System.EventHandler(this.lblRAM_MouseLeave);
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGPU.Location = new System.Drawing.Point(19, 105);
            this.lblGPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(64, 29);
            this.lblGPU.TabIndex = 89;
            this.lblGPU.Text = "GPU";
            this.lblGPU.Click += new System.EventHandler(this.lblGPU_Click);
            this.lblGPU.MouseEnter += new System.EventHandler(this.lblGPU_MouseEnter);
            this.lblGPU.MouseLeave += new System.EventHandler(this.lblGPU_MouseLeave);
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSystem.Location = new System.Drawing.Point(19, 15);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(92, 29);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.Text = "System";
            this.lblSystem.Click += new System.EventHandler(this.lblSystem_Click);
            this.lblSystem.MouseEnter += new System.EventHandler(this.lblSystem_MouseEnter);
            this.lblSystem.MouseLeave += new System.EventHandler(this.lblSystem_MouseLeave);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCPU.Location = new System.Drawing.Point(19, 60);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(63, 29);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "CPU";
            this.lblCPU.Click += new System.EventHandler(this.lblCPU_Click);
            this.lblCPU.MouseEnter += new System.EventHandler(this.lblCPU_MouseEnter);
            this.lblCPU.MouseLeave += new System.EventHandler(this.lblCPU_MouseLeave);
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSettings.Location = new System.Drawing.Point(13, 55);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(164, 36);
            this.lblSettings.TabIndex = 60;
            this.lblSettings.Text = "SETTINGS";
            // 
            // panelCPU
            // 
            this.panelCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCPU.Controls.Add(this.textBoxTempCpu);
            this.panelCPU.Controls.Add(this.panel4);
            this.panelCPU.Controls.Add(this.lblPieChartCPU);
            this.panelCPU.Controls.Add(this.lblSet);
            this.panelCPU.Controls.Add(this.lblWarningWhenCPU);
            this.panelCPU.Controls.Add(this.button1);
            this.panelCPU.Controls.Add(this.textBoxCPU);
            this.panelCPU.Location = new System.Drawing.Point(283, 111);
            this.panelCPU.Margin = new System.Windows.Forms.Padding(4);
            this.panelCPU.Name = "panelCPU";
            this.panelCPU.Size = new System.Drawing.Size(983, 586);
            this.panelCPU.TabIndex = 87;
            // 
            // textBoxTempCpu
            // 
            this.textBoxTempCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempCpu.Location = new System.Drawing.Point(104, 78);
            this.textBoxTempCpu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTempCpu.Name = "textBoxTempCpu";
            this.textBoxTempCpu.Size = new System.Drawing.Size(91, 30);
            this.textBoxTempCpu.TabIndex = 95;
            this.textBoxTempCpu.Text = "70 °C";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbtnPercentageCpu);
            this.panel4.Controls.Add(this.rdbtnDefaultCPU);
            this.panel4.Location = new System.Drawing.Point(8, 165);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 69);
            this.panel4.TabIndex = 94;
            // 
            // rdbtnPercentageCpu
            // 
            this.rdbtnPercentageCpu.AutoSize = true;
            this.rdbtnPercentageCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPercentageCpu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnPercentageCpu.Location = new System.Drawing.Point(9, 32);
            this.rdbtnPercentageCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnPercentageCpu.Name = "rdbtnPercentageCpu";
            this.rdbtnPercentageCpu.Size = new System.Drawing.Size(133, 29);
            this.rdbtnPercentageCpu.TabIndex = 1;
            this.rdbtnPercentageCpu.TabStop = true;
            this.rdbtnPercentageCpu.Text = "Percentage";
            this.rdbtnPercentageCpu.UseVisualStyleBackColor = true;
            this.rdbtnPercentageCpu.CheckedChanged += new System.EventHandler(this.rdbtnPercentageCpu_CheckedChanged);
            // 
            // rdbtnDefaultCPU
            // 
            this.rdbtnDefaultCPU.AutoSize = true;
            this.rdbtnDefaultCPU.Checked = true;
            this.rdbtnDefaultCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDefaultCPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnDefaultCPU.Location = new System.Drawing.Point(9, 5);
            this.rdbtnDefaultCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnDefaultCPU.Name = "rdbtnDefaultCPU";
            this.rdbtnDefaultCPU.Size = new System.Drawing.Size(94, 29);
            this.rdbtnDefaultCPU.TabIndex = 0;
            this.rdbtnDefaultCPU.TabStop = true;
            this.rdbtnDefaultCPU.Text = "Default";
            this.rdbtnDefaultCPU.UseVisualStyleBackColor = true;
            // 
            // lblPieChartCPU
            // 
            this.lblPieChartCPU.AutoSize = true;
            this.lblPieChartCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieChartCPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPieChartCPU.Location = new System.Drawing.Point(3, 127);
            this.lblPieChartCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieChartCPU.Name = "lblPieChartCPU";
            this.lblPieChartCPU.Size = new System.Drawing.Size(141, 25);
            this.lblPieChartCPU.TabIndex = 92;
            this.lblPieChartCPU.Text = "Pie chart color:";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSet.Location = new System.Drawing.Point(3, 81);
            this.lblSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(48, 25);
            this.lblSet.TabIndex = 91;
            this.lblSet.Text = "Set:";
            // 
            // lblWarningWhenCPU
            // 
            this.lblWarningWhenCPU.AutoSize = true;
            this.lblWarningWhenCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningWhenCPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWarningWhenCPU.Location = new System.Drawing.Point(3, 4);
            this.lblWarningWhenCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningWhenCPU.Name = "lblWarningWhenCPU";
            this.lblWarningWhenCPU.Size = new System.Drawing.Size(470, 25);
            this.lblWarningWhenCPU.TabIndex = 88;
            this.lblWarningWhenCPU.Text = "Show warning when CPU temperature is higher than:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 30);
            this.button1.TabIndex = 90;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPU.Location = new System.Drawing.Point(8, 36);
            this.textBoxCPU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(132, 30);
            this.textBoxCPU.TabIndex = 89;
            // 
            // panelSystem
            // 
            this.panelSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSystem.Controls.Add(this.btnThemeDefault);
            this.panelSystem.Controls.Add(this.btnTheme3);
            this.panelSystem.Controls.Add(this.btnTheme2);
            this.panelSystem.Controls.Add(this.btnTheme1);
            this.panelSystem.Controls.Add(this.lblApptheme);
            this.panelSystem.Controls.Add(this.lblTemperature);
            this.panelSystem.Controls.Add(this.panel3);
            this.panelSystem.Controls.Add(this.panel2);
            this.panelSystem.Controls.Add(this.lblLanguage);
            this.panelSystem.Location = new System.Drawing.Point(343, 81);
            this.panelSystem.Margin = new System.Windows.Forms.Padding(4);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(969, 586);
            this.panelSystem.TabIndex = 88;
            this.panelSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSystem_Paint);
            // 
            // btnThemeDefault
            // 
            this.btnThemeDefault.Location = new System.Drawing.Point(131, 206);
            this.btnThemeDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemeDefault.Name = "btnThemeDefault";
            this.btnThemeDefault.Size = new System.Drawing.Size(100, 28);
            this.btnThemeDefault.TabIndex = 105;
            this.btnThemeDefault.Text = "Default";
            this.btnThemeDefault.UseVisualStyleBackColor = true;
            this.btnThemeDefault.Click += new System.EventHandler(this.btnThemeDefault_Click);
            // 
            // btnTheme3
            // 
            this.btnTheme3.Location = new System.Drawing.Point(455, 206);
            this.btnTheme3.Margin = new System.Windows.Forms.Padding(4);
            this.btnTheme3.Name = "btnTheme3";
            this.btnTheme3.Size = new System.Drawing.Size(100, 28);
            this.btnTheme3.TabIndex = 104;
            this.btnTheme3.Text = "Theme 3";
            this.btnTheme3.UseVisualStyleBackColor = true;
            this.btnTheme3.Click += new System.EventHandler(this.btnTheme3_Click);
            // 
            // btnTheme2
            // 
            this.btnTheme2.Location = new System.Drawing.Point(347, 206);
            this.btnTheme2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTheme2.Name = "btnTheme2";
            this.btnTheme2.Size = new System.Drawing.Size(100, 28);
            this.btnTheme2.TabIndex = 103;
            this.btnTheme2.Text = "Theme 2";
            this.btnTheme2.UseVisualStyleBackColor = true;
            this.btnTheme2.Click += new System.EventHandler(this.btnTheme2_Click);
            // 
            // btnTheme1
            // 
            this.btnTheme1.Location = new System.Drawing.Point(239, 206);
            this.btnTheme1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTheme1.Name = "btnTheme1";
            this.btnTheme1.Size = new System.Drawing.Size(100, 28);
            this.btnTheme1.TabIndex = 102;
            this.btnTheme1.Text = "Theme 1";
            this.btnTheme1.UseVisualStyleBackColor = true;
            this.btnTheme1.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // lblApptheme
            // 
            this.lblApptheme.AutoSize = true;
            this.lblApptheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptheme.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblApptheme.Location = new System.Drawing.Point(1, 206);
            this.lblApptheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptheme.Name = "lblApptheme";
            this.lblApptheme.Size = new System.Drawing.Size(113, 25);
            this.lblApptheme.TabIndex = 101;
            this.lblApptheme.Text = "App theme:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTemperature.Location = new System.Drawing.Point(1, 97);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(130, 25);
            this.lblTemperature.TabIndex = 99;
            this.lblTemperature.Text = "Temperature:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.rdbtnFahrenheit);
            this.panel3.Controls.Add(this.rdbtnCelsius);
            this.panel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(147, 97);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 62);
            this.panel3.TabIndex = 97;
            // 
            // rdbtnFahrenheit
            // 
            this.rdbtnFahrenheit.AutoSize = true;
            this.rdbtnFahrenheit.Location = new System.Drawing.Point(3, 31);
            this.rdbtnFahrenheit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnFahrenheit.Name = "rdbtnFahrenheit";
            this.rdbtnFahrenheit.Size = new System.Drawing.Size(109, 20);
            this.rdbtnFahrenheit.TabIndex = 1;
            this.rdbtnFahrenheit.Text = "Fahrenheit - F";
            this.rdbtnFahrenheit.UseVisualStyleBackColor = true;
            this.rdbtnFahrenheit.CheckedChanged += new System.EventHandler(this.rdbtnFahrenheit_CheckedChanged);
            // 
            // rdbtnCelsius
            // 
            this.rdbtnCelsius.AutoSize = true;
            this.rdbtnCelsius.Checked = true;
            this.rdbtnCelsius.Location = new System.Drawing.Point(3, 4);
            this.rdbtnCelsius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnCelsius.Name = "rdbtnCelsius";
            this.rdbtnCelsius.Size = new System.Drawing.Size(91, 20);
            this.rdbtnCelsius.TabIndex = 0;
            this.rdbtnCelsius.TabStop = true;
            this.rdbtnCelsius.Text = "Celsius - C";
            this.rdbtnCelsius.UseVisualStyleBackColor = true;
            this.rdbtnCelsius.CheckedChanged += new System.EventHandler(this.rdbtnCelsius_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rdbtnita);
            this.panel2.Controls.Add(this.rdbtneng);
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(121, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 59);
            this.panel2.TabIndex = 96;
            // 
            // rdbtnita
            // 
            this.rdbtnita.AutoSize = true;
            this.rdbtnita.Location = new System.Drawing.Point(4, 31);
            this.rdbtnita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnita.Name = "rdbtnita";
            this.rdbtnita.Size = new System.Drawing.Size(71, 20);
            this.rdbtnita.TabIndex = 47;
            this.rdbtnita.TabStop = true;
            this.rdbtnita.Text = "Italiano";
            this.rdbtnita.UseVisualStyleBackColor = true;
            this.rdbtnita.CheckedChanged += new System.EventHandler(this.rdbtnita_CheckedChanged);
            this.rdbtnita.Click += new System.EventHandler(this.rdbtnita_Click);
            // 
            // rdbtneng
            // 
            this.rdbtneng.AutoSize = true;
            this.rdbtneng.Checked = true;
            this.rdbtneng.Location = new System.Drawing.Point(4, 6);
            this.rdbtneng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtneng.Name = "rdbtneng";
            this.rdbtneng.Size = new System.Drawing.Size(72, 20);
            this.rdbtneng.TabIndex = 46;
            this.rdbtneng.TabStop = true;
            this.rdbtneng.Text = "English";
            this.rdbtneng.UseVisualStyleBackColor = true;
            this.rdbtneng.Click += new System.EventHandler(this.rdbtneng_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLanguage.Location = new System.Drawing.Point(1, 1);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(106, 25);
            this.lblLanguage.TabIndex = 95;
            this.lblLanguage.Text = "Language:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelGPU
            // 
            this.panelGPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGPU.Controls.Add(this.textBoxTempGpu);
            this.panelGPU.Controls.Add(this.btnNoGPU);
            this.panelGPU.Controls.Add(this.lblSetTempGPU);
            this.panelGPU.Controls.Add(this.lblWarningWhenGPU);
            this.panelGPU.Controls.Add(this.button2);
            this.panelGPU.Controls.Add(this.textBoxGPU);
            this.panelGPU.Location = new System.Drawing.Point(225, 144);
            this.panelGPU.Margin = new System.Windows.Forms.Padding(4);
            this.panelGPU.Name = "panelGPU";
            this.panelGPU.Size = new System.Drawing.Size(983, 586);
            this.panelGPU.TabIndex = 99;
            // 
            // textBoxTempGpu
            // 
            this.textBoxTempGpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempGpu.Location = new System.Drawing.Point(105, 79);
            this.textBoxTempGpu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTempGpu.Name = "textBoxTempGpu";
            this.textBoxTempGpu.Size = new System.Drawing.Size(91, 30);
            this.textBoxTempGpu.TabIndex = 96;
            this.textBoxTempGpu.Text = "70 °C";
            // 
            // lblSetTempGPU
            // 
            this.lblSetTempGPU.AutoSize = true;
            this.lblSetTempGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTempGPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSetTempGPU.Location = new System.Drawing.Point(4, 82);
            this.lblSetTempGPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetTempGPU.Name = "lblSetTempGPU";
            this.lblSetTempGPU.Size = new System.Drawing.Size(48, 25);
            this.lblSetTempGPU.TabIndex = 91;
            this.lblSetTempGPU.Text = "Set:";
            // 
            // lblWarningWhenGPU
            // 
            this.lblWarningWhenGPU.AutoSize = true;
            this.lblWarningWhenGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningWhenGPU.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWarningWhenGPU.Location = new System.Drawing.Point(4, 5);
            this.lblWarningWhenGPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningWhenGPU.Name = "lblWarningWhenGPU";
            this.lblWarningWhenGPU.Size = new System.Drawing.Size(470, 25);
            this.lblWarningWhenGPU.TabIndex = 88;
            this.lblWarningWhenGPU.Text = "Show warning when GPU temperature is higher than:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 30);
            this.button2.TabIndex = 90;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxGPU
            // 
            this.textBoxGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGPU.Location = new System.Drawing.Point(9, 37);
            this.textBoxGPU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGPU.Name = "textBoxGPU";
            this.textBoxGPU.Size = new System.Drawing.Size(132, 30);
            this.textBoxGPU.TabIndex = 89;
            // 
            // panelRAM
            // 
            this.panelRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRAM.Controls.Add(this.panel7);
            this.panelRAM.Controls.Add(this.lblPieChartRAM);
            this.panelRAM.Location = new System.Drawing.Point(211, 162);
            this.panelRAM.Margin = new System.Windows.Forms.Padding(4);
            this.panelRAM.Name = "panelRAM";
            this.panelRAM.Size = new System.Drawing.Size(983, 586);
            this.panelRAM.TabIndex = 100;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rdbtnPercentageRAM);
            this.panel7.Controls.Add(this.rdbtnDefaultRAM);
            this.panel7.Location = new System.Drawing.Point(5, 41);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 66);
            this.panel7.TabIndex = 94;
            // 
            // rdbtnPercentageRAM
            // 
            this.rdbtnPercentageRAM.AutoSize = true;
            this.rdbtnPercentageRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPercentageRAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnPercentageRAM.Location = new System.Drawing.Point(9, 32);
            this.rdbtnPercentageRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnPercentageRAM.Name = "rdbtnPercentageRAM";
            this.rdbtnPercentageRAM.Size = new System.Drawing.Size(133, 29);
            this.rdbtnPercentageRAM.TabIndex = 1;
            this.rdbtnPercentageRAM.TabStop = true;
            this.rdbtnPercentageRAM.Text = "Percentage";
            this.rdbtnPercentageRAM.UseVisualStyleBackColor = true;
            // 
            // rdbtnDefaultRAM
            // 
            this.rdbtnDefaultRAM.AutoSize = true;
            this.rdbtnDefaultRAM.Checked = true;
            this.rdbtnDefaultRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDefaultRAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnDefaultRAM.Location = new System.Drawing.Point(9, 5);
            this.rdbtnDefaultRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnDefaultRAM.Name = "rdbtnDefaultRAM";
            this.rdbtnDefaultRAM.Size = new System.Drawing.Size(94, 29);
            this.rdbtnDefaultRAM.TabIndex = 0;
            this.rdbtnDefaultRAM.TabStop = true;
            this.rdbtnDefaultRAM.Text = "Default";
            this.rdbtnDefaultRAM.UseVisualStyleBackColor = true;
            // 
            // lblPieChartRAM
            // 
            this.lblPieChartRAM.AutoSize = true;
            this.lblPieChartRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieChartRAM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPieChartRAM.Location = new System.Drawing.Point(1, 2);
            this.lblPieChartRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieChartRAM.Name = "lblPieChartRAM";
            this.lblPieChartRAM.Size = new System.Drawing.Size(141, 25);
            this.lblPieChartRAM.TabIndex = 92;
            this.lblPieChartRAM.Text = "Pie chart color:";
            // 
            // panelHDD
            // 
            this.panelHDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHDD.Controls.Add(this.panel8);
            this.panelHDD.Controls.Add(this.lblPieChartHDD);
            this.panelHDD.Location = new System.Drawing.Point(191, 177);
            this.panelHDD.Margin = new System.Windows.Forms.Padding(4);
            this.panelHDD.Name = "panelHDD";
            this.panelHDD.Size = new System.Drawing.Size(983, 586);
            this.panelHDD.TabIndex = 100;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rdbtnPercentageHDD);
            this.panel8.Controls.Add(this.rdbtnDefaultHDD);
            this.panel8.Location = new System.Drawing.Point(9, 42);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 65);
            this.panel8.TabIndex = 94;
            // 
            // rdbtnPercentageHDD
            // 
            this.rdbtnPercentageHDD.AutoSize = true;
            this.rdbtnPercentageHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPercentageHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnPercentageHDD.Location = new System.Drawing.Point(9, 32);
            this.rdbtnPercentageHDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnPercentageHDD.Name = "rdbtnPercentageHDD";
            this.rdbtnPercentageHDD.Size = new System.Drawing.Size(133, 29);
            this.rdbtnPercentageHDD.TabIndex = 1;
            this.rdbtnPercentageHDD.TabStop = true;
            this.rdbtnPercentageHDD.Text = "Percentage";
            this.rdbtnPercentageHDD.UseVisualStyleBackColor = true;
            // 
            // rdbtnDefaultHDD
            // 
            this.rdbtnDefaultHDD.AutoSize = true;
            this.rdbtnDefaultHDD.Checked = true;
            this.rdbtnDefaultHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDefaultHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdbtnDefaultHDD.Location = new System.Drawing.Point(9, 5);
            this.rdbtnDefaultHDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnDefaultHDD.Name = "rdbtnDefaultHDD";
            this.rdbtnDefaultHDD.Size = new System.Drawing.Size(94, 29);
            this.rdbtnDefaultHDD.TabIndex = 0;
            this.rdbtnDefaultHDD.TabStop = true;
            this.rdbtnDefaultHDD.Text = "Default";
            this.rdbtnDefaultHDD.UseVisualStyleBackColor = true;
            // 
            // lblPieChartHDD
            // 
            this.lblPieChartHDD.AutoSize = true;
            this.lblPieChartHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieChartHDD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPieChartHDD.Location = new System.Drawing.Point(4, 4);
            this.lblPieChartHDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieChartHDD.Name = "lblPieChartHDD";
            this.lblPieChartHDD.Size = new System.Drawing.Size(141, 25);
            this.lblPieChartHDD.TabIndex = 92;
            this.lblPieChartHDD.Text = "Pie chart color:";
            // 
            // btnNoGPU
            // 
            this.btnNoGPU.BackColor = System.Drawing.Color.Transparent;
            this.btnNoGPU.Location = new System.Drawing.Point(209, 34);
            this.btnNoGPU.Name = "btnNoGPU";
            this.btnNoGPU.Size = new System.Drawing.Size(76, 75);
            this.btnNoGPU.TabIndex = 101;
            this.btnNoGPU.UseVisualStyleBackColor = true;
            this.btnNoGPU.Click += new System.EventHandler(this.btnNoGPU_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.panelGPU);
            this.Controls.Add(this.panelHDD);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSystem);
            this.Controls.Add(this.panelCPU);
            this.Controls.Add(this.panelRAM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "System Viewer > Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCPU.ResumeLayout(false);
            this.panelCPU.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelSystem.ResumeLayout(false);
            this.panelSystem.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGPU.ResumeLayout(false);
            this.panelGPU.PerformLayout();
            this.panelRAM.ResumeLayout(false);
            this.panelRAM.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelHDD.ResumeLayout(false);
            this.panelHDD.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Panel panelCPU;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Label lblWarningWhenCPU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtnita;
        private System.Windows.Forms.RadioButton rdbtneng;
        private System.Windows.Forms.Button btnTheme1;
        private System.Windows.Forms.Label lblApptheme;
        private System.Windows.Forms.Button btnTheme3;
        private System.Windows.Forms.Button btnTheme2;
        private System.Windows.Forms.Button btnThemeDefault;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPieChartCPU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbtnPercentageCpu;
        private System.Windows.Forms.RadioButton rdbtnDefaultCPU;
        private System.Windows.Forms.Panel panelGPU;
        private System.Windows.Forms.Label lblSetTempGPU;
        private System.Windows.Forms.Label lblWarningWhenGPU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxGPU;
        private System.Windows.Forms.Panel panelRAM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdbtnPercentageRAM;
        private System.Windows.Forms.RadioButton rdbtnDefaultRAM;
        private System.Windows.Forms.Label lblPieChartRAM;
        private System.Windows.Forms.Panel panelHDD;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rdbtnPercentageHDD;
        private System.Windows.Forms.RadioButton rdbtnDefaultHDD;
        private System.Windows.Forms.Label lblPieChartHDD;
        private System.Windows.Forms.Label lblA5;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbtnFahrenheit;
        private System.Windows.Forms.RadioButton rdbtnCelsius;
        private System.Windows.Forms.TextBox textBoxTempCpu;
        private System.Windows.Forms.TextBox textBoxTempGpu;
        private System.Windows.Forms.Button btnNoGPU;
    }
}