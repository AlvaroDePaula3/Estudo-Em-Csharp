namespace Timers
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerPorCodigo;
        public Form1()
        {
            InitializeComponent();
            timerPorCodigo = new System.Windows.Forms.Timer();
            timerPorCodigo.Interval = 5000;
            timerPorCodigo.Tick += timerPorCodigoTick;
            timerPorCodigo.Enabled = false;
        }

        private void timerPorCodigoTick(object? sender, EventArgs e)
        {
            MessageBox.Show("Timer por código: A hora atual é: " + DateTime.Now.ToString("HH:mm:ss"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer da interface gráfica: A hora atual é: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void botaoCodigo1_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = true;
        }

        private void botaoCodigo2_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = false;

        }
    }
}