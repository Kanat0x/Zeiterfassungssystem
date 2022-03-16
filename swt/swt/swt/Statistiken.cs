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
    public partial class statistiken : Form
    {
        public statistiken()
        {
            InitializeComponent();
            idFeld.Text = Convert.ToString(startseite.workTime);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startseiteButton_Click(object sender, EventArgs e)
        {
            new startseite().Show();
            this.Hide();
        }

        private void statistikenButton_Click(object sender, EventArgs e)
        {

        }

        private void gleitzeitenButton_Click(object sender, EventArgs e)
        {
            new gleitzeiten().Show();
            this.Hide();
        }

        private void urlaubButton_Click(object sender, EventArgs e)
        {
            new urlaub().Show();
            this.Hide();
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

        private void zeitplanButton_Click(object sender, EventArgs e)
        {
            
        }

        private void statistiken_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void idFeld_Click(object sender, EventArgs e)
        {

        }
    }
}
