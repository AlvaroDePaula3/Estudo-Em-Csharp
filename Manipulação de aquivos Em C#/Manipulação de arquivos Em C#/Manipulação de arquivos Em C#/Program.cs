using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulação_de_arquivos_Em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //criando um caminho

            string caminhoDaPasta = @"C:\Users\alvar\OneDrive\Área de Trabalho\Manipulação de aquivos Em C#\Manipulação de arquivos Em C#\Manipulação de arquivos Em C#\testando.txt";

            //teste para ver como seria se não existisse uma pasta
            string caminhoFalso = @"C:\PastaFicticia\aquivo.txt"; 


            //criando um arquivo
            FileStream arquivo1 = File.Create(caminhoDaPasta);
            arquivo1.Close();

            //verificando a existência de um arquivo

            bool Existencia = File.Exists(caminhoDaPasta);
            bool NaoExistencia = File.Exists(caminhoFalso);
            if (Existencia)
            {
                Console.WriteLine("Existe");
            } else
            {
                Console.WriteLine("Não existe");
            }

            if (NaoExistencia)
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("Não existe");
            }

            //Deletando um arquivo

            File.Delete(caminhoDaPasta);

            //renomeando ou movendo um arquivo
            string segundoArquivo = @"C:\Users\alvar\OneDrive\Área de Trabalho\Manipulação de aquivos Em C#\Manipulação de arquivos Em C#\Manipulação de arquivos Em C#\aprendizado.txt";
            File.Create(segundoArquivo).Close();

            string movendoArquivo = @"C:\Users\alvar\OneDrive\Área de Trabalho\Manipulação de aquivos Em C#\Manipulação de arquivos Em C#\Manipulação de arquivos Em C#\aprendizado2.txt";
            File.Move(segundoArquivo, movendoArquivo);

            File.Delete(movendoArquivo);


            //escrevendo num arquivo de texto criado com C#

            string bandasDeMusica = @"C:\Users\alvar\OneDrive\Área de Trabalho\Manipulação de aquivos Em C#\Manipulação de arquivos Em C#\Manipulação de arquivos Em C#\bandas.txt";
            File.Create(bandasDeMusica).Close();
            string bandas = "Linkin Park\r\nAudioslave\r\nPierce the veil";

            File.WriteAllText(bandasDeMusica, bandas);

            //Colocando um array dentro de um arquivo de textos

            string jogos = @"C:\Users\alvar\OneDrive\Área de Trabalho\Manipulação de aquivos Em C#\Manipulação de arquivos Em C#\Manipulação de arquivos Em C#\jogos.txt";
            string[] jogosArrays = { "Sekiro", "The Witcher 3", "Lies Of P", "Little Nightmares" };
            File.WriteAllLines(jogos, jogosArrays);
            Console.WriteLine();

            //Lendo o conteúdo de um arquivo no console

            string lerArquivo = File.ReadAllText(bandasDeMusica);
            Console.WriteLine(lerArquivo);
            Console.WriteLine();

            //lendo arquivos de um array

            string[] lerArray = File.ReadAllLines(jogos);
            foreach(string jogo in lerArray)
            {
                Console.WriteLine(jogo); 
            }
            Console.ReadKey();

        }
    }
}
