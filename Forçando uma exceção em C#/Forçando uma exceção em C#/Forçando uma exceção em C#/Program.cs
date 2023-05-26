using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forçando_uma_exceção_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Digite um número acima de 20");
            int algarismo = Convert.ToInt32(Console.ReadLine());
            if (algarismo < 20) {
                    throw new Exception("O número " + algarismo + " é abaixo de 20");
                } else
                {
                    Console.WriteLine("o número " + algarismo + " é maior que 20");
                }
            }
            catch (Exception excecao )
            {
                Console.WriteLine("exceção: " + excecao.Message);
            }
            finally
            {
            Console.WriteLine("Aperte qualquer tecla pra sair");
            Console.ReadKey();

            }

        }
    }
}
