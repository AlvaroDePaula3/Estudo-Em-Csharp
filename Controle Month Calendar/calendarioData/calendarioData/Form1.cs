namespace calendarioData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calendarioMensal_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataInicialMes = calendarioMensal.SelectionStart;
            DateTime dataFinalMes = calendarioMensal.SelectionEnd;
            MessageBox.Show("A data inicial �: " + dataInicialMes.ToString("dd/MM/yyyy") + "\r\n" +
                "A data final �: " + dataFinalMes.ToString("dd/MM/yyyy"));
        }
    }
}