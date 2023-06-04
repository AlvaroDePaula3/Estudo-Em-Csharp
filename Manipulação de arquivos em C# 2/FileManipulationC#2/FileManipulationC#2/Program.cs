using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManipulationC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\alvar\OneDrive\Área de Trabalho\Estudo do C#\Manipulação de arquivos em C# 2\FileManipulationC#2\FileManipulationC#2\bin\Debug\rotina.txt";
            string caminho2 = "C:\\Users\\alvar\\OneDrive\\Área de Trabalho\\Estudo do C#\\Manipulação de arquivos em C# 2\\FileManipulationC#2\\FileManipulationC#2\\bin\\Debug\\rotina2.txt";
            string escrita1 = "Lucas acorda todo dia as 7:00 da manhã. \r\n";
            string escrita2 = "após tomar café ele vai estudar. \r\n";

            //maneira mais adequada

            File.AppendAllText(caminho, escrita1 + escrita2);

            //maneira utilizada por muitos, mas não é tão adequada

            string arquivo = File.ReadAllText(caminho2);
            string arquivoFinal = arquivo + escrita1 + escrita2;
            File.WriteAllText(caminho2, arquivoFinal);
        }
    }
}
