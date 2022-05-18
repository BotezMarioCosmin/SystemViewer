using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemViewer
{
    public partial class Form1 : Form
    {
        Home Home = new Home();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//per bordi tondi
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // coordinata x alto sinistra
            int nTopRect,      // coordinata y alto sinistra
            int nRightRect,    // coordinata x basso destra
            int nBottomRect,   // coordinata y basso destra
            int nWidthEllipse, // larghezza
            int nHeightEllipse // altezza
        );
        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 75, 75));//criteri dei bordi
        }
        private void startupTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                startupTimer.Stop();
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
