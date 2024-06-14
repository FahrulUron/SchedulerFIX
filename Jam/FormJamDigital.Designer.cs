namespace SchedulerFIX.Jam
{
    partial class FormJamDigital
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
            components = new System.ComponentModel.Container();
            labeljamdigital = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labeljamdigital
            // 
            labeljamdigital.Font = new Font("Britannic Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeljamdigital.Location = new Point(85, 143);
            labeljamdigital.Name = "labeljamdigital";
            labeljamdigital.Size = new Size(249, 65);
            labeljamdigital.TabIndex = 0;
            labeljamdigital.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormJamDigital
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 337);
            Controls.Add(labeljamdigital);
            Name = "FormJamDigital";
            Text = "FormJamDigital";
            Load += FormJamDigital_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labeljamdigital;
        private System.Windows.Forms.Timer timer1;
    }
}