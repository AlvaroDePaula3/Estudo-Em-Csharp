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
            botaoInicial.Text = "bot�o clickado";
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
            //A primeira aspas � o texto do meio do message box, a segunda � o nome do message box. Os bot�es s�o os que v�o aparecer, sendo ok e cancelar e o icon ser� o �cone do message box
            if(MessageBox.Show("Parab�ns, voc� ativou o message box", "Primeiro message box", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //Essa condicional � para pegar o resultado do usu�rio caso ele tenha clickado em resultados diferentes
            {
                MessageBox.Show("Agora voc� clickou no ok", "Resultado do Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Agora voc� clickou no cancelar", "Resultado do Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}