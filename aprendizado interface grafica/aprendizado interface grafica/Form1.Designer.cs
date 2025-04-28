namespace aprendizado_interface_grafica
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
            botaoInicial = new Button();
            labelInicial = new Label();
            botaoMessageBox = new Button();
            SuspendLayout();
            // 
            // botaoInicial
            // 
            botaoInicial.BackColor = SystemColors.MenuHighlight;
            botaoInicial.Location = new Point(28, 78);
            botaoInicial.Name = "botaoInicial";
            botaoInicial.Size = new Size(283, 128);
            botaoInicial.TabIndex = 0;
            botaoInicial.Text = "botão interface";
            botaoInicial.UseVisualStyleBackColor = false;
            botaoInicial.Click += button1_Click;
            botaoInicial.MouseEnter += botaoInicial_MouseEnter;
            botaoInicial.MouseLeave += botaoInicial_MouseLeave;
            // 
            // labelInicial
            // 
            labelInicial.AutoSize = true;
            labelInicial.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelInicial.Location = new Point(28, 18);
            labelInicial.Name = "labelInicial";
            labelInicial.Size = new Size(134, 23);
            labelInicial.TabIndex = 1;
            labelInicial.Text = "primeira Label";
            labelInicial.Click += labelInicial_Click;
            labelInicial.DoubleClick += labelInicial_DoubleClick;
            // 
            // botaoMessageBox
            // 
            botaoMessageBox.BackColor = Color.Red;
            botaoMessageBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            botaoMessageBox.ForeColor = SystemColors.WindowText;
            botaoMessageBox.Location = new Point(402, 80);
            botaoMessageBox.Name = "botaoMessageBox";
            botaoMessageBox.Size = new Size(283, 124);
            botaoMessageBox.TabIndex = 2;
            botaoMessageBox.Text = "botão message box";
            botaoMessageBox.UseVisualStyleBackColor = false;
            botaoMessageBox.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoMessageBox);
            Controls.Add(labelInicial);
            Controls.Add(botaoInicial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoInicial;
        private Label labelInicial;
        private Button botaoMessageBox;
    }
}