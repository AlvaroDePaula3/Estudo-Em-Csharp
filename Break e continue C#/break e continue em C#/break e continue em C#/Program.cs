using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_e_continue_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Aperte C para utilizar 'continue'.");
                Console.WriteLine("Aperte B para utilizar 'break'.");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                

                if (tecla == "c")
                {
                    continue;

                }
                else if (tecla == "b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Esta tecla é desconhecida");

                }
                
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
             Console.ReadKey();
        }
    }
}
