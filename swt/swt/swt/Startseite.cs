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
using System.Threading;

namespace swt
{


    public partial class startseite : Form
    {

        private bool benachrichtigt = false;
        private bool eingestempelt = false;
        private Stopwatch stopWatch = new Stopwatch();
        public static float workTime;
        public startseite()
        {
            InitializeComponent();
            nameFeld.Text = loginWindow.currentUser;
            idFeld.Text = Convert.ToString(loginWindow.currentID);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new gleitzeiten().Show();
            this.Hide();
        }

        private void startseite_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new loginWindow().Show();
            this.Hide();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eingestempelt == true)
            {
                MessageBox.Show("Sie sind bereits eingestempelt.");
            }

            if (eingestempelt == false) 
            {
               MessageBox.Show("Erfolgreich eingestempelt");
                eingestempelt = true;
                
                stopWatch.Start();
                
                
                
            }
        }

        private void startseiteBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void urlaubButton_Click(object sender, EventArgs e)
        {
            new urlaub().Show();
            this.Hide();
        }

        private void statistikenButton_Click(object sender, EventArgs e)
        {
            new statistiken().Show();
            this.Hide();
        }

        private void zeitplanButton_Click(object sender, EventArgs e)
        {
            new ZeitplanNeu().Show();
            this.Hide();
        }

        private void krankmeldeButton_Click(object sender, EventArgs e)
        {
            

            if (benachrichtigt == true)
            {
                MessageBox.Show("Supervisor wurde bereits benachrichtigt. Sie können den Supervisor morgen erneut benachrichtigen.");
            }

            
            if (benachrichtigt == false)
            {
                MessageBox.Show("Supervisor wurde benachrichtigt");
                benachrichtigt = true;
            }
            
            
        }

        private void ausstempelButton_Click(object sender, EventArgs e)
        {
            if (eingestempelt == false)
            {
                MessageBox.Show("Sie sind noch nicht eingestempelt.");
            }

            if (eingestempelt == true)
            {

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds);

                

                if (ts.Hours == 0)
                {
                    MessageBox.Show("Erfolgreich ausgestempelt " + ts.Seconds + " Minuten gearbeitet");
                }
                
                
                //MessageBox.Show("Erfolgreich ausgestempelt." + elapsedTime + "gearbeitet");
                eingestempelt = false;
                workTime += ts.Seconds;
                
            }

            
        }

        private void nameFeld_Click(object sender, EventArgs e)
        {

        }

        private void nameStartseite_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
