namespace SchedulerFIX
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
            label1 = new Label();
            ContainerDays = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonPrev = new Button();
            buttonNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Minggu";
            // 
            // ContainerDays
            // 
            ContainerDays.Location = new Point(12, 54);
            ContainerDays.Name = "ContainerDays";
            ContainerDays.Size = new Size(758, 639);
            ContainerDays.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 26);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Senin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 26);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 3;
            label3.Text = "Selasa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 26);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 4;
            label4.Text = "Rabu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 26);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 5;
            label5.Text = "Kamis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 26);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "Jumat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(668, 26);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 7;
            label7.Text = "Sabtu";
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(785, 585);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(112, 34);
            buttonPrev.TabIndex = 8;
            buttonPrev.Text = "Previous";
            buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(785, 659);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(112, 34);
            buttonNext.TabIndex = 9;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // FormKalenderBaru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 705);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ContainerDays);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKalenderBaru";
            Text = "FormKalenderBaru";
            Load += FormKalenderBaru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel ContainerDays;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonPrev;
        private Button buttonNext;
    }
}