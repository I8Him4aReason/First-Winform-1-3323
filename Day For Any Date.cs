using System;                                         // בס"ד
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Winform_1_3323
{
    public partial class DayForAnyDate : Form
    {
        private int Padding1 = 30;
        public DayForAnyDate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Month.SelectedIndex = 0;

            pictureBox1.Location = new Point(pictureBox2.Left, pictureBox1.Top);
            Day.Location = new Point(pictureBox1.Left + Padding1, pictureBox1.Top + Padding1);
            pictureBox1.Size = new Size(Day.Width + 2 * Padding1, Day.Height + 2 * Padding1);

            CalcDay();
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcDay();
        }

        private void MonthDay_ValueChanged(object sender, EventArgs e)
        {
            CalcDay();
        }

        private void Year_ValueChanged(object sender, EventArgs e)
        {
            CalcDay();
        }

        private void CalcDay()
        {
            string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Shabbat" };
            int total = 0;
            int year = (int) Year.Value;

            bool leapyear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (Month.Text == "April" || Month.Text == "June" || Month.Text == "September" || Month.Text == "November")
                MonthDay.Maximum = 30;
            else if (Month.Text == "February")
            {
                if (leapyear) MonthDay.Maximum = 29;
                else MonthDay.Maximum = 28;
            }
            else MonthDay.Maximum = 31;

            total += (year % 100) + ((year % 100) / 4) + (7 - ((year / 100) % 4) * 2);
           
            switch (Month.Text)
            {
                case "January":
                    total += 6;
                    break;
                case "February":
                    total += 2;
                    break;
                case "March":
                    total += 2;
                    break;
                case "April":
                    total += 5;
                    break;
                case "May":
                    total += 0;
                    break;
                case "June":
                    total += 3;
                    break;
                case "July":
                    total += 5;
                    break;
                case "August":
                    total += 1;
                    break;
                case "September":
                    total += 4;
                    break;
                case "October":
                    total += 6;
                    break;
                case "November":
                    total += 2;
                    break;
                case "December":
                    total += 4;
                    break;
            }

            if (leapyear && (Month.Text == "January" || Month.Text == "February")) total--;
            
            total += (int) MonthDay.Value;

            Day.Text = Days[total % 7];

            pictureBox1.Size = new Size(Day.Width + 2 * Padding1, pictureBox1.Height);
        }

        private void Day_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}