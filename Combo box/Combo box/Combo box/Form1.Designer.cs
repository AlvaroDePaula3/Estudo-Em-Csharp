namespace Combo_box
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
            comboBoxEpic = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxEpic
            // 
            comboBoxEpic.FormattingEnabled = true;
            comboBoxEpic.Items.AddRange(new object[] { "Troy Saga", "Cyclops Saga", "Storm Saga", "Circe Saga", "Underworld Saga", "Thunder Saga", "Wisdom Saga", "Venegeance Saga", "Ithaca Saga" });
            comboBoxEpic.Location = new Point(88, 40);
            comboBoxEpic.Name = "comboBoxEpic";
            comboBoxEpic.Size = new Size(364, 28);
            comboBoxEpic.TabIndex = 0;
            comboBoxEpic.SelectedIndexChanged += comboBoxEpic_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxEpic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxEpic;
    }
}