namespace Timers
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            botaoCodigo1 = new Button();
            botaoCodigo2 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(38, 21);
            button1.Name = "button1";
            button1.Size = new Size(375, 57);
            button1.TabIndex = 0;
            button1.Text = "botao habilitar timer pela interface gráfica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 98);
            button2.Name = "button2";
            button2.Size = new Size(375, 57);
            button2.TabIndex = 1;
            button2.Text = "botao desabilitar timer pela interface gráfica";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // botaoCodigo1
            // 
            botaoCodigo1.Location = new Point(38, 206);
            botaoCodigo1.Name = "botaoCodigo1";
            botaoCodigo1.Size = new Size(375, 57);
            botaoCodigo1.TabIndex = 2;
            botaoCodigo1.Text = "botão habilitar time por código";
            botaoCodigo1.UseVisualStyleBackColor = true;
            botaoCodigo1.Click += botaoCodigo1_Click;
            // 
            // botaoCodigo2
            // 
            botaoCodigo2.Location = new Point(38, 295);
            botaoCodigo2.Name = "botaoCodigo2";
            botaoCodigo2.Size = new Size(375, 57);
            botaoCodigo2.TabIndex = 4;
            botaoCodigo2.Text = "botão desabilitar time por código";
            botaoCodigo2.UseVisualStyleBackColor = true;
            botaoCodigo2.Click += botaoCodigo2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoCodigo2);
            Controls.Add(botaoCodigo1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button botaoCodigo1;
        private Button botaoCodigo2;
    }
}