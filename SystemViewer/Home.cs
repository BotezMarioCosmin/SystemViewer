using System;
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
using System.IO;//per hdd
using OpenHardwareMonitor.Hardware;

namespace SystemViewer
{
    public partial class Home : Form
    {
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        static float GetCpuTemp()
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            return (float)computer.Hardware[i].Sensors[j].Value;
                    }

                }
                return 0;
            }
            computer.Close();
            return 0;
        }

        static float GetGpuTemp()
        {
            Computer myComputer = new Computer();
            myComputer.Open();
            myComputer.GPUEnabled = true;
            foreach (var hardwareItem in myComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                {
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        return (float)sensor.Value;
                    }   
                }
                return 0;
            }
            myComputer.Close();
            return 0;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string gpuErrorMessage;
        public static bool noGPU = false;
        int i;
        float flt, y;
        string ramsize, name;
        float hddtotal, hddfree;
        public static bool forminf;
        public static bool cpuclick = false, ramclick = false, hddclick = false;

        string[] enHome = { "Model", "Current clock", "Usage", "Available", "Total", "Used", "Activity", "Used", "Settings", "Informations", "Free", "Stick capacity", "Temperature", "System name" };
        string[] itHome = { "Modello", "Frequenza attuale", "Utilizzo", "Disponibile", "Totale", "Utilizzata", "Attività", "Utilizzato", "Impostazioni", "Informazioni", "Disponibile", "Capacità banco", "Temperatura", "Nome sistema" };

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
            lblSystemName.Text = systemLanguage(enHome, itHome, 13) + ": " + systemName();

            lbltotal.Text = Convert.ToString(systemLanguage(enHome, itHome, 4)) + ": " + totram() + " GB";//RAM totale

            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    lblmodel.Text = (string)processor_name.GetValue("ProcessorNameString");
                }
            }
            if (Settings.CpuColor == 1)
            {
                cpuProgressPercentageColor();
            }
            else
            progressColorCpu();

            helpButtonCpu();
            helpButtonGpuTemp();
            helpButtonCpuTemp();
            helpButtonHddUsage();

            //HDD
            crclrprgrsbrHddUsed.Maximum = Convert.ToInt32(hddTotal());//imposta il valore massimo della circularprogressbar hdd
            crclrprgrsbrHddUsed.Value = Convert.ToInt32(hddTotal() - hddFree());
            int hddfreepercent = Convert.ToInt32(100 - (hddFree() * 100 / hddTotal()));
            crclrprgrsbrHddUsed.Text = Convert.ToString(hddfreepercent) + "%";//utilizzo percentuale hdd
            hddtotal = hddTotal();
            hddfree = hddFree();

            //GPU
            lblgpumodel.Text = gpuName();

            helpGpuTemp.Hide();

            //tema app
            if (Settings.FormColor == 0)
            {
                Color color = Color.DodgerBlue;
                this.BackColor = Color.MidnightBlue;
                lblSystemName.ForeColor = color;
                lblCPU.ForeColor = color;
                lblmodel.ForeColor = color;
                lblbaseclock.ForeColor = color;
                menuStrip1.BackColor = Color.DarkSlateBlue;
                lblGPU.ForeColor = color;
                lblgpumodel.ForeColor = color;
                lblGpuVram.ForeColor = color;
                lblGPUTEMP.ForeColor = color;
                btnINFO.ForeColor = color;
                btnINFOGPU.ForeColor = color;
                lblRAM.ForeColor = color;
                lbltotal.ForeColor = color;
                lblavailable.ForeColor = color;
                lblused.ForeColor = color;
                btnINFORAM.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddtotal.ForeColor = color;
                lblusage.ForeColor = color;
                lblHDD.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddused.ForeColor = color;
                lblhddfree.ForeColor = color;
                lblhddactivity.ForeColor = color;
            }
            else if (Settings.FormColor == 1)
            {
                Color color = Color.FromArgb(0, 200, 0);
                this.BackColor = Color.FromArgb(34, 36, 49);
                lblSystemName.ForeColor = color;
                lblCPU.ForeColor = color;
                lblmodel.ForeColor = color;
                lblbaseclock.ForeColor = color;
                menuStrip1.BackColor = Color.FromArgb(34, 96, 79);
                lblGPU.ForeColor = color;
                lblgpumodel.ForeColor = color;
                lblGpuVram.ForeColor = color;
                lblGPUTEMP.ForeColor = color;
                btnINFO.ForeColor = color;
                btnINFOGPU.ForeColor = color;
                lblRAM.ForeColor = color;
                lbltotal.ForeColor = color;
                lblavailable.ForeColor = color;
                lblused.ForeColor = color;
                btnINFORAM.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddtotal.ForeColor = color;
                lblusage.ForeColor = color;
                lblHDD.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddused.ForeColor = color;
                lblhddfree.ForeColor = color;
                lblhddactivity.ForeColor = color;
            }
            else if (Settings.FormColor == 2)
            {
                Color color = Color.FromArgb(244, 226, 198);
                this.BackColor = Color.FromArgb(100, 50, 80);
                lblSystemName.ForeColor = color;
                lblCPU.ForeColor = color;
                lblmodel.ForeColor = color;
                lblbaseclock.ForeColor = color;
                menuStrip1.BackColor = Color.FromArgb(130, 80, 90);
                lblGPU.ForeColor = color;
                lblgpumodel.ForeColor = color;
                lblGpuVram.ForeColor = color;
                lblGPUTEMP.ForeColor = color;
                btnINFO.ForeColor = color;
                btnINFOGPU.ForeColor = color;
                lblRAM.ForeColor = color;
                lbltotal.ForeColor = color;
                lblavailable.ForeColor = color;
                lblused.ForeColor = color;
                btnINFORAM.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddtotal.ForeColor = color;
                lblusage.ForeColor = color;
                lblHDD.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddused.ForeColor = color;
                lblhddfree.ForeColor = color;
                lblhddactivity.ForeColor = color;
            }
            else if (Settings.FormColor == 3)
            {
                Color color = Color.FromArgb(255, 255, 255);
                this.BackColor = Color.FromArgb(40, 40, 40);
                lblSystemName.ForeColor = color;
                lblCPU.ForeColor = color;
                lblmodel.ForeColor = color;
                lblbaseclock.ForeColor = color;
                menuStrip1.BackColor = Color.FromArgb(80, 80, 80);
                lblGPU.ForeColor = color;
                lblgpumodel.ForeColor = color;
                lblGpuVram.ForeColor = color;
                lblGPUTEMP.ForeColor = color;
                btnINFO.ForeColor = color;
                btnINFOGPU.ForeColor = color;
                lblRAM.ForeColor = color;
                lbltotal.ForeColor = color;
                lblavailable.ForeColor = color;
                lblused.ForeColor = color;
                btnINFORAM.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddtotal.ForeColor = color;
                lblusage.ForeColor = color;
                lblHDD.ForeColor = color;
                btnINFOHDD.ForeColor = color;
                lblhddused.ForeColor = color;
                lblhddfree.ForeColor = color;
                lblhddactivity.ForeColor = color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cpupercent, ramused, rampercent, hddpercent;
            hddpercent = (int)HDD.NextValue();
            cpupercent = (int)CPU.NextValue();
            float temperaturaCpu = tempAprox(GetCpuTemp());
            float temperaturaGpu = tempAprox(GetGpuTemp());
            int a = 2;
            float temperaturaf;
            float temperaturafgpu;

            //CPU
            lblbaseclock.Text = systemLanguage(enHome, itHome, 1) + ": " + Convert.ToString(CPUfreq.NextValue()) + " MHz";
            lblusage.Text = systemLanguage(enHome, itHome, 2) + ": " + cpupercent + " %"; //CPU%
            if (cpupercent >= 90)
            {
                lblusage.ForeColor = Color.Red;
            }
            else if (cpupercent < 90)
            {
                if (Settings.FormColor == 1)
                {
                    lblCPUTEMP.ForeColor = Color.FromArgb(0, 200, 0);
                }
                else if (Settings.FormColor == 0)
                {
                    lblCPUTEMP.ForeColor = Color.DodgerBlue;
                }
                else if (Settings.FormColor == 2)
                { 
                    lblCPUTEMP.ForeColor = Color.FromArgb(244, 226, 198);
                }
                else if (Settings.FormColor == 3)
                {
                    lblCPUTEMP.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
            crclprgrsbrCpu.Value = cpupercent;
            crclprgrsbrCpu.Text = cpupercent + "%";
            //CPU progress color
            cpuProgressPercentageColor();

            //CPU temp
            temperaturaf = temperaturaCpu * a +30;
            if (Settings.Celsius == false)
            {
                lblCPUTEMP.Text = systemLanguage(enHome, itHome, 12) + ": " + (temperaturaf)+ boolCelsius(Settings.Celsius);
                if (temperaturaf >= Settings.temperaturamaxCPUf)
                {
                    lblCPUTEMP.ForeColor = Color.Red;
                }
                else
                {
                    if (Settings.FormColor == 1)
                    {
                        lblCPUTEMP.ForeColor = Color.FromArgb(0, 200, 0);
                    }
                    else if (Settings.FormColor == 0)
                    {
                        lblCPUTEMP.ForeColor = Color.DodgerBlue;
                    }
                    else if (Settings.FormColor == 2)
                    { 
                        lblCPUTEMP.ForeColor = Color.FromArgb(244, 226, 198);
                    }
                    else if (Settings.FormColor == 3)
                    {
                        lblCPUTEMP.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
            else
            {
                lblCPUTEMP.Text = systemLanguage(enHome, itHome, 12) + ": " + temperaturaCpu + boolCelsius(Settings.Celsius);

                if (temperaturaCpu >= Settings.temperaturamaxCPU)
                {
                    lblCPUTEMP.ForeColor = Color.Red;
                }
                else
                {
                    if (Settings.FormColor == 1)
                    {
                        lblCPUTEMP.ForeColor = Color.FromArgb(0, 200, 0);
                    }
                    else if (Settings.FormColor == 0)
                    {
                        lblCPUTEMP.ForeColor = Color.DodgerBlue;
                    }
                    else if (Settings.FormColor == 2)
                    {
                        lblCPUTEMP.ForeColor = Color.FromArgb(244, 226, 198);
                    }
                    else if (Settings.FormColor == 3)
                    {
                        lblCPUTEMP.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
            int ramAvailable;


            //RAM
            float RamTotMB = ramtotMB();//senza questo il form lagga

            ramAvailable = (int)RAM.NextValue();
            lblavailable.Text = systemLanguage(enHome, itHome, 3) + ": " + ramAvailable + " MB"; //RAM                     
            lblused.Text = systemLanguage(enHome, itHome, 5) + ": " + Convert.ToString(RamTotMB - ramAvailable) + " MB"; //RAM utilizzata + conversione
            rampercent = 100 - (ramAvailable * 100 / (int)RamTotMB);
            crclprgrsbrRam.Value = rampercent;
            crclprgrsbrRam.Text = rampercent + "%";
            //RAM progress color
            ramProgressPercentageColor();

            //HDD
            if (hddpercent > 100)
            {
                hddpercent = 100;//per qualche strano motivo la percentuale supera il 100%
            }
            crclprgrsbHdd.Value = hddpercent;
            crclprgrsbHdd.Text = hddpercent + "%";
            lblhddactivity.Text = systemLanguage(enHome, itHome, 6) + ": " + Convert.ToString(hddpercent) + " %";//HDD%

            if (hddpercent >= 80)
            {
                lblhddactivity.ForeColor = Color.Red;
                helpHddActivity.Show();
            }
            else if (hddpercent < 80)
            {
                if (Settings.FormColor == 0)
                {
                    lblhddactivity.ForeColor = Color.DodgerBlue;
                }
                else if (Settings.FormColor == 1)
                {
                    lblhddactivity.ForeColor = Color.FromArgb(0, 200, 0);
                }
                else if (Settings.FormColor == 2)
                {
                    lblhddactivity.ForeColor = Color.FromArgb(244, 226, 198);
                }
                else if (Settings.FormColor == 3)
                {
                    lblhddactivity.ForeColor = Color.FromArgb(255, 255, 255);
                }
                helpHddActivity.Hide();
            }

            lblhddtotal.Text = systemLanguage(enHome, itHome, 4) + ": " + Convert.ToString(hddtotal) + " GB";
            lblhddused.Text = systemLanguage(enHome, itHome, 5) + ": " + Convert.ToString(hddtotal - hddfree) + " GB";
            lblhddfree.Text = systemLanguage(enHome, itHome, 10) + ": " + Convert.ToString(hddfree) + " GB";
            //HDD progress color
            hddProgressPercentageColor();
            hddUsedProgressPercentageColor();

            //menu
            settingsToolStripMenuItem.Text = systemLanguage(enHome, itHome, 8);
            informationsToolStripMenuItem.Text = systemLanguage(enHome, itHome, 9);

            
            if (temperaturaCpu >= Settings.temperaturamaxCPU)
            {
                helpCpuTemp.Show();
            }
            else if (temperaturaCpu <= Settings.temperaturamaxCPU)
            {
                helpCpuTemp.Hide();
            }

            //GPU
            temperaturafgpu = temperaturaGpu * a + 30;
            if (temperaturaGpu == 0)
            {
                lblGPUTEMP.Text = systemLanguage(enHome, itHome, 12) + ": " + "N/D";
            }
            else
            {
                if (Settings.Celsius == false)
                {
                    lblGPUTEMP.Text = systemLanguage(enHome, itHome, 12) + ": " + temperaturafgpu + boolCelsius(Settings.Celsius);

                    if (temperaturafgpu >= Settings.temperaturamaxGPUf)
                    {
                        lblGPUTEMP.ForeColor = Color.Red;
                        helpGpuTemp.Show();
                    }
                    else
                    {
                        if (Settings.FormColor == 0)
                        {
                            lblGPUTEMP.ForeColor = Color.DodgerBlue;
                            helpGpuTemp.Hide();
                        }
                        else if (Settings.FormColor == 1)
                        {
                            lblGPUTEMP.ForeColor = Color.FromArgb(0,200,0);
                            helpGpuTemp.Hide();
                        }
                        else if (Settings.FormColor == 2)
                        {
                            lblGPUTEMP.ForeColor = Color.FromArgb(244, 226, 198);
                            helpGpuTemp.Hide();
                        }
                        else if (Settings.FormColor == 3)
                        {
                            lblGPUTEMP.ForeColor = Color.FromArgb(255, 255, 255);
                            helpGpuTemp.Hide();
                        }
                    }
                }
                else
                {
                    lblGPUTEMP.Text = systemLanguage(enHome, itHome, 12) + ": " + temperaturaGpu + boolCelsius(Settings.Celsius);

                    if (temperaturaGpu >= Settings.temperaturamaxGPU)
                    {
                        lblGPUTEMP.ForeColor = Color.Red;
                        helpGpuTemp.Show();
                    }
                    else if (Settings.FormColor == 0)
                    {
                        lblGPUTEMP.ForeColor = Color.DodgerBlue;
                        helpGpuTemp.Hide();
                    }
                    else if (Settings.FormColor == 1)
                    {
                        lblGPUTEMP.ForeColor = Color.FromArgb(0, 200, 0);
                        helpGpuTemp.Hide();
                    }
                    else if (Settings.FormColor == 2)
                    {
                        lblGPUTEMP.ForeColor = Color.FromArgb(244, 226, 198);
                        helpGpuTemp.Hide();
                    }
                    else if (Settings.FormColor == 3)
                    {
                        lblGPUTEMP.ForeColor = Color.FromArgb(255, 255, 255);
                        helpGpuTemp.Hide();
                    }

                }

            }


            try
            {
                var computer = new Computer();
                computer.GPUEnabled = true;
                computer.Open();
                var gpu = computer.Hardware.First(x => x.HardwareType == HardwareType.GpuNvidia);
                var vramTot = gpu.Sensors.First(x => x.Name.Equals("GPU Memory Total")).Value / 1024;
                lblGpuVram.Text = "VRAM: " + vramTot.ToString() + " GB";
                computer.Close();

            }
            catch (Exception ex)
            {
                noGPU = true;
                forminf = true;
                gpuErrorMessage = ex.Message;
                lblGpuVram.Text = "VRAM: N/D";
            }

        }

        private void btnINFO_Click(object sender, EventArgs e)
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                try
                {
                    sb.AppendLine(string.Format("Name : {0}", (string)mo["Name"]));
                }
                catch
                {
                    sb.AppendLine(string.Format("Name : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Manufacturer : {0}", (string)mo["Manufacturer"]));
                }
                catch
                {
                    sb.AppendLine(string.Format("  Manufacturer : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Base clock : {0}", mo["MaxClockSpeed"] + " MHz").ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  Base clock : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Current clock : {0}", mo["CurrentClockSpeed"] + " MHz").ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  Current clock : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Cores : {0}", mo["NumberOfCores"]).ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  Cores : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Threads : {0}", mo["NumberOfLogicalProcessors"]).ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  Threads : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  L2Cache : {0}", mo["L2CacheSize"] + " KB").ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  L2Cache : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  L3Cache : {0}", mo["L3CacheSize"] + " KB").ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  L3Cache : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Voltage : {0}", (ushort)mo["CurrentVoltage"] + " V"));
                }
                catch
                {
                    sb.AppendLine(string.Format("  Voltage : {0}", "N/D"));
                }

                try
                {
                    sb.AppendLine(string.Format("  Socket : {0}", mo["SocketDesignation"]).ToString());
                }
                catch
                {
                    sb.AppendLine(string.Format("  Socket : {0}", "N/D"));
                }
            }
            MessageBox.Show(sb.ToString(), "CPU info");
        }

        ///////////////////////////////////////////////////////// F  U  N  Z  I  O  N  I ///////////////////////////////////////////////////////////////////////

        public string nameCPU() //estrae il nome di riferimento della CPU (es. Intel, Amd)
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                try
                {
                    name = Convert.ToString(sb.AppendLine(string.Format((string)mo["Name"])));
                }
                catch
                {
                    name = "N/D";
                }
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

        public void progressColorCpu()//cambia colore della circularprogressbar in base al colore della marca della cpu
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
            cpuclick = true;
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            timer1.Stop();
            this.Hide();
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

        public float ramtotMB()//estrae la quantità totale di RAM (MB) utilizzabile dal sistema
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");//LENTOOO
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                try
                {
                    ramsize = Convert.ToString(result["TotalVisibleMemorySize"]);
                }
                catch
                {
                    ramsize = "0";
                }

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

        private void helpCpu_Click(object sender, EventArgs e)
        {
            if (Settings.Language == 0)
            {
                string h = "Current clock";
                string m = "Shows the maximum frequency in non-boost mode, it could change based on the power plan you have active."
                    + Environment.NewLine + /*va a capo*/ Environment.NewLine + "Boost mode :   temporarily let the processor consume more energy in exchange for a temporary increase in processing speed.";
                MessageBox.Show(m, h);
            }
            else if (Settings.Language == 1)
            {
                string h = "Frequenza attuale";
                string m = "Mostra la frequenza massima in modalità non-boost (frequenza di base), può cambiare in base alle combinazioni di risparmio energia (di Windows) attive."
                    + Environment.NewLine + /*va a capo*/ Environment.NewLine + "Boost mode :   consente temporaneamente al processore di consumare più energia in cambio di un aumento temporaneo della velocità di elaborazione.";
                MessageBox.Show(m, h);
            }

        }

        private void btnINFOGPU_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                try
                {
                    sb.AppendLine("Name : " + obj["Name"]);
                }
                catch
                {
                    sb.AppendLine("Name : " + "N/D");
                }


                try
                {
                    sb.AppendLine("Refresh rate : " + obj["CurrentRefreshRate"] + " Hz");
                }
                catch
                {
                    sb.AppendLine("Refresh rate : " + "N/D");
                }

                try
                {
                    sb.AppendLine("Vertical resolution : " + obj["CurrentVerticalResolution"] + " p");
                }
                catch
                {
                    sb.AppendLine("Vertical resolution : " + "N/D");
                }

                try
                {
                    sb.AppendLine("Horizontal resolution : " + obj["CurrentHorizontalResolution"] + " p");
                }
                catch
                {
                    sb.AppendLine("Horizontal resolution : " + "N/D");
                }

                try
                {
                    sb.AppendLine("Driver version : " + obj["DriverVersion"]);
                }
                catch
                {
                    sb.AppendLine("Driver version : " + "N/D");
                }

                try
                {
                    sb.AppendLine("Video processor : " + obj["VideoProcessor"]);
                }
                catch
                {
                    sb.AppendLine("Video processor : " + "N/D");
                }
            }
            MessageBox.Show(sb.ToString(), "GPU info");
        }

        private void btnINFOHDD_Click_1(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            StringBuilder sb = new StringBuilder();

            foreach (DriveInfo d in allDrives)
            {
                try
                {
                    sb.AppendLine("Drive : " + d.Name);
                }
                catch
                {
                    sb.AppendLine("Drive : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Type : " + d.DriveType);
                }
                catch
                {
                    sb.AppendLine("  Type : " + "N/D");
                }

                if (d.IsReady == true)
                {
                    try
                    {
                        sb.AppendLine("  Volume label : " + d.VolumeLabel);
                    }
                    catch
                    {
                        sb.AppendLine("  Volume label : " + "N/D");
                    }

                    try
                    {
                        sb.AppendLine("  File system : " + d.DriveFormat);
                    }
                    catch
                    {
                        sb.AppendLine("  File system : " + "N/D");
                    }

                    float free = d.TotalFreeSpace;
                    sb.AppendLine("  Free space : " + convertFromByteToGiga(free) + " GB");
                    float totalsize = d.TotalSize;
                    sb.AppendLine("  Total size : " + convertFromByteToGiga(totalsize) + " GB");
                }
                sb.AppendLine("-------------------------------------------");
            }
            MessageBox.Show(sb.ToString(), "Disks info");
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
            if (Settings.CpuColor == 1)
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

        public void ramProgressPercentageColor()
        {
            if (Settings.RamColor == 1)
            {
                if (crclprgrsbrRam.Value < 25)
                {
                    crclprgrsbrRam.ProgressColor = Color.Green;
                }
                else if (crclprgrsbrRam.Value >= 25 && crclprgrsbrRam.Value < 50)
                {
                    crclprgrsbrRam.ProgressColor = Color.Yellow;
                }
                else if (crclprgrsbrRam.Value >= 50 && crclprgrsbrRam.Value < 75)
                {
                    crclprgrsbrRam.ProgressColor = Color.Orange;
                }
                else if (crclprgrsbrRam.Value >= 75)
                {
                    crclprgrsbrRam.ProgressColor = Color.Red;
                }
            }
        }

        public void hddProgressPercentageColor()
        {
            if (Settings.HddColor == 1)
            {
                if (crclprgrsbHdd.Value < 25)
                {
                    crclprgrsbHdd.ProgressColor = Color.Green;
                }
                else if (crclprgrsbHdd.Value >= 25 && crclprgrsbHdd.Value < 50)
                {
                    crclprgrsbHdd.ProgressColor = Color.Yellow;
                }
                else if (crclprgrsbHdd.Value >= 50 && crclprgrsbHdd.Value < 75)
                {
                    crclprgrsbHdd.ProgressColor = Color.Orange;
                }
                else if (crclprgrsbHdd.Value >= 75)
                {
                    crclprgrsbHdd.ProgressColor = Color.Red;
                }
            }
        }

        public void hddUsedProgressPercentageColor()
        {
            if (Settings.HddColor == 1)
            {
                if (crclrprgrsbrHddUsed.Value < 25)
                {
                    crclrprgrsbrHddUsed.ProgressColor = Color.Green;
                }
                else if (crclrprgrsbrHddUsed.Value >= 25 && crclrprgrsbrHddUsed.Value < 50)
                {
                    crclrprgrsbrHddUsed.ProgressColor = Color.Yellow;
                }
                else if (crclrprgrsbrHddUsed.Value >= 50 && crclrprgrsbrHddUsed.Value < 75)
                {
                    crclrprgrsbrHddUsed.ProgressColor = Color.Orange;
                }
                else if (crclrprgrsbrHddUsed.Value >= 75)
                {
                    crclrprgrsbrHddUsed.ProgressColor = Color.Red;
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

        private void btnINFORAM_Click(object sender, EventArgs e)//ram info
        {
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;

            ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                try
                {
                    sb.AppendLine("Slot : " + queryObj["BankLabel"]);
                }
                catch
                {
                    sb.AppendLine("Slot : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Manufacturer : " + queryObj["Manufacturer"]);
                }
                catch
                {
                    sb.AppendLine("  Manufacturer : " + "N/D");
                }

                try
                {
                    int x = Convert.ToInt32(queryObj["SMBIOSMemoryType"]);
                    string ramType;
                    if (x == 26)
                    {
                        ramType = "DDR4";
                    }
                    else if (x == 24)
                    {
                        ramType = "DDR3";
                    }
                    else if (x == 22)
                    {
                        ramType = "DDR2 FB-DIMM";
                    }
                    else if (x == 21)
                    {
                        ramType = "DDR2";
                    }
                    else if (x == 20)
                    {
                        ramType = "DDR";
                    }
                    else { ramType = "N/D"; }

                    sb.AppendLine("  Memory type : " + ramType);
                }
                catch
                {
                    sb.AppendLine("  Memory type : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Type : " + queryObj["DeviceLocator"]);
                }
                catch
                {
                    sb.AppendLine("  Type : " + "N/D");
                }

                try
                {
                    long a = Convert.ToInt64(queryObj["Capacity"]);
                    a = a / 1024 / 1024 / 1024;//da byte a GigaByte
                    int capacitàRam = Convert.ToInt32(a);
                    sb.AppendLine("  Capacity : " + capacitàRam + " GB");
                }
                catch
                {
                    sb.AppendLine("  Capacity : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Speed : " + queryObj["Speed"] + " MHz");
                }
                catch
                {
                    sb.AppendLine("  Speed : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Configured speed : " + queryObj["ConfiguredClockSpeed"] + " MHz");
                }
                catch
                {
                    sb.AppendLine("  Configured speed : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Data width : " + queryObj["DataWidth"] + " bits");
                }
                catch
                {
                    sb.AppendLine("  Data width : " + "N/D");
                }

                try
                {
                    sb.AppendLine("  Total width : " + queryObj["TotalWidth"] + " bits");
                }
                catch
                {
                    sb.AppendLine("  Total width : " + queryObj["TotalWidth"] + " bits");
                }
                
                sb.AppendLine("-----------------------------------");
            }
            MessageBox.Show(sb.ToString(), "RAM Sticks info");
        }

        public void helpButtonCpu()
        {
            helpCpu.BackgroundImage = Properties.Resources.help;
            helpCpu.BackgroundImageLayout = ImageLayout.Stretch;
            helpCpu.TabStop = false;
            helpCpu.FlatStyle = FlatStyle.Flat;
            helpCpu.FlatAppearance.BorderSize = 0;
        }

        public void helpButtonGpuTemp()
        {
            helpGpuTemp.BackgroundImage = Properties.Resources.warning;
            helpGpuTemp.BackgroundImageLayout = ImageLayout.Stretch;
            helpGpuTemp.TabStop = false;
            helpGpuTemp.FlatStyle = FlatStyle.Flat;
            helpGpuTemp.FlatAppearance.BorderSize = 0;
        }
        public void helpButtonCpuTemp()
        {
            helpCpuTemp.BackgroundImage = Properties.Resources.warning;
            helpCpuTemp.BackgroundImageLayout = ImageLayout.Stretch;
            helpCpuTemp.TabStop = false;
            helpCpuTemp.FlatStyle = FlatStyle.Flat;
            helpCpuTemp.FlatAppearance.BorderSize = 0;
        }

        public void helpButtonHddUsage()
        {
            helpHddActivity.BackgroundImage = Properties.Resources.warning;
            helpHddActivity.BackgroundImageLayout = ImageLayout.Stretch;
            helpHddActivity.TabStop = false;
            helpHddActivity.FlatStyle = FlatStyle.Flat;
            helpHddActivity.FlatAppearance.BorderSize = 0;
        }

        public string gpuName() //GPU model
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            string graphicsCard = string.Empty;
            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj["CurrentBitsPerPixel"] != null && obj["CurrentHorizontalResolution"] != null)
                {
                    return obj["Name"].ToString();
                }
                return "n/d";
            }
            return "n/d";
        }

        private void helpCpuTemp_Click(object sender, EventArgs e)
        {
            if (Settings.Language == 0)
            {
                MessageBox.Show("Too high temperature!");
            }
            else if (Settings.Language == 1)
            {
                MessageBox.Show("Temperatura troppo elevata!");
            }
        }

        private void rdbtnFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }


        public float hddFree()//hdd free space
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    float free = d.TotalFreeSpace;
                    return convertFromByteToGiga(free);
                }
                return 0;
            }
            return 0;
        }

        public float hddTotal()//hdd total size
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    float totalsize = d.TotalSize;
                    return convertFromByteToGiga(totalsize);
                }
                return 0;
            }
            return 0;
        }

        public string systemName()//system name
        {
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                try
                {
                    return (string)mo["SystemName"];
                }
                catch
                {
                    return "N/D";
                }
            }
            return "N/D";
        }
        public float tempAprox(float s)//es 34,6 C
        {
            float f;
            f = s;
            
            f = f * 10;
            int i = Convert.ToInt32(f);
            f = i;
            f = f / 10;
            return f;
        }

        private void helpGpuTemp_Click(object sender, EventArgs e)
        {
            if (Settings.Language == 0)
            {
                MessageBox.Show("Too high temperature!");
            }
            else if (Settings.Language == 1)
            {
                MessageBox.Show("Temperatura troppo elevata!");
            }
        }

        private void crclprgrsbrRam_Click(object sender, EventArgs e)
        {
            ramclick = true;
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }

        private void crclprgrsbHdd_Click(object sender, EventArgs e)
        {
            hddclick = true;
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }

        private void crclrprgrsbrHddUsed_Click(object sender, EventArgs e)
        {
            hddclick = true;
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            timer1.Stop();
            this.Hide();
        }

        public static string systemLanguage(string[] eng, string[] ita, int n) // lingua di sistema
        {
            if (Settings.Language == 1)
            {
                return ita[n];
            }
            return eng[n];
        }

        public static string boolCelsius(bool C)
        {
            if (C == false)
            {
                return " °F";
            }
            return " °C";
        }

    }
}

