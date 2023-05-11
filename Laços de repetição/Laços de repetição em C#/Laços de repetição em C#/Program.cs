using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //For

            for (int exemplo1 = 0 /* inicialização da variável */; exemplo1 < 20 /* Condição */; exemplo1 += 10 /* Alteração da variável*/)
            {
                Console.WriteLine("qualquer coisa");
            }
            Console.WriteLine();

            // While
            int exemplo2 = 0;
            while (exemplo2 < 200/*Condição*/)
            {
                Console.WriteLine("Ta rodando!!!");
                exemplo2 += 20;
            }

            Console.WriteLine();

            //Do...Whille
            int exemplo3 = 0;
            do
            {
                Console.WriteLine("Ta funcionando");
                exemplo3 = ++exemplo3;
            } while (exemplo3 < 5 /* Condição*/);

            Console.WriteLine();

            //For each
            string[] animacoes = { "Jujutsu Kaisen", "Hunter X Hunter", "Princesa Mononosuke", "Gachiakuta" };
            foreach (string animacao in animacoes)
            {
                Console.WriteLine(animacao);
            }

            Console.ReadKey();
        }
    }
}
