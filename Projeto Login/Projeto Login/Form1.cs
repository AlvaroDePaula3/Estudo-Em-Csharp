namespace Projeto_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(buttonLogin.Text == "Log In")
            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("Digite um nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                if (textBoxUsuario.Text == "Alvaro")
                {
                    if (maskedTextBoxSenha.Text == "")
                    {
                        MessageBox.Show("Digite a senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else
                    {
                        if(maskedTextBoxSenha.Text == "246810")
                        {
                            MessageBox.Show("Senha correta, usuário logado", "Logado com êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelLogin.Text = "Usuário Logado!";
                            labelLogin.ForeColor = Color.Blue;
                            textBoxUsuario.Text = "";
                            maskedTextBoxSenha.Text = "";
                            buttonLogin.Text = "Log Out";
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } else
                {
                    MessageBox.Show("Usuário incorreto, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                    labelLogin.Text = "Login";
                    labelLogin.ForeColor = Color.Black;
                    buttonLogin.Text = "Log In";

            }
        }
    }
}