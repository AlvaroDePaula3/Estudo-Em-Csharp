using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para fazer esse código rodar, ele precisa ter o namespace abaixo
using System.Timers;

namespace Timers
{
    internal class Program
    {
        static void primeiroTimer (object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            Timer tempo = new Timer(3000);
            tempo.AutoReset = true;
            //As duas linhas acima estão criando o timer
            tempo.Elapsed += primeiroTimer;
            //A linha acima está cadastrando o evento

            tempo.Start();
            //A linha acima está inicializando o timer

            Console.WriteLine("Aperte qualquer coisa pra finalizar o programa");
            Console.ReadKey();

            tempo.Stop();
            //A linha acima para o timer
        }
    }
}
