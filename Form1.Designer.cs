namespace SchedulerFIX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menu_kalender = new ToolStripMenuItem();
            jamToolStripMenuItem = new ToolStripMenuItem();
            menu_jadwal = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripSeparator7 = new ToolStripSeparator();
            menu_pengaturan = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            submenu_notifikasi = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            submenu_bahasa = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            zonaWaktuToolStripMenuItem = new ToolStripMenuItem();
            menu_tentang = new ToolStripMenuItem();
            laporDanMasukanToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tentangToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_kalender, jamToolStripMenuItem, menu_jadwal, menu_pengaturan, menu_tentang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(475, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_kalender
            // 
            menu_kalender.Name = "menu_kalender";
            menu_kalender.Size = new Size(96, 29);
            menu_kalender.Text = "&Kalender";
            menu_kalender.Click += kalenderToolStripMenuItem_Click;
            // 
            // jamToolStripMenuItem
            // 
            jamToolStripMenuItem.Name = "jamToolStripMenuItem";
            jamToolStripMenuItem.Size = new Size(59, 29);
            jamToolStripMenuItem.Text = "&Jam";
            jamToolStripMenuItem.Click += jamToolStripMenuItem_Click;
            // 
            // menu_jadwal
            // 
            menu_jadwal.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator6, toolStripSeparator7 });
            menu_jadwal.Name = "menu_jadwal";
            menu_jadwal.Size = new Size(80, 29);
            menu_jadwal.Text = "&Jadwal";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(267, 6);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(267, 6);
            // 
            // menu_pengaturan
            // 
            menu_pengaturan.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, submenu_notifikasi, toolStripSeparator3, submenu_bahasa, toolStripSeparator4, zonaWaktuToolStripMenuItem });
            menu_pengaturan.Name = "menu_pengaturan";
            menu_pengaturan.Size = new Size(117, 29);
            menu_pengaturan.Text = "&Pengaturan";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(267, 6);
            // 
            // submenu_notifikasi
            // 
            submenu_notifikasi.Name = "submenu_notifikasi";
            submenu_notifikasi.Size = new Size(270, 34);
            submenu_notifikasi.Text = "&Notifikasi";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(267, 6);
            // 
            // submenu_bahasa
            // 
            submenu_bahasa.Name = "submenu_bahasa";
            submenu_bahasa.Size = new Size(270, 34);
            submenu_bahasa.Text = "&Bahasa";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(267, 6);
            // 
            // zonaWaktuToolStripMenuItem
            // 
            zonaWaktuToolStripMenuItem.Name = "zonaWaktuToolStripMenuItem";
            zonaWaktuToolStripMenuItem.Size = new Size(270, 34);
            zonaWaktuToolStripMenuItem.Text = "&Zona Waktu";
            // 
            // menu_tentang
            // 
            menu_tentang.DropDownItems.AddRange(new ToolStripItem[] { laporDanMasukanToolStripMenuItem, toolStripSeparator1, tentangToolStripMenuItem });
            menu_tentang.Name = "menu_tentang";
            menu_tentang.Size = new Size(92, 29);
            menu_tentang.Text = "&Bantuan";
            // 
            // laporDanMasukanToolStripMenuItem
            // 
            laporDanMasukanToolStripMenuItem.Name = "laporDanMasukanToolStripMenuItem";
            laporDanMasukanToolStripMenuItem.Size = new Size(270, 34);
            laporDanMasukanToolStripMenuItem.Text = "&Lapor dan Masukan";
            laporDanMasukanToolStripMenuItem.Click += laporDanMasukanToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // tentangToolStripMenuItem
            // 
            tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            tentangToolStripMenuItem.Size = new Size(270, 34);
            tentangToolStripMenuItem.Text = "&Tentang";
            tentangToolStripMenuItem.Click += tentangToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(475, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Halaman Utama";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kalenderToolStripMenuItem;
        private ToolStripMenuItem pengaturanToolStripMenuItem;
        private ToolStripMenuItem bantuanToolStripMenuItem;
        private ToolStripMenuItem bahasaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem menu_kalender;
        public ToolStripMenuItem menu_jadwal;
        public ToolStripMenuItem menu_pengaturan;
        public ToolStripMenuItem menu_tentang;
        public ToolStripMenuItem submenu_notifikasi;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        public ToolStripMenuItem submenu_bahasa;
        private ToolStripMenuItem zonaWaktuToolStripMenuItem;
        private ToolStripMenuItem laporDanMasukanToolStripMenuItem;
        private ToolStripMenuItem jamToolStripMenuItem;
        private ToolStripMenuItem tentangToolStripMenuItem;
    }
}
