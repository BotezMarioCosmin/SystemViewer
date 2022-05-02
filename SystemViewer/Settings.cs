using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemViewer
{
    public partial class Settings : Form
    {
        public static bool Celsius = true;
        public static int Language = 0; // 0 - English; 1 - Italiano;
        public static float temperaturamaxCPU = 70, temperaturamaxCPUf = 158;
        public static float temperaturamaxGPU = 70, temperaturamaxGPUf = 158;
        public static int CpuColor = 0, RamColor = 0, HddColor = 0;
        string[] enSettings = { "Home", "Informations", "SETTINGS", "System", "Set", "Pie chart color", "Language", "Temperature", "App theme", "Default", "Percentage", "Custom" };
        string[] itSettings = { "Home", "Informazioni", "IMPOSTAZIONI", "Sistema", "Impostato", "Colore grafico a torta", "Lingua", "Temperatura", "Tema app", "Predefinito", "Percentuale", "Personalizzato" };
        public static int FormColor;

        public Settings()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Size = this.Size;
            this.Location = this.Location;
            this.Show();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            hideAll();
            timer1.Start();

            if (Home.cpuclick == true)//progressbarclick
            {
                lblCPU_Click(sender, e);
            }
            
            if (Home.ramclick == true)//progressbarclick
            {
                lblRAM_Click(sender, e);
            }

            if (Home.hddclick == true)//progressbarclick
            {
                lblHDD_Click(sender, e);
            }


            if (Language == 1)//lingua precedentemente assegnata
            {
                rdbtneng.Checked = false;
                rdbtnita.Checked = true;
            }
            else if (Language == 0)
            {
                rdbtneng.Checked = true;
                rdbtnita.Checked = false;
            }

            if (Celsius == true)
            {
                rdbtnCelsius.Checked = true;
            }
            else if (Celsius == false)
            {
                rdbtnFahrenheit.Checked = true;
            }

            if (CpuColor == 1)
            {
                rdbtnPercentageCpu.Checked = true;
                rdbtnDefaultCPU.Checked = false;
            }

            if (RamColor == 1)
            {
                rdbtnPercentageRAM.Checked = true;
                rdbtnDefaultRAM.Checked = false;
            }

            if (HddColor == 1)
            {
                rdbtnPercentageHDD.Checked = true;
                rdbtnDefaultHDD.Checked = false;
            }

            if (FormColor == 0) // carica tema default
            {
                btnThemeDefault_Click(sender, e);
            }
            else if (FormColor == 1) // carica tema 1
            {
                btnTheme_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Lingua

            if (Language == 1)
            {
                informationsToolStripMenuItem.Text = systemLanguage(enSettings, itSettings, 1);
                lblSettings.Text = systemLanguage(enSettings, itSettings, 2);
                lblSystem.Text = systemLanguage(enSettings, itSettings, 3);
                lblLanguage.Text = systemLanguage(enSettings, itSettings, 6);
                lblTemperature.Text = systemLanguage(enSettings, itSettings, 7);
                lblApptheme.Text = systemLanguage(enSettings, itSettings, 8);
            }
            else
            {
                informationsToolStripMenuItem.Text = systemLanguage(enSettings, itSettings, 1);
                lblSettings.Text = systemLanguage(enSettings, itSettings, 2);
                lblSystem.Text = systemLanguage(enSettings, itSettings, 3);
                lblLanguage.Text = systemLanguage(enSettings, itSettings, 6);
                lblTemperature.Text = systemLanguage(enSettings, itSettings, 7);
                lblApptheme.Text = systemLanguage(enSettings, itSettings, 8);
            }

            //CPU grafico a torta colore
            if (rdbtnDefaultCPU.Checked == false)
            {
                CpuColor = 1;
            }
            else if (rdbtnDefaultCPU.Checked == true)
            {
                CpuColor = 0;
            }
            //RAM
            if (rdbtnDefaultRAM.Checked == false)
            {
                RamColor = 1;
            }
            else if (rdbtnDefaultRAM.Checked == true)
            {
                RamColor = 0;
            }
            //HDD
            if (rdbtnDefaultHDD.Checked == false)
            {
                HddColor = 1;
            }
            else if (rdbtnDefaultHDD.Checked == true)
            {
                HddColor = 0;
            }


            //Celsius & Fahrenheit
            if (rdbtnCelsius.Checked == false)
            {
                Celsius = false;
            }
            else if (rdbtnCelsius.Checked == true)
            {
                Celsius = true;
            }

            if (Celsius == true)
            {
                textBoxTempCpu.Text = temperaturamaxCPU + boolCelsius(Celsius);
                textBoxTempGpu.Text = temperaturamaxGPU + boolCelsius(Celsius);
            }
            else if (Celsius == false)
            {
                textBoxTempGpu.Text = temperaturamaxGPUf + boolCelsius(Celsius);
                textBoxTempCpu.Text = temperaturamaxCPUf + boolCelsius(Celsius);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Celsius == true)
            {
                try
                {
                    Convert.ToInt32(textBoxCPU.Text);
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                    textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                if (Convert.ToInt32(textBoxCPU.Text) < 0 || Convert.ToInt32(textBoxCPU.Text) > 100)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                    textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                try
                {
                    temperaturamaxCPU = Convert.ToInt32(textBoxCPU.Text);
                    textBoxTempCpu.Text = temperaturamaxCPU + " °C";
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                }

                textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente

                if (temperaturamaxCPU >= 0 || temperaturamaxCPU <= 100)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Warning will be shown when temperature is higher than " + temperaturamaxCPU + " °C", "Max temp");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Un'avvertenza verrà mostrata quando la temperatura è maggiore di " + temperaturamaxCPU + " °C", "Max temp");
                    }
                }
            }
            else if (Celsius == false)
            {
                try
                {
                    Convert.ToInt32(textBoxCPU.Text);
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                    textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                if (Convert.ToInt32(textBoxCPU.Text) < 32 || Convert.ToInt32(textBoxCPU.Text) > 212)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                    textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                try
                {
                    temperaturamaxCPUf = Convert.ToInt32(textBoxCPU.Text);
                    textBoxTempCpu.Text = temperaturamaxCPUf + " °F";
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                }

                textBoxCPU.Text = "";//cancella visivamente la temperatura inserita precedentemente

                if (temperaturamaxCPUf >= 32 || temperaturamaxCPUf <= 212)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Warning will be shown when temperature is higher than " + temperaturamaxCPUf + " °F", "Max temp");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Un'avvertenza verrà mostrata quando la temperatura è maggiore di " + temperaturamaxCPUf + " °F", "Max temp");
                    }
                }
            }



        }

        public void hideAll()//nasconde pannelli
        {
            panelSystem.Hide();
            panelCPU.Hide();
            panelGPU.Hide();
            panelRAM.Hide();
            panelHDD.Hide();
            lblA1.Hide();
            lblA2.Hide();
            lblA3.Hide();
            lblA4.Hide();
            lblA5.Hide();
        }


        public static string systemLanguage(string[] eng, string[] ita, int n) // lingua di sistema
        {
            if (Language == 1)
            {
                return ita[n];
            }
            return eng[n];
        }

        private void rdbtnCustom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbtnita_Click(object sender, EventArgs e)
        {
            Language = 1;
            rdbtnita.Checked = true;
            rdbtneng.Checked = false;
            lblPieChartCPU.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            lblPieChartRAM.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            lblPieChartHDD.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            rdbtnDefaultCPU.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageCpu.Text = systemLanguage(enSettings, itSettings, 10);
            rdbtnDefaultRAM.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageRAM.Text = systemLanguage(enSettings, itSettings, 10);
            rdbtnDefaultHDD.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageHDD.Text = systemLanguage(enSettings, itSettings, 10);
            lblWarningWhenCPU.Text = "Mostra un'avvertenza quando la temperatura della CPU è più alta di:";
            lblWarningWhenGPU.Text = "Mostra un'avvertenza quando la temperatura della GPU è più alta di:";
            lblSet.Text = systemLanguage(enSettings, itSettings, 4) + ":";
            lblSetTempGPU.Text = systemLanguage(enSettings, itSettings, 4) + ":";
        }

        private void rdbtneng_Click(object sender, EventArgs e)
        {
            Language = 0;
            rdbtneng.Checked = true;
            rdbtnita.Checked = false;
            lblPieChartCPU.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            lblPieChartRAM.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            lblPieChartHDD.Text = systemLanguage(enSettings, itSettings, 5) + ":";
            rdbtnDefaultCPU.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageCpu.Text = systemLanguage(enSettings, itSettings, 10);
            rdbtnDefaultRAM.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageRAM.Text = systemLanguage(enSettings, itSettings, 10);
            rdbtnDefaultHDD.Text = systemLanguage(enSettings, itSettings, 9);
            rdbtnPercentageHDD.Text = systemLanguage(enSettings, itSettings, 10);
            lblWarningWhenCPU.Text = "Show warning when CPU temperature is higher than:";
            lblWarningWhenGPU.Text = "Show warning when GPU temperature is higher than:";
            lblSet.Text = systemLanguage(enSettings, itSettings, 4) + ":";
            lblSetTempGPU.Text = systemLanguage(enSettings, itSettings, 4) + ":";
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations Informations = new Informations();
            Informations.Show();
            Informations.Left = this.Left;
            Informations.Top = this.Top;
            Informations.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }

        private void rdbtnita_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void rdbtnFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static string boolCelsius(bool C)
        {
            if (C == false)
            {
                return " °F";
            }
            return " °C";
        }

        public static float tempConverted(float t, bool c)
        {
            if (c == false)
            {
                t = t * (9 / 5) + 32;
                return t;
            }
            else if (c == true)
            {
                t = (t - 32) * 5 / 9;
                return t;
            }
                return t;
        }


        private void btnTheme2_Click(object sender, EventArgs e)
        {
            FormColor = 2;
        }

        private void btnTheme3_Click(object sender, EventArgs e)
        {
            FormColor = 3;
        }

        private void rdbtnCelsius_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbtnPercentageCpu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelSystem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Celsius == true)
            {
                try
                {
                    Convert.ToInt32(textBoxGPU.Text);
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                    textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                if (Convert.ToInt32(textBoxGPU.Text) < 0 || Convert.ToInt32(textBoxGPU.Text) > 100)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                    textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                try
                {
                    temperaturamaxGPU = Convert.ToInt32(textBoxGPU.Text);
                    textBoxTempGpu.Text = temperaturamaxGPU + " °C";
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 0 to 100");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 0 a 100");
                    }
                }

                textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente

                if (temperaturamaxGPU >= 0 || temperaturamaxGPU <= 100)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Warning will be shown when temperature is higher than " + temperaturamaxGPU + " °C", "Max temp");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Un'avvertenza verrà mostrata quando la temperatura è maggiore di " + temperaturamaxGPU + " °C", "Max temp");
                    }
                }
            }
            else if (Celsius == false)
            {
                try
                {
                    Convert.ToInt32(textBoxGPU.Text);
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                    textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                if (Convert.ToInt32(textBoxGPU.Text) < 32 || Convert.ToInt32(textBoxGPU.Text) > 212)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                    textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente
                    return;
                }

                try
                {
                    temperaturamaxGPUf = Convert.ToInt32(textBoxGPU.Text);
                    textBoxTempGpu.Text = temperaturamaxGPUf + " °F";
                }
                catch
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Invalid value, must be a number from 32 to 212");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Valore non valido, deve essere un numero da 32 a 212");
                    }
                }

                textBoxGPU.Text = "";//cancella visivamente la temperatura inserita precedentemente

                if (temperaturamaxGPUf >= 32 || temperaturamaxGPUf <= 212)
                {
                    if (rdbtneng.Checked == true)
                    {
                        MessageBox.Show("Warning will be shown when temperature is higher than " + temperaturamaxGPUf + " °F", "Max temp");
                    }
                    else if (rdbtnita.Checked == true)
                    {
                        MessageBox.Show("Un'avvertenza verrà mostrata quando la temperatura è maggiore di " + temperaturamaxGPUf + " °F", "Max temp");
                    }
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            Home.Left = this.Left;
            Home.Top = this.Top;
            Home.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }


        private void lblSystem_Click(object sender, EventArgs e)
        {
            hideAll();
            lblA1.Show();
            panelSystem.Location = new Point(250, 140);
            panelSystem.Show();
        }
        private void lblCPU_Click(object sender, EventArgs e)
        {
            hideAll();
            lblA2.Show();
            panelCPU.Location = new Point(250, 140);
            panelCPU.Show();
        }

        private void lblGPU_Click(object sender, EventArgs e)
        {
            hideAll();
            lblA3.Show();
            panelGPU.Location = new Point(250, 140);
            panelGPU.Show();
        }

        private void lblRAM_Click(object sender, EventArgs e)
        {
            hideAll();
            lblA4.Show();
            panelRAM.Location = new Point(250, 140);
            panelRAM.Show();
        }
        private void lblHDD_Click(object sender, EventArgs e)
        {
            hideAll();
            lblA5.Show();
            panelHDD.Location = new Point(250, 140);
            panelHDD.Show();
        }

        private void lblGPU_MouseEnter(object sender, EventArgs e)
        {
            lblGPU.ForeColor = Color.White;
        }

        private void lblGPU_MouseLeave(object sender, EventArgs e)
        {
            if (FormColor == 0)
            {
                lblGPU.ForeColor = Color.DodgerBlue;
            }
            else if (FormColor == 1)
            {
                lblGPU.ForeColor = Color.FromArgb(0, 200, 0);
            }

        }

        private void lblRAM_MouseEnter(object sender, EventArgs e)
        {
            lblRAM.ForeColor = Color.White;
        }

        private void lblRAM_MouseLeave(object sender, EventArgs e)
        {
            if (FormColor == 0)
            {
                lblRAM.ForeColor = Color.DodgerBlue;
            }
            else if (FormColor == 1)
            {
                lblRAM.ForeColor = Color.FromArgb(0, 200, 0);
            }
        }

        private void lblHDD_MouseEnter(object sender, EventArgs e)
        {
            lblHDD.ForeColor = Color.White;
        }
        private void lblHDD_MouseLeave(object sender, EventArgs e)
        {
            if (FormColor == 0)
            {
                lblHDD.ForeColor = Color.DodgerBlue;
            }
            else if (FormColor == 1)
            {
                lblHDD.ForeColor = Color.FromArgb(0, 200, 0);
            }
        }

        private void lblCPU_MouseEnter(object sender, EventArgs e)
        {
            lblCPU.ForeColor = Color.White;
        }
        private void lblCPU_MouseLeave(object sender, EventArgs e)
        {
            if (FormColor == 0)
            {
                lblCPU.ForeColor = Color.DodgerBlue;
            }
            else if (FormColor == 1)
            {
                lblCPU.ForeColor = Color.FromArgb(0, 200, 0);
            }
        }

        private void lblSystem_MouseEnter(object sender, EventArgs e)
        {
            lblSystem.ForeColor = Color.White;
        }

        private void lblSystem_MouseLeave(object sender, EventArgs e)
        {
            if (FormColor == 0)
            {
                lblSystem.ForeColor = Color.DodgerBlue;
            }
            else if (FormColor == 1)
            {
                lblSystem.ForeColor = Color.FromArgb(0, 200, 0);
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            FormColor = 1;
            this.BackColor = Color.FromArgb(34, 36, 49);
            lblA1.ForeColor = Color.FromArgb(0, 200, 0);
            lblA2.ForeColor = Color.FromArgb(0, 200, 0);
            lblA3.ForeColor = Color.FromArgb(0, 200, 0);
            lblA4.ForeColor = Color.FromArgb(0, 200, 0);
            lblA5.ForeColor = Color.FromArgb(0, 200, 0);
            lblSystem.ForeColor = Color.FromArgb(0, 200, 0);
            lblCPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblGPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblRAM.ForeColor = Color.FromArgb(0, 200, 0);
            lblHDD.ForeColor = Color.FromArgb(0, 200, 0);
            lblSettings.ForeColor = Color.FromArgb(0, 200, 0);
            lblLanguage.ForeColor = Color.FromArgb(0, 200, 0);
            lblTemperature.ForeColor = Color.FromArgb(0, 200, 0);
            lblApptheme.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnita.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtneng.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnCelsius.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnFahrenheit.ForeColor = Color.FromArgb(0, 200, 0);
            lblWarningWhenCPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblWarningWhenGPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblPieChartCPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblSet.ForeColor = Color.FromArgb(0, 200, 0);
            lblSetTempGPU.ForeColor = Color.FromArgb(0, 200, 0);
            lblPieChartHDD.ForeColor = Color.FromArgb(0, 200, 0);
            lblPieChartRAM.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnDefaultCPU.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnDefaultHDD.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnDefaultRAM.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnPercentageCpu.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnPercentageHDD.ForeColor = Color.FromArgb(0, 200, 0);
            rdbtnPercentageRAM.ForeColor = Color.FromArgb(0, 200, 0);
            menuStrip1.BackColor = Color.FromArgb(34, 96, 79);
        }

        private void btnThemeDefault_Click(object sender, EventArgs e)
        {
            FormColor = 0;
            this.BackColor = Color.MidnightBlue;
            lblA1.ForeColor = Color.DodgerBlue;
            lblA2.ForeColor = Color.DodgerBlue;
            lblA3.ForeColor = Color.DodgerBlue;
            lblA4.ForeColor = Color.DodgerBlue;
            lblA5.ForeColor = Color.DodgerBlue;
            lblSystem.ForeColor = Color.DodgerBlue;
            lblCPU.ForeColor = Color.DodgerBlue;
            lblGPU.ForeColor = Color.DodgerBlue;
            lblRAM.ForeColor = Color.DodgerBlue;
            lblHDD.ForeColor = Color.DodgerBlue;
            lblSettings.ForeColor = Color.DodgerBlue;
            lblLanguage.ForeColor = Color.DodgerBlue;
            lblTemperature.ForeColor = Color.DodgerBlue;
            lblApptheme.ForeColor = Color.DodgerBlue;
            rdbtnita.ForeColor = Color.DodgerBlue;
            rdbtneng.ForeColor = Color.DodgerBlue;
            rdbtnCelsius.ForeColor = Color.DodgerBlue;
            rdbtnFahrenheit.ForeColor = Color.DodgerBlue;
            lblWarningWhenCPU.ForeColor = Color.DodgerBlue;
            lblWarningWhenGPU.ForeColor = Color.DodgerBlue;
            lblPieChartCPU.ForeColor = Color.DodgerBlue;
            lblSet.ForeColor = Color.DodgerBlue;
            lblSetTempGPU.ForeColor = Color.DodgerBlue;
            lblPieChartRAM.ForeColor = Color.DodgerBlue;
            lblPieChartHDD.ForeColor = Color.DodgerBlue;
            rdbtnDefaultCPU.ForeColor = Color.DodgerBlue;
            rdbtnDefaultHDD.ForeColor = Color.DodgerBlue;
            rdbtnDefaultRAM.ForeColor = Color.DodgerBlue;
            rdbtnPercentageCpu.ForeColor = Color.DodgerBlue;
            rdbtnPercentageHDD.ForeColor = Color.DodgerBlue;
            rdbtnPercentageRAM.ForeColor = Color.DodgerBlue;
            menuStrip1.BackColor = Color.DarkSlateBlue;
        }

    }
}

