using Microsoft.VisualBasic;

using System.Windows.Forms;
namespace Combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxEpic_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Você escolheu a saga: " + comboBoxEpic.SelectedItem.ToString(), "Saga selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}