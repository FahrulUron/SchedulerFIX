using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerFIX.Kalender
{
    public partial class FormKalenderBaru : Form
    {
        public static int _year, _month;
        public FormKalenderBaru()
        {
            InitializeComponent();
        }

        private void FormKalenderBaru_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }
        private void showDays(int month, int year)
        {
            panelKL.Controls.Clear();
            _year = year; _month = month;
            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbmonth.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);    
            int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d")) + 1;
          //  for (int i = 1; 1 > week; i++)
                for (int i = 1; i <= week; i++)
                {
                UserControlDays uc = new UserControlDays("");
                panelKL.Controls.Add(uc);
            
            }
            //for (int i = 1; 1 > day; i++)
             // for (int i = 1; i <= day; i++)

            //{
              //UserControlDays uc = new UserControlDays(1 + "");
              //panelKL.Controls.Add(uc);

//            }
            for (int i = 1; i <= day; i++)
            {
                UserControlDays uc = new UserControlDays(i.ToString()); // Set _day to current day
                panelKL.Controls.Add(uc);
            }

        }
    }
}
