namespace OpenFilDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abaixo criamos o OpenFileDialog e atribu�mos um nome a ele
            OpenFileDialog abrirArquivo = new OpenFileDialog();

            //Esse c�digo abaixo faz com que comecemos no diret�rio escrito entre aspas (nesse caso � a �rea de trabalho).
            abrirArquivo.InitialDirectory = "�rea de Trabalho:";

            //Abaixo adicionamos filtros a nossa interface gr�fica, primeiro colocamos o nome e ap�s a pipe colocamos o tipo de arquivo que desejamos filtrar.
            //o c�digo seria "Nome do arquivo | *.(tipo de arquivo que desejamos filtrar), abaixo temos um exemplo
            abrirArquivo.Filter = "Arquivo txt|*.txt |Arquivos jpg |*.jpg |Arquivos PNG | *.png| Todos os arquivos |*.*";

            //Esse if abaixo, faz com que tenhamos acesso ao local do arquivo em um MessageBox
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                string arquivoLocal = abrirArquivo.FileName;
                MessageBox.Show(arquivoLocal);
            }
        }

        private void muitosArquivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivos = new OpenFileDialog();

            abrirArquivos.InitialDirectory = "�rea de Trabalho:";

            abrirArquivos.Filter = "Arquivo txt|*.txt |Arquivos jpg |*.jpg |Arquivos PNG | *.png| Todos os arquivos |*.*";
            //Esse c�digo aqui faz com que mais de um arquivo seja selecionado para fazer as fun��es ditas no outro bot�o
            abrirArquivos.Multiselect = true;

            if (abrirArquivos.ShowDialog() == DialogResult.OK)
            {
                //As mudan�as na var�avel abaixo � devido a adi��o do c�digo mmultiselect = true
                //primeiro temos que mudar o FileName para FileNames. 
                //Ap�s isso transformamos a string em um array de strings
                string[] arquivosLocais = abrirArquivos.FileNames;

                //Para funcionar corretamente, precisamos usar um Foreach e nele passarmos o MessageBox
                foreach(string arquivo in arquivosLocais)
                {
                MessageBox.Show(arquivo);
                }
            }
        }
    }
}