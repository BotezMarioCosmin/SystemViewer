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
    public partial class Informations : Form
    {
        string[] enHome = { "Home", "Settings", "GPU error", "N/D means No Data have been found.", "More features coming in the next update...",
        "GPU temperature and Vram is currently only supported by Nvidia video cards.", "Created by:  ", "INFORMATIONS",
        "Boost mode :   temporarily let the processor consume more energy"+Environment.NewLine+" in exchange for a temporary increase in processing speed."};
        string[] itHome = { "Home", "Impostazioni", "Errore GPU", "N/D significa che l'informazione non è disponibile.", "Più caratteristiche saranno disponibili nei prossimi aggiornamenti...",
        "La temperatura della GPU e la Vram è attualmente supportata solo da schede video Nvidia.", "Realizzato da:  ", "INFORMAZIONI",
        "Boost mode :   consente temporaneamente al processore di consumare"+Environment.NewLine+"più energia in cambio di un aumento temporaneo della velocità di elaborazione."};
        public Informations()
        { 
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            this.Size = this.Size;
            this.Location = this.Location;
            this.Show();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            if (Home.forminf == true)
            {
                lbl2.Text = systemLanguage(enHome, itHome, 2) + ":  " + "''" + Home.gpuErrorMessage + "''";
            }
            else
            {
                if (Settings.Language == 1)
                {
                    lbl2.Text = systemLanguage(enHome, itHome, 2) + ":  " + "Nessun errore rilevato";
                }
                else
                {
                    lbl2.Text = systemLanguage(enHome, itHome, 2) + ":  " + "No errors detected";
                }

            }

            lbl4.Text = systemLanguage(enHome, itHome, 7);
            homeToolStripMenuItem.Text = systemLanguage(enHome, itHome, 0);
            settingsToolStripMenuItem.Text = systemLanguage(enHome, itHome, 1);
            lbl.Text = systemLanguage(enHome, itHome, 6) + " BOTEZ  MARIO  COSMIN";
            lbl3.Text = systemLanguage(enHome, itHome, 5);
            lbl1.Text = systemLanguage(enHome, itHome, 3);
            lbl0.Text = systemLanguage(enHome, itHome, 4);
            lbl5.Text = systemLanguage(enHome, itHome, 8);
            if (Settings.Language == 0)
            {
                lbl7.Text = "CPU pie chart color is the color used by the processor manufacturer.";
            }
            else
                lbl7.Text = "Il colore del grafico a torta della CPU è il colore della casa produttrice del processore.";

            if (Settings.FormColor == 0)
            {
                Color color = Color.DodgerBlue;
                lbl4.ForeColor = color;
                lbl3.ForeColor = color;
                lbl2.ForeColor = color;
                lbl1.ForeColor = color;
                lbl0.ForeColor = color;
                lbl5.ForeColor = color;
                lbl.ForeColor = color;
                lbl7.ForeColor = color;
                this.BackColor = Color.MidnightBlue;
                menuStrip1.BackColor = Color.DarkSlateBlue;
            }
            else if (Settings.FormColor == 1)
            {
                Color color = Color.FromArgb(0, 200, 0);
                lbl4.ForeColor = color;
                lbl3.ForeColor = color;
                lbl2.ForeColor = color;
                lbl1.ForeColor = color;
                lbl0.ForeColor = color;
                lbl5.ForeColor = color;
                lbl.ForeColor = color;
                lbl7.ForeColor = color;
                this.BackColor = Color.FromArgb(34, 36, 49);
                menuStrip1.BackColor = Color.FromArgb(34, 96, 79);
            }
            else if (Settings.FormColor == 2)
            {
                Color color = Color.FromArgb(244, 226, 198);
                lbl4.ForeColor = color;
                lbl3.ForeColor = color;
                lbl2.ForeColor = color;
                lbl1.ForeColor = color;
                lbl0.ForeColor = color;
                lbl5.ForeColor = color;
                lbl.ForeColor = color;
                lbl7.ForeColor = color;
                this.BackColor = Color.FromArgb(100, 50, 80);
                menuStrip1.BackColor = Color.FromArgb(130, 80, 90);
            }
            else if (Settings.FormColor == 3)
            {
                Color color = Color.FromArgb(255, 255, 255);
                lbl4.ForeColor = color;
                lbl3.ForeColor = color;
                lbl2.ForeColor = color;
                lbl1.ForeColor = color;
                lbl0.ForeColor = color;
                lbl5.ForeColor = color;
                lbl.ForeColor = color;
                lbl7.ForeColor = color;
                this.BackColor = Color.FromArgb(40, 40, 40);
                menuStrip1.BackColor = Color.FromArgb(80, 80, 80);
            }


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            Home.Left = this.Left;
            Home.Top = this.Top;
            Home.Size = this.Size;
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Size = this.Size;
            this.Hide();
        }
    }
}
