using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Estudo_Tasks
{
    internal class Program
    {

        public static int mensagemNaTela(int parametroDeTeste)
        {
            for(int i = parametroDeTeste; i < 10; i++)
            {
                Console.WriteLine("A task foi executada. O número atual é: " + i);
                Thread.Sleep(1000);
            }
            return 10;
        }
        static void Main(string[] args)
        {
            int resultadoMainTask = 0;
            Task imprimirMensagem = Task.Run(() => resultadoMainTask = mensagemNaTela(3));

            Console.WriteLine("Resultado antes da resolução da task: " + resultadoMainTask);
            Console.WriteLine("O valor da task é: " + resultadoMainTask);
            Console.WriteLine(" ");

            if (imprimirMensagem.Wait(10000) == false)
            {
                Console.WriteLine("### A task não foi finalizada no momento ###");
            }
            else
            {
                Console.WriteLine("### A task está completa ###");
                Console.WriteLine("O resultado é: " + resultadoMainTask);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task do método main, resultado é: " + i);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
