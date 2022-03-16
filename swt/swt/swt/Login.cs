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
    


    public partial class loginWindow : Form
    {
        public static string currentID;
        public static string currentUser;
        public static List<string> namen = new List<string> { "Atakan Gökdinc", "Emre Bayram", "Lennard Schatz", "Marvin Schatz", "Halime Cengiz", "" };
        public static Dictionary<string, string> MitarbeiterList;
        

        //public static string[,] array2D = new string[,] { { "Emre Bayram", "32" }, { "Marvin Schatz", "321" }};
        //public static string[,] array2D = new string[1, 100];

        public loginWindow()
        {
           
            if (SeiteSupervisor.listeZahl == 0)

            {
                MitarbeiterList = new Dictionary<string, string>
                {
                    { "Emre Bayram", "123" },
                    { "Marvin Schatz", "311" }

                };

            }
        

            InitializeComponent();

            
            
        }

        



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void loginWindow_Load(object sender, EventArgs e)
        {

        }


        private void anmeldeButton_Click(object sender, EventArgs e)
        {
            
            string password = "";
            namen.Add("Test");




            // Supervisor Seite
            if (eingabeName.Text == "Admin" && eingabePassword.Text == "admin")

            {
                new SeiteSupervisor().Show();
                this.Hide();

            }

            // Mitarbeiter Login
            //else if (namen.Contains(eingabeName.Text) && eingabePassword.Text == password)
            else if (MitarbeiterList.Keys.Contains(eingabeName.Text) && eingabePassword.Text == password)
            {
                currentUser = eingabeName.Text;
                currentID = MitarbeiterList[currentUser];
                new startseite().Show();

                this.Hide();
                return;

            }
            // Wrong username or password
            else
            {

                MessageBox.Show("Benutzername oder Passwort falsch!");
                eingabeName.Clear();
                eingabePassword.Clear();
                eingabeName.Focus();
            }



        }

        private void eingabeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
