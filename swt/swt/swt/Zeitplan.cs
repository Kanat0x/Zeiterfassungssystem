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
    public partial class Zeitplan : Form
    {
        
        
        public Zeitplan()
        {
            InitializeComponent();
            this.monthCalendar1.MaxSelectionCount = 5 ;
            label3.Text = ""+ loginWindow.currentUser;
            
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            string startDate = Convert.ToString(monthCalendar1.SelectionRange.Start);
            string endDate = Convert.ToString(monthCalendar1.SelectionRange.End);

            // START DATE
            //remove time
            string[] splittedStartDate = startDate.Split(' ');
            string StartDateD = splittedStartDate[0];
            //get date
            string[] splittedStartDateD = StartDateD.Split('.');
            int startDay= Convert.ToInt32(splittedStartDateD[0]);
            int startMonth = Convert.ToInt32(splittedStartDateD[1]);
            int startYear = Convert.ToInt32(splittedStartDateD[2]);
            //get weekday
            DateTime startWeekday = new DateTime(startYear, startMonth, startDay);
            string sWeekday = startWeekday.ToString("dddd");


            // END DATE
            //remove time
            string[] splittedEndDate = endDate.Split(' ');
            string EndDateD = splittedEndDate[0];
            //get date
            string[] splittedEndDateD = EndDateD.Split('.');
            int endDay = Convert.ToInt32(splittedEndDateD[0]);
            int endMonth = Convert.ToInt32(splittedEndDateD[1]);
            int endYear = Convert.ToInt32(splittedEndDateD[2]);
            //get weekday
            DateTime endWeekday = new DateTime(endYear, endMonth, endDay);
            string eWeekday = endWeekday.ToString("dddd");


            string [] Wochentag = { tag1Wochentag.Text, tag2Wochentag.Text, tag3Wochentag.Text, tag4Wochentag.Text, tag5Wochentag.Text };
            string[] Wochendatum = {tag1Wochendatum.Text, tag2Wochendatum.Text, tag3Wochendatum.Text, tag4Wochendatum.Text, tag5Wochendatum.Text};

            string[] days = { "Montag", "Dienstag","Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            string nextDay = "";
            int IndexOfCurrentDay= 0;

            //get Index of current day
            for (int i = 0; i < days.Length; i++)
            {
                if (sWeekday == days[i])
                {
                    IndexOfCurrentDay = i;
                }

            }

            for (int i = 0; i < monthCalendar1.MaxSelectionCount; i++)
            {
                // Wenn Sonntag
                if (IndexOfCurrentDay == 6)
                {
                    //Sonntag
                    Wochentag[i] = days[IndexOfCurrentDay];
                    nextDay = days[0];
                    IndexOfCurrentDay = 0;
                }
                // 1. Tag
                else if (i == 0)
                {
                    Wochentag[i] = sWeekday;
                    IndexOfCurrentDay++;

                }
                //Andere Tage
                else
                {
                    Wochentag[i] = days[IndexOfCurrentDay];
                    IndexOfCurrentDay++;
                }
            }


            tag1Wochentag.Text = Wochentag[0];
            tag2Wochentag.Text = Wochentag[1];
            tag3Wochentag.Text = Wochentag[2];
            tag4Wochentag.Text = Wochentag[3];
            tag5Wochentag.Text = Wochentag[4];


            //display day

            //Wochentag
            
            string a = Convert.ToString(monthCalendar1.SelectionRange.Start);
            string [] getDate = a.Split(' ');
            string test = getDate[0];

            string [] splitDayMonthYear = test.Split('.');
            int tag;

            tag = Convert.ToInt32(splitDayMonthYear[0]);



            /*
            for (int i  = 0; i < monthCalendar1.MaxSelectionCount; i++)
            {

            }
            */
            
            

            tag1Wochendatum.Text = Convert.ToString(tag);
            tag += 1;
            tag2Wochendatum.Text = Convert.ToString(tag);
            tag += 1;
            tag3Wochendatum.Text = Convert.ToString(tag);
            tag += 1;
            tag4Wochendatum.Text = Convert.ToString(tag);
            tag += 1;
            tag5Wochendatum.Text = Convert.ToString(tag);





            //To display single selected of date
            //MonthCalendar1.MaxSelectionCount = 1;

            //To display single selected of date use MonthCalendar1.SelectionRange.Start/ MonthCalendarSelectionRange.End
            //label2.Text = "" + monthCalendar1.SelectionRange.Start;
            //DateTime dateValue = new DateTime(2022, 4, 22);
            //label2.Text = Convert.ToString(((int)dateValue.DayOfWeek));


            /*
            //Wochentag
            string a = Convert.ToString(monthCalendar1.SelectionRange.Start);
            string[] splittedTime = a.Split(' ');
            string test = splittedTime[0];

            string[] test2 = test.Split('.');
            int jahr, monat, tag;

            jahr = Convert.ToInt32(test2[2]);
            monat = Convert.ToInt32(test2[1]);
            tag = Convert.ToInt32(test2[0]);

            DateTime dateValue = new DateTime(jahr, monat, tag);

            label2.Text = dateValue.ToString("dddd");
            label9.Text = Convert.ToString(tag);
            */


        }
            private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.textBox1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zeitplan_Load(object sender, EventArgs e)
        {
            // Do not circle today's date.
            this.monthCalendar1.ShowTodayCircle = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
