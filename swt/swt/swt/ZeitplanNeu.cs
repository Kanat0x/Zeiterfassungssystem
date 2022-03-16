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
    public partial class ZeitplanNeu : Form
    {
        public ZeitplanNeu()
        {
            InitializeComponent();
            
        }

        private void ZeitplanNeu_Load(object sender, EventArgs e)
        {
            


        }

        private void startseiteButton_Click(object sender, EventArgs e)
        {
            new startseite().Show();
            this.Hide();
        }

        private void zeitplanButton_Click(object sender, EventArgs e)
        {
            new Zeitplan().Show();
            this.Hide();
        }

        private void statistikenButton_Click(object sender, EventArgs e)
        {
            new statistiken().Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void Donnerstag_button_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Montag_Button_Click(object sender, EventArgs e)
        {

        }

        private void Dienstag_button_Click(object sender, EventArgs e)
        {

        }

        private void Mittwoch_button_Click(object sender, EventArgs e)
        {

        }

        private void Freitag_button_Click(object sender, EventArgs e)
        {

        }

        private void Samstag_button_Click(object sender, EventArgs e)
        {

        }

        private void Sonntag_button_Click(object sender, EventArgs e)
        {

        }

        private void Total_button_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Sonntag_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Samstag_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Freitag_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Mittwoch_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Donnerstag_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dienstag_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Montag_1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setDefaultValue(out int day, string text)
        {
            /*if (Convert.ToInt32(text) > 10)
            {
                MessageBox.Show("Zu viele Stunden (max. 10h)");
            }*/
            if (text == "")
                day = 0;
            else
                day = Convert.ToInt32(text);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int Mo_1, Di_1, Mi_1, Do_1, Fr_1, Sa_1, So_1;
            setDefaultValue(out Mo_1, textBox_Montag_1.Text);
            setDefaultValue(out Di_1, textBox_Dienstag_1.Text);
            setDefaultValue(out Mi_1, textBox_Mittwoch_1.Text);
            setDefaultValue(out Do_1, textBox_Donnerstag_1.Text);
            setDefaultValue(out Fr_1, textBox_Freitag_1.Text);
            setDefaultValue(out Sa_1, textBox_Samstag_1.Text);
            setDefaultValue(out So_1, textBox_Sonntag_1.Text);
            
            textBox_Total_1.Text = Convert.ToString(Mo_1 + Di_1 + Mi_1 + Do_1 + Fr_1 + Sa_1 + So_1);



            int Total_1 = 0;

            Total_1 = Convert.ToInt32(textBox_Total_1.Text);
            startseite.workTime += Total_1;

            



        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] selectedWeek = { Mo_T.Text, Di_T.Text, Mi_T.Text, Do_T.Text, Fr_T.Text, Sa_T.Text, So_T.Text, };
            DateTime d = monthCalendar1.SelectionRange.Start;
            int currentMonth = d.Month;
            int currentDay = d.Day;


            int maxDaysMonth = monthDays[currentMonth-1];

            for (int i =0; i<selectedWeek.Length; i++)
            {
                if (currentDay == maxDaysMonth+1)
                {
                    currentDay = 1;
                    selectedWeek[i] = Convert.ToString(currentDay);
                    currentDay += 1;
                }
                else
                {
                    selectedWeek[i] = Convert.ToString(currentDay);
                    currentDay += 1;
                    
                }
            }

            Mo_T.Text = selectedWeek[0];
            Di_T.Text = selectedWeek[1];
            Mi_T.Text = selectedWeek[2];
            Do_T.Text = selectedWeek[3];
            Fr_T.Text = selectedWeek[4];
            Sa_T.Text = selectedWeek[5];
            So_T.Text = selectedWeek[6];







            //if (monthDays[selectedMonth] )




            /*
            string a = Convert.ToString(monthCalendar1.SelectionRange.Start);
            string[] getDate = a.Split(' ');
            string test = getDate[0];

            string[] splitDayMonthYear = test.Split('.');
            int tag;

            tag = Convert.ToInt32(splitDayMonthYear[0]);
            

            Mo_T.Text = Convert.ToString(tag);
            tag += 1;
            Di_T.Text = Convert.ToString(tag);
            tag += 1;
            Mi_T.Text = Convert.ToString(tag);
            tag += 1;
            Do_T.Text = Convert.ToString(tag);
            tag += 1;
            Fr_T.Text = Convert.ToString(tag);
            tag += 1;
            Sa_T.Text = Convert.ToString(tag);
            tag += 1;
            So_T.Text = Convert.ToString(tag);
            */
        }
    }
}
