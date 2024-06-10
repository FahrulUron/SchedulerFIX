using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerFIX
{
    public partial class FormKalenderBaru : Form
    {
        public FormKalenderBaru()
        {
            InitializeComponent();
        }

        private void FormKalenderBaru_Load(object sender, EventArgs e)
        {
            Displays();
        }

        private void Displays()
        {
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(now.Year,now.Month,1);

            int days = DateTime.DaysInMonth(now.Year,now.Month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlanks ucblank = new UserControlBlanks();
                ContainerDays.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdays = new UserControlDay();
                ucdays.days(i);
                ContainerDays.Controls.Add(ucdays);
            }



        }

       
    }
}
