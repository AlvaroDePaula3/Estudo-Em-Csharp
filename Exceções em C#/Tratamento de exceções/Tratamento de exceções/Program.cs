using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo, digite um número");

            try
            {
            int dividir = Convert.ToInt32(Console.ReadLine());
            int divisao = 10 / dividir;
            Console.WriteLine(divisao);

            }catch (DivideByZeroException zerada)
            {
                Console.WriteLine(zerada.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para fechar a aplicação");
                Console.ReadKey();
            }

        }
    }
}
