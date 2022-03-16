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
    public partial class SeiteSupervisor : Form
    {
        public static int listeZahl = 0;

        public SeiteSupervisor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SeiteSupervisor_Load(object sender, EventArgs e)
        {

        }

        private void hinzufuegen_Click(object sender, EventArgs e)
        {
            listeZahl = 1;
            if (addName.Text != "")
            {
                //loginWindow.namen.Add(addName.Text);
                
                loginWindow.MitarbeiterList.Add(addName.Text, addID.Text);
                MessageBox.Show("Mitarbeiter erfolgreich hinzugefügt");

            }

        }

        private void addName_TextChanged(object sender, EventArgs e)
        {

        }

        private void startseiteBeenden_Click(object sender, EventArgs e)
        {
            
    }

        private void startseiteAbmelden_Click(object sender, EventArgs e)
        {
            new loginWindow().Show();
            this.Hide();
        }

        

        private void addID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
