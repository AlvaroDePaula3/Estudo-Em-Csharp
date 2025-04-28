namespace aprendizado_interface_grafica
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelInicial_Click(object sender, EventArgs e)
        {
            labelInicial.Text = "A label foi clickada";
            labelInicial.ForeColor = Color.Violet;
        }

        private void labelInicial_DoubleClick(object sender, EventArgs e)
        {
            labelInicial.Font = new Font("Arial", 18);
            labelInicial.ForeColor = Color.DeepPink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botaoInicial.BackColor = Color.Purple;
            botaoInicial.Text = "botão clickado";
        }

        private void botaoInicial_MouseEnter(object sender, EventArgs e)
        {
            botaoInicial.BackColor = Color.Red;
            botaoInicial.Text = "mouse em cima";
        }

        private void botaoInicial_MouseLeave(object sender, EventArgs e)
        {
            botaoInicial.BackColor = Color.Green;
            botaoInicial.ForeColor = Color.Yellow;
            botaoInicial.Text = "mouse saiu";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //A primeira aspas é o texto do meio do message box, a segunda é o nome do message box. Os botões são os que vão aparecer, sendo ok e cancelar e o icon será o ícone do message box
            if(MessageBox.Show("Parabéns, você ativou o message box", "Primeiro message box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //Essa condicional é para pegar o resultado do usuário caso ele tenha clickado em resultados diferentes
            {
                MessageBox.Show("Agora você clickou no ok", "Resultado do Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Agora você clickou no cancelar", "Resultado do Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}