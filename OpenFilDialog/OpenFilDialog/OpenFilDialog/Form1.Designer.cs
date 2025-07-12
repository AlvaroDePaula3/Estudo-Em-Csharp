namespace OpenFilDialog
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
            button1 = new Button();
            muitosArquivos = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(315, 167);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // muitosArquivos
            // 
            muitosArquivos.Location = new Point(364, 85);
            muitosArquivos.Name = "muitosArquivos";
            muitosArquivos.Size = new Size(315, 167);
            muitosArquivos.TabIndex = 1;
            muitosArquivos.Text = "muitos Arquivos";
            muitosArquivos.UseVisualStyleBackColor = true;
            muitosArquivos.Click += muitosArquivos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(muitosArquivos);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button muitosArquivos;
    }
}