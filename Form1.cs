using SchedulerFIX;


namespace SchedulerFIX
{
    public partial class Form1 : Form
    {
        //1.buat form menjadi objek
        FormKalender kalender;


        //2. buat prosedur close objek/ close kalender
        void kalender_FormClosed(object sender, FormClosedEventArgs e)
        {
            kalender = null;
        }
        //Menu Tentang
        FormTentang tentang;
        void tentang_FormClosed(Object sender, FormClosedEventArgs e)
        {
            tentang = null;
        }

        //menu jam
        FormJam jam;
        void jam_FormClosed(Object sender, FormClosedEventArgs e)
        {
            jam = null;
        }

        //Menu Lapor dan Masukan
        FormLaporMasukan lapormasukan;
        void lapormasukan_FormClosed(Object sender, FormClosedEventArgs e)
        {
            lapormasukan = null;
        }

        /// <summary>
        /// 
        /// </summary>
        FormKalenderBaru kalenderbaru;
        void kalenderbaru_FormClosed(Object sender, FormClosedEventArgs e)
        {
            kalenderbaru = null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void kalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kalenderbaru == null)
            {
                kalenderbaru = new FormKalenderBaru();
                kalenderbaru.MdiParent = this;

                kalenderbaru.FormClosed += new FormClosedEventHandler
                    (kalenderbaru_FormClosed);
                kalenderbaru.Show();
            }

            else
            {
                kalenderbaru.Activate();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void laporDanMasukanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lapormasukan == null)
            {
                lapormasukan = new FormLaporMasukan();
                lapormasukan.MdiParent = this;

                lapormasukan.FormClosed += new FormClosedEventHandler
                    (lapormasukan_FormClosed);
                lapormasukan.Show();
            }

            else
            {
                lapormasukan.Activate();
            }
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tentang == null)
            {
                tentang = new FormTentang();
                tentang.MdiParent = this;

                tentang.FormClosed += new FormClosedEventHandler
                    (tentang_FormClosed);
                tentang.Show();
            }

            else
            {
                tentang.Activate();
            }
        }

        private void jamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jam == null)
            {
                jam = new FormJam();
                jam.MdiParent = this;

                jam.FormClosed += new FormClosedEventHandler
                    (jam_FormClosed);
                jam.Show();
            }

            else
            {
                jam.Activate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
