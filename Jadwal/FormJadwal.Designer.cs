namespace SchedulerFIX.Jadwal
{
    partial class FormJadwal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTEHjadwal = new GroupBox();
            groupBoxTampilanJadwal = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBoxTEHjadwal.SuspendLayout();
            groupBoxTampilanJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTEHjadwal
            // 
            groupBoxTEHjadwal.Controls.Add(label3);
            groupBoxTEHjadwal.Controls.Add(label2);
            groupBoxTEHjadwal.Controls.Add(label1);
            groupBoxTEHjadwal.Controls.Add(button3);
            groupBoxTEHjadwal.Controls.Add(button2);
            groupBoxTEHjadwal.Controls.Add(button1);
            groupBoxTEHjadwal.Controls.Add(textBox3);
            groupBoxTEHjadwal.Controls.Add(textBox2);
            groupBoxTEHjadwal.Controls.Add(textBox1);
            groupBoxTEHjadwal.Location = new Point(12, 12);
            groupBoxTEHjadwal.Name = "groupBoxTEHjadwal";
            groupBoxTEHjadwal.Size = new Size(470, 639);
            groupBoxTEHjadwal.TabIndex = 0;
            groupBoxTEHjadwal.TabStop = false;
            groupBoxTEHjadwal.Text = "Tambah Hapus Edit Jadwal";
            // 
            // groupBoxTampilanJadwal
            // 
            groupBoxTampilanJadwal.Controls.Add(dataGridView1);
            groupBoxTampilanJadwal.Location = new Point(488, 12);
            groupBoxTampilanJadwal.Name = "groupBoxTampilanJadwal";
            groupBoxTampilanJadwal.Size = new Size(575, 639);
            groupBoxTampilanJadwal.TabIndex = 1;
            groupBoxTampilanJadwal.TabStop = false;
            groupBoxTampilanJadwal.Text = "Daftar Jadwal";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(569, 609);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(27, 553);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(173, 553);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(318, 553);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 85);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 6;
            label1.Text = "Nama Jadwal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 159);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Kapan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 231);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 8;
            label3.Text = "Deskripsi";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Jadwal";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Kapan Jadwal";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Deskripsi Jadwal";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // FormJadwal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 663);
            Controls.Add(groupBoxTampilanJadwal);
            Controls.Add(groupBoxTEHjadwal);
            Name = "FormJadwal";
            Text = "FormJadwal";
            Load += FormJadwal_Load;
            groupBoxTEHjadwal.ResumeLayout(false);
            groupBoxTEHjadwal.PerformLayout();
            groupBoxTampilanJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTEHjadwal;
        private GroupBox groupBoxTampilanJadwal;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}