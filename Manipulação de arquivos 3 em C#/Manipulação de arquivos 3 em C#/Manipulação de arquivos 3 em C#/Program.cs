using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulação_de_arquivos_3_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "Manipulacao-De-Arquivos3.txt";
            FileStream arquivo = File.Create(caminho);
            arquivo.Close();

            StreamWriter escrever = new StreamWriter(caminho);
            escrever.Write("a");
            escrever.Write(" - ");
            escrever.Write("Olá ");
            escrever.Write("Mundo! \r\n");
            escrever.WriteLine("Hello World");
            escrever.WriteLine("Kon'nichiwa sekai");
            escrever.WriteLine("Hola mundo");
            escrever.WriteLine("Bonjour le monde");

            escrever.Close();

            //Podemos utilizar também o escrever.Write, porém ele não pula linhas, apenas se vc colocar o \r\n no final 

            StreamReader ler = new StreamReader(caminho);

            char[] buffer = new char[128];
            ler.Read(buffer, 3, 5);
            ler.Close();

            //ler linhas 

            StreamReader ler2 = new StreamReader(caminho);
            string lerLinhas = ler2.ReadLine();
            lerLinhas = ler2.ReadLine();
            ler2.Close();

            //ler até o final

            StreamReader ler3 = new StreamReader(caminho);
            string lerTudo = ler3.ReadToEnd();
            ler3.Close();
        }
    }
}
