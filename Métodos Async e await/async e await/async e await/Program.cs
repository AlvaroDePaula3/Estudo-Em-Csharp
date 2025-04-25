using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_e_await
{
    internal class Program
    {
        public static async Task<string> ideiaDateAsync(string nome)
        {
            Console.WriteLine(nome + " Foi ao mercado comprar Pizza. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            //Thread.Sleep(2000);
            await Task.Delay(2000);
            Console.WriteLine(nome + " Comprou a pizza. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            //Thread.Sleep(2000);
            await Task.Delay(2000);
            //Esse código acima faz a mesma coisa que o thread.sleep
            Console.WriteLine(nome + " Retornou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Frango com catupiry";
        }

        public static async Task<string> filmeDateASync(string nome)
        {
            Console.WriteLine(nome + " Depositou o dinheiro para pagar a netflix. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            //Thread.Sleep(2000);
            await Task.Delay(2000);
            Console.WriteLine(nome + " Pagou a Netflix no pix. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            //Thread.Sleep(2000);
            await Task.Delay(2000);
            Console.WriteLine(nome + " Retornou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            return "Espelho, espelho meu";
        }
        //Até aqui o código funciona normalmente, porém eu vou fazer um outro método pra capturar o valor do return

        public static async void noiteFilmes()
        {
            Task<string> ideiaTask = ideiaDateAsync("Alvaro");
            Task<string> filmeTask = filmeDateASync("Samira");

            string ideia = await ideiaTask;
            string filme = await filmeTask;

            Console.WriteLine("O sabor da pizza comprada para o date é: " + ideia);
            Console.WriteLine("O filme que eles verão é: " +  filme);
        }

        static void Main(string[] args)
        {
            //string lanche = ideiaDate("Alvaro");
            //string filme = filmeDate("Samira");

            noiteFilmes();

            Console.ReadKey();
        }
    }
}
