namespace calendarioData
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
            calendarioMensal = new MonthCalendar();
            SuspendLayout();
            // 
            // calendarioMensal
            // 
            calendarioMensal.Location = new Point(56, 40);
            calendarioMensal.MaxDate = new DateTime(2250, 12, 31, 0, 0, 0, 0);
            calendarioMensal.MaxSelectionCount = 4;
            calendarioMensal.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            calendarioMensal.Name = "calendarioMensal";
            calendarioMensal.SelectionRange = new SelectionRange(new DateTime(2000, 1, 1, 0, 0, 0, 0), new DateTime(2000, 1, 5, 0, 0, 0, 0));
            calendarioMensal.TabIndex = 0;
            calendarioMensal.DateSelected += calendarioMensal_DateSelected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calendarioMensal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar calendarioMensal;
    }
}