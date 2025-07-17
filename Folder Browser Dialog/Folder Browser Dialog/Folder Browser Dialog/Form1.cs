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
            //sem o if else, já conseguimos abrir as pastas normalmente, porém não vemos os arquivos 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoPasta = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("O diretório da pasta é: " + caminhoPasta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogoPasta = new FolderBrowserDialog();

            //A linha abaixo diz como vai aparecer o começo do diretório para nós
            dialogoPasta.InitialDirectory = "c:\\";
            
            //A linha abaixo faz com que tenhamos um botão para criar uma nova pasta no diretório 
            dialogoPasta.ShowNewFolderButton = true;
            if(dialogoPasta.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = dialogoPasta.SelectedPath;
                MessageBox.Show("O diretório da pasta é: " + caminhoDaPasta);
            }
        }
    }
}