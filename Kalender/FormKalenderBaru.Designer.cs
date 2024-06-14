namespace SchedulerFIX.Kalender
{
    partial class FormKalenderBaru
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
            panelKL = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbmonth = new Label();
            SuspendLayout();
            // 
            // panelKL
            // 
            panelKL.Location = new Point(12, 65);
            panelKL.Name = "panelKL";
            panelKL.Size = new Size(631, 610);
            panelKL.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(101, 40);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Senin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 3;
            label1.Text = "Minggu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(187, 40);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Selasa";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(273, 40);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 5;
            label4.Text = "Rabu";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(358, 40);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Kamis";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(444, 40);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 7;
            label6.Text = "Jumat";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(530, 40);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 8;
            label7.Text = "Sabtu";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(649, 544);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(649, 630);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbmonth
            // 
            lbmonth.AutoSize = true;
            lbmonth.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbmonth.Location = new Point(649, 9);
            lbmonth.Name = "lbmonth";
            lbmonth.Size = new Size(130, 54);
            lbmonth.TabIndex = 11;
            lbmonth.Text = "Bulan";
            lbmonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormKalenderBaru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 677);
            Controls.Add(lbmonth);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panelKL);
            Name = "FormKalenderBaru";
            Text = "FormKalenderBaru";
            Load += FormKalenderBaru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelKL;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label lbmonth;
    }
}