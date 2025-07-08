namespace ListBox
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
            listBoxEpic = new System.Windows.Forms.ListBox();
            adicionarMusica = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBoxEpic
            // 
            listBoxEpic.FormattingEnabled = true;
            listBoxEpic.ItemHeight = 20;
            listBoxEpic.Items.AddRange(new object[] { "The Horse And The Infant", "Just A Man", "Open Arms", "Warrior Of the Mind" });
            listBoxEpic.Location = new Point(162, 81);
            listBoxEpic.Name = "listBoxEpic";
            listBoxEpic.Size = new Size(370, 184);
            listBoxEpic.TabIndex = 0;
            listBoxEpic.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // adicionarMusica
            // 
            adicionarMusica.Location = new Point(162, 282);
            adicionarMusica.Name = "adicionarMusica";
            adicionarMusica.Size = new Size(169, 29);
            adicionarMusica.TabIndex = 1;
            adicionarMusica.Text = "Adicionar musica";
            adicionarMusica.UseVisualStyleBackColor = true;
            adicionarMusica.Click += adicionarMusica_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 282);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 2;
            button2.Text = "Remover musica";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(adicionarMusica);
            Controls.Add(listBoxEpic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEpic;
        private Button adicionarMusica;
        private Button button2;
    }
}