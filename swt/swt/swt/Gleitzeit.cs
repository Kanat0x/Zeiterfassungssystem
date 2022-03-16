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
    public partial class gleitzeiten : Form
    {
        public gleitzeiten()
        {
            InitializeComponent();
        }

        private void startseiteButton_Click(object sender, EventArgs e)
        {
            new startseite().Show();
            this.Hide();
        }

        private void urlaubButton_Click(object sender, EventArgs e)
        {
            new urlaub().Show();
            this.Hide();
        }

        private void urlaubAbmelden_Click(object sender, EventArgs e)
        {
            new loginWindow().Show();
            this.Hide();
        }

        private void urlaubBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statistikenButton_Click(object sender, EventArgs e)
        {
            new statistiken().Show();
            this.Hide();
        }

        private void gleitzeiten_Load(object sender, EventArgs e)
        {

        }
    }
}
