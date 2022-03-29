﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.Win32;
using System.Threading;
using System.IO;//per hdd

namespace SystemViewer
{
    public partial class Home : Form
    {

        int i, a = 0;
        int r = 0, g = 0, b = 0;
        float flt, y;
        string ramsize, name;

        string[] enHome = { "Model", "Base clock", "Usage", "Available", "Total", "Used", "Activity", "Used", "Settings", "Informations" };
        string[] itHome = { "Modello", "Frequenza base", "Utilizzo", "Disponibile", "Totale", "Utilizzata", "Attività", "Utilizzato", "Impostazioni", "Informazioni" };

        PerformanceCounter CPU = new PerformanceCounter("Processore", "% Tempo Processore", "_Total"); //oggetto, contatore, istanza
        PerformanceCounter CPUfreq = new PerformanceCounter("Informazioni Processore", "Frequenza Processore", "_Total"); //oggetto, contatore
        PerformanceCounter RAM = new PerformanceCounter("Memoria", "MByte disponibili"); //oggetto, contatore
        PerformanceCounter HDD = new PerformanceCounter("Disco fisico", "% Tempo disco", "_Total");//oggetto, contatore, istanza

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lbltotal.Text = Convert.ToString(systemLanguage(enHome, itHome, 4)) + ": " + totram() + " GB";//RAM totale

            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    lblmodel.Text = (string)processor_name.GetValue("ProcessorNameString");
                }
            }
            progressColorCpu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cpupercent, ramused, rampercent, hddpercent;
            hddpercent = (int)HDD.NextValue();
            cpupercent = (int)CPU.NextValue();

            //CPU
            lblbaseclock.Text = systemLanguage(enHome, itHome, 1) + ": " + Convert.ToString(CPUfreq.NextValue()) + " MHz" + " (Boost Excluded)";
            lblusage.Text = systemLanguage(enHome, itHome, 2) + ": " + cpupercent + " %"; //CPU%
            crclprgrsbrCpu.Value = cpupercent;
            crclprgrsbrCpu.Text = cpupercent + "%";
            //CPU progress color
            cpuProgressPercentageColor();

            //RAM
            float Ramgb = ramtotMB();//senza questo il form lagga

            ramused = (int)RAM.NextValue();
            lblavailable.Text = systemLanguage(enHome, itHome, 3) + ": " + ramused + " MB"; //RAM%                       
            lblused.Text = systemLanguage(enHome, itHome, 5) + ": " + Convert.ToString(Ramgb - (ramused * 1024 / 1000)) + " MB"; //RAM utilizzata + conversione
            rampercent = 100 - (ramused * 100 / (int)Ramgb);
            crclprgrsbrRam.Value = rampercent;
            crclprgrsbrRam.Text = rampercent + "%";

            //HDD
            if (hddpercent > 100)
            {
                hddpercent = 100;//per qualche strano motivo la percentuale supera il 100%
            }
            crclprgrsbHdd.Value = hddpercent;
            crclprgrsbHdd.Text = hddpercent + "%";
            lblhddactivity.Text = systemLanguage(enHome, itHome, 6) + ": " + Convert.ToString(hddpercent) + " %";//HDD%
            lblhddused.Text = systemLanguage(enHome, itHome, 7) + ": " + " GB";

            //menu
            settingsToolStripMenuItem.Text = systemLanguage(enHome, itHome, 8);
            informationsToolStripMenuItem.Text = systemLanguage(enHome, itHome, 9);
   
        }

        private void btnINFO_Click(object sender, EventArgs e)
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format("Name : {0}", (string)mo["Name"]));
                sb.AppendLine(string.Format("BaseClock : {0}", mo["MaxClockSpeed"] + " MHz").ToString());
                sb.AppendLine(string.Format("CurrentClock : {0}", mo["CurrentClockSpeed"] + " MHz").ToString());
                sb.AppendLine(string.Format("Cores : {0}", mo["NumberOfCores"]).ToString());
                sb.AppendLine(string.Format("Threads : {0}", mo["NumberOfLogicalProcessors"]).ToString());
                sb.AppendLine(string.Format("L2Cache : {0}", mo["L2CacheSize"] + " KB").ToString());
                sb.AppendLine(string.Format("L3Cache : {0}", mo["L3CacheSize"] + " KB").ToString());
                sb.AppendLine(string.Format("Voltage : {0}", (ushort)mo["CurrentVoltage"] + " V"));
                sb.AppendLine(string.Format("Manufacturer: {0}", (string)mo["Manufacturer"]));

            }
            MessageBox.Show(sb.ToString());
        }

        //FUNZIONI

        public void hideHome()//funzione che nasconde la Home
        {
            menuStrip1.Hide();
            lblhddused.Hide();
            lblused.Hide();
            lblusage.Hide();
            lblavailable.Hide();
            lblhddactivity.Hide();
            lblbaseclock.Hide();
            lblmodel.Hide();
            lbltotal.Hide();
            lblCPU.Hide();
            lblRAM.Hide();
            lblHDD.Hide();
            crclprgrsbrCpu.Hide();
            crclprgrsbrRam.Hide();
            crclprgrsbHdd.Hide();
            btnINFO.Hide();
        }

        public void showHome()//funzione che mostra la Home
        {
            menuStrip1.Show();
            lblhddused.Show();
            lblused.Show();
            lblusage.Show();
            lblavailable.Show();
            lblhddactivity.Show();
            lblbaseclock.Show();
            lblmodel.Show();
            lbltotal.Show();
            lblCPU.Show();
            lblRAM.Show();
            lblHDD.Show();
            crclprgrsbrCpu.Show();
            crclprgrsbrRam.Show();
            crclprgrsbHdd.Show();
            btnINFO.Show();
        }

        public string nameCPU() //estrae il nome di riferimento della CPU (es. Intel, Amd)
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                name = Convert.ToString(sb.AppendLine(string.Format((string)mo["Name"])));
            }

            string finalname = name.Substring(0, 6);

            if (finalname.Substring(0, 1) == "A" || finalname.Substring(0, 1) == "a")//se la prima lettera è "A" allora restituisce "AMD"
            {
                finalname = finalname.Substring(0, 3);
            }
            else if (finalname.Substring(0, 1) == "I" || finalname.Substring(0, 1) == "i")//se la prima lettera è "I" allora restituisce "Intel"
            {
                finalname = finalname.Substring(0, 5);
            }

            return finalname;
        }

        public void progressColorCpu()
        {
            if (nameCPU() == "AMD" || nameCPU() == "Amd" || nameCPU() == "amd")
            {
                crclprgrsbrCpu.ProgressColor = Color.FromArgb(237, 28, 36);
            }
            else if (nameCPU() == "INTEL" || nameCPU() == "Intel" || nameCPU() == "intel")
            {
                crclprgrsbrCpu.ProgressColor = Color.FromArgb(0, 113, 197);
            }
            else
                crclprgrsbrCpu.ProgressColor = Color.White;
        }
        
        private void crclprgrsbrCpu_Click(object sender, EventArgs e)
        {
            /*SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.Show();
            SettingsForm.Left = this.Left;
            SettingsForm.Top = this.Top;
            SettingsForm.Size = this.Size;*/
            timer1.Stop();
            //this.Hide();
        }
        

        private void rdbtnCpuDefault_CheckedChanged(object sender, EventArgs e)
        {
            progressColorCpu();
        }
        private void rdbtnPercentage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbtnCustom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                hideHome();
                menuStrip1.Show();
                a++;
            }
            else if (a == 1)
            {
                showHome();
                a--;
            }
        }

        private void rdbtnita_CheckedChanged(object sender, EventArgs e)
        {
            lbltotal.Text = systemLanguage(enHome, itHome, 4) + ": " + totram() + " GB";
        }

        private void rdbtneng_CheckedChanged(object sender, EventArgs e)
        {
            lbltotal.Text = systemLanguage(enHome, itHome, 4) + ": " + totram() + " GB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                sb.AppendLine("Name  -  " + obj["Name"]);
                sb.AppendLine("Status  -  " + obj["Status"]);
                sb.AppendLine("Caption  -  " + obj["Caption"]);
                sb.AppendLine("DeviceID  -  " + obj["DeviceID"]);
                double vram = Convert.ToDouble(obj["AdapterRAM"]);
                sb.AppendLine("AdapterRAM  -  " + vram/1024/1024/1024 + " GB");
                sb.AppendLine("AdapterDACType  -  " + obj["AdapterDACType"]);
                sb.AppendLine("DriverVersion  -  " + obj["DriverVersion"]);
                sb.AppendLine("VideoProcessor  -  " + obj["VideoProcessor"]);

            }
            MessageBox.Show(sb.ToString());
        }

        private void btnINFOHDD_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            StringBuilder sb = new StringBuilder();
            foreach (DriveInfo d in allDrives)
            {
                sb.AppendLine("Drive " + d.Name);
                sb.AppendLine("  Drive type: " + d.DriveType);
                if (d.IsReady == true)
                {
                    sb.AppendLine("  Volume label: " + d.VolumeLabel);
                    sb.AppendLine("  File system: " + d.DriveFormat);
                    float free = d.TotalFreeSpace;
                    sb.AppendLine("  Total available space:" + convertFromByteToGiga(free) + " GB");
                    float totalsize = d.TotalSize;
                    sb.AppendLine("  Total size of drive: " + convertFromByteToGiga(totalsize) + " GB");
                }
            }
            MessageBox.Show(sb.ToString());
        }


        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                hideHome();
                menuStrip1.Show();
                a++;
            }
            else if (a == 1)
            {
                showHome();
                a--;
            }
        }

        public float ramtotMB()//estrae la quantità totale di RAM (MB) utilizzabile dal sistema
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");//LENTOOO
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                ramsize = Convert.ToString(result["TotalVisibleMemorySize"]);
                y = Convert.ToInt32(ramsize);
                y = y / 1024; // conversione da KiloByte a MegaByte con decimali
                i = (int)y;
            }

            return i;
        }

        public float ramtotGB(float f)// trasforma la ram da MB a GB, con 2 numeri decimali (es 9,86 GB)
        {
            int int1;
            int1 = (int)f;
            f = (float)int1 / 1024;
            f = f * 100;
            int1 = (int)f;
            f = (float)int1 / 100;
            return f;
        }
        
        public string systemLanguage(string[] eng, string[] ita, int n) // lingua di sistema
        {
            if (rdbtnita.Checked == true)
            {
                return ita[n];
            }
            return eng[n];
        }
        
        public float totram()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");//LENTOOOOO
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            flt = ramtotGB(ramtotMB());
            return flt;
        }

        public void cpuProgressPercentageColor()
        {
            if (rdbtnPercentage.Checked == true)
            {
                if (crclprgrsbrCpu.Value < 25)
                {
                    crclprgrsbrCpu.ProgressColor = Color.Green;
                }
                else if (crclprgrsbrCpu.Value >= 25 && crclprgrsbrCpu.Value < 50)
                {
                    crclprgrsbrCpu.ProgressColor = Color.Yellow;
                }
                else if (crclprgrsbrCpu.Value >= 50 && crclprgrsbrCpu.Value < 75)
                {
                    crclprgrsbrCpu.ProgressColor = Color.Orange;
                }
                else if (crclprgrsbrCpu.Value >= 75)
                {
                    crclprgrsbrCpu.ProgressColor = Color.Red;
                }
            }
        }

        public float convertFromByteToGiga(float f)//converte da byte a giga con centesimi (es 50,15)
        {
            int i;
            f = f / 1024 / 1024;
            i = (int)f;
            i = i / 8;
            f = i;
            f = f / 128 * 100;
            i = (int)f;
            f = i;
            f = f / 100;
            return f;
        }
    }
}
