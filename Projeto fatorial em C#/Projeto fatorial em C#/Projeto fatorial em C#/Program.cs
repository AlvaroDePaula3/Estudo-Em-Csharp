using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_fatorial_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(" Pressione qualquer número ou pressione b para sair");
                string botao = Console.ReadLine();

                if (botao == "b" || botao == "B")
                    break;              
                else
                {
                    int numero = Convert.ToInt32(botao);
                    if (numero == 0)                    
                        Console.WriteLine("Não é possível fazer uma fatorial com números negativos.");                   
                    else if (numero < 0)
                    Console.WriteLine("0! = 1");
                    else
                    {
                        int numeroFatorado = 1;
                        Console.Write(numero + "! = ");
                        for (int fatores = numero; fatores > 0; fatores--)
                        {
                            numeroFatorado *= fatores;
                            if (fatores == 1)
                            Console.Write(fatores + " = " + numeroFatorado);
                            else
                            {
                                Console.Write(fatores + " x");
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.ReadKey();

            }
        }
    }
}
