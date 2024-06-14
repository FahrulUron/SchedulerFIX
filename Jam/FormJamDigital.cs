using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerFIX.Jam
{
    public partial class FormJamDigital : Form
    {
        private DateTime jamdigital;
        public FormJamDigital()
        {
            InitializeComponent();
        }

        private void FormJamDigital_Load(object sender, EventArgs e)
        {
            jamdigital = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jamdigital = jamdigital.AddSeconds(1);
            labeljamdigital.Text = string.Format("{0:HH:mm:ss}", jamdigital);
        }
    }
}
