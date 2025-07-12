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
            //Abaixo criamos o OpenFileDialog e atribuímos um nome a ele
            OpenFileDialog abrirArquivo = new OpenFileDialog();

            //Esse código abaixo faz com que comecemos no diretório escrito entre aspas (nesse caso é a área de trabalho).
            abrirArquivo.InitialDirectory = "Área de Trabalho:";

            //Abaixo adicionamos filtros a nossa interface gráfica, primeiro colocamos o nome e após a pipe colocamos o tipo de arquivo que desejamos filtrar.
            //o código seria "Nome do arquivo | *.(tipo de arquivo que desejamos filtrar), abaixo temos um exemplo
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

            abrirArquivos.InitialDirectory = "Área de Trabalho:";

            abrirArquivos.Filter = "Arquivo txt|*.txt |Arquivos jpg |*.jpg |Arquivos PNG | *.png| Todos os arquivos |*.*";
            //Esse código aqui faz com que mais de um arquivo seja selecionado para fazer as funções ditas no outro botão
            abrirArquivos.Multiselect = true;

            if (abrirArquivos.ShowDialog() == DialogResult.OK)
            {
                //As mudanças na varíavel abaixo é devido a adição do código mmultiselect = true
                //primeiro temos que mudar o FileName para FileNames. 
                //Após isso transformamos a string em um array de strings
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