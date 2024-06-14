using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerFIX.Kalender
{

    public partial class UserControlDays : UserControl
    {
        string _day, date, weekday;
        public UserControlDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();
        }


     

        private void panelKL_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = true;
                this.BackColor = Color.White;
            }
        }
    }
}
