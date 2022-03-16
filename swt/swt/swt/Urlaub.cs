using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swt
{
    public partial class urlaub : Form
    {
        public urlaub()
        {
            InitializeComponent();
        }

        private void startseiteButton_Click(object sender, EventArgs e)
        {
            new startseite().Show();
            this.Hide();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void urlaub_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void startseiteAbmelden_Click(object sender, EventArgs e)
        {
            new loginWindow().Show();
            this.Hide();
        }

        private void startseiteBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gleitzeitenButton_Click(object sender, EventArgs e)
        {
            new gleitzeiten().Show();
            this.Hide();
        }

        private void urlaubButton_Click(object sender, EventArgs e)
        {
          
        }

        private void statistikenButton_Click(object sender, EventArgs e)
        {
            new statistiken().Show();
            this.Hide();
        }
    }
}
