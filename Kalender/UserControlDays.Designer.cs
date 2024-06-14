namespace SchedulerFIX.Kalender
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelKL = new Panel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            panelKL.SuspendLayout();
            SuspendLayout();
            // 
            // panelKL
            // 
            panelKL.BackColor = Color.White;
            panelKL.Controls.Add(checkBox1);
            panelKL.Controls.Add(label1);
            panelKL.Dock = DockStyle.Fill;
            panelKL.Location = new Point(1, 1);
            panelKL.Name = "panelKL";
            panelKL.Size = new Size(78, 78);
            panelKL.TabIndex = 0;
            
            panelKL.Paint += panelKL_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(9, 8);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelKL);
            Name = "UserControlDays";
            Padding = new Padding(1);
            Size = new Size(80, 80);
            panelKL.ResumeLayout(false);
            panelKL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelKL;
        private Label label1;
        private CheckBox checkBox1;
    }
}
