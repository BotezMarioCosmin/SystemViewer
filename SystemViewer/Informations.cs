using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SystemViewer
{
    public partial class Informations : Form
    {
        int a = 0;
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


    }
}
