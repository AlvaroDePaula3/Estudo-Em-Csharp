using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//O timer que vamos utilizar está no namespace abaixo
using System.Threading;

namespace Timer_no_threading
{
    internal class Program
    {
        //Método para nos ajudar a mexer com o timer
        static void timerTempo(object temporario)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            //Criando o timer
            TimerCallback callBackTempo = new TimerCallback(timerTempo);
            Timer meuTempo = new Timer(callBackTempo, null, 0, 1000);
            /* A linha acima basicamente funciona da seguinte maneira, primeiro você coloca o método Timer e da um nome a ele, depois você coloca o sinal de igual
             * em seguida, você abre parênteses e coloca o nome da callback que você criou, coloca uma vírgula e você deve colocar objeto qualquer que vai entrar como
             * parâmetro de entrada do objeto nosso método. Após a próxima vírgula será o tempo que vai passar adicionalmente após o tempo que vamos estipular
             * para que o timer seja executado, e após a última vírgula é quanto tempo vai passar para que o timer seja acionado.             
             */

            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadKey();

            meuTempo.Dispose();
            //A linha acima encerra o timer
        }
    }
}
