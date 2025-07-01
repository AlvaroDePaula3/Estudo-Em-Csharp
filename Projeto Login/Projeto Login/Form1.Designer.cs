namespace Projeto_Login
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
            labelLogin = new Label();
            labelUsuario = new Label();
            labelSenha = new Label();
            textBoxUsuario = new TextBox();
            buttonLogin = new Button();
            maskedTextBoxSenha = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(39, 27);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(100, 41);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            labelLogin.Click += label1_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(39, 129);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(79, 28);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuário";
            labelUsuario.Click += label2_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.Location = new Point(39, 205);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(65, 28);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(143, 129);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(260, 27);
            textBoxUsuario.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(45, 269);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(358, 84);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Location = new Point(143, 209);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.PasswordChar = '*';
            maskedTextBoxSenha.Size = new Size(260, 27);
            maskedTextBoxSenha.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 366);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Controls.Add(labelLogin);
            MinimumSize = new Size(445, 413);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUsuario;
        private Label labelSenha;
        private TextBox textBoxUsuario;
        private Button buttonLogin;
        private MaskedTextBox maskedTextBoxSenha;
    }
}