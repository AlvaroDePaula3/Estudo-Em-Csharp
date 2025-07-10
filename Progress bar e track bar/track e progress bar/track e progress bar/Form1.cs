namespace track_e_progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarAtiva_ValueChanged(object sender, EventArgs e)
        {
            progressBarPassivo.Value = trackBarAtiva.Value; 
        }
    }
}