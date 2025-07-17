namespace Folder_Browser_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sem o if else, j� conseguimos abrir as pastas normalmente, por�m n�o vemos os arquivos 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoPasta = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("O diret�rio da pasta �: " + caminhoPasta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogoPasta = new FolderBrowserDialog();

            //A linha abaixo diz como vai aparecer o come�o do diret�rio para n�s
            dialogoPasta.InitialDirectory = "c:\\";
            
            //A linha abaixo faz com que tenhamos um bot�o para criar uma nova pasta no diret�rio 
            dialogoPasta.ShowNewFolderButton = true;
            if(dialogoPasta.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = dialogoPasta.SelectedPath;
                MessageBox.Show("O diret�rio da pasta �: " + caminhoDaPasta);
            }
        }
    }
}