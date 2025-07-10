namespace track_e_progress_bar
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
            trackBarAtiva = new TrackBar();
            progressBarPassivo = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).BeginInit();
            SuspendLayout();
            // 
            // trackBarAtiva
            // 
            trackBarAtiva.Location = new Point(41, 38);
            trackBarAtiva.Maximum = 100;
            trackBarAtiva.Name = "trackBarAtiva";
            trackBarAtiva.Size = new Size(440, 56);
            trackBarAtiva.TabIndex = 0;
            trackBarAtiva.ValueChanged += trackBarAtiva_ValueChanged;
            // 
            // progressBarPassivo
            // 
            progressBarPassivo.Location = new Point(41, 100);
            progressBarPassivo.Name = "progressBarPassivo";
            progressBarPassivo.Size = new Size(440, 29);
            progressBarPassivo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBarPassivo);
            Controls.Add(trackBarAtiva);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarAtiva;
        private ProgressBar progressBarPassivo;
    }
}