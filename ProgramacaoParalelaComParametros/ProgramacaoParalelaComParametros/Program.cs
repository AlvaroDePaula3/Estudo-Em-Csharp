using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgramacaoParalelaComParametros
{

    internal class threadComMtosParametros
    {
        public int contar
        {
            get; 
            set;
        }

        public string Nome
        {
            get;
            set;
        }

        public threadComMtosParametros(int pContar, string pNome)
        {
            contar = pContar;
            Nome = pNome;
        }
    }

    internal class Program
    {

        public static void RevisaoThreadSemParametro()
        {
            int contagem = 10;
            do
            {
                int aumentar = contagem++;
                Console.WriteLine(aumentar);
                Thread.Sleep(300);

            } while (contagem < 20);
        }

        public static void ThreadComParametro( object contando)
        {
            int contagem =  (int)contando;
            do
            {
                int aumentar = contagem++;
                Console.WriteLine(aumentar);
                Thread.Sleep(300);

            } while (contagem < 20);
        }

        public static void threadParametrosMultiplos(object pParametroDumaThread)
        {
            threadComMtosParametros parametrosMultiplos = (threadComMtosParametros)pParametroDumaThread;
            int contagem = parametrosMultiplos.contar;
            Console.WriteLine(parametrosMultiplos.Nome);
            do
            {
                int aumentar = contagem++;
                Console.WriteLine(aumentar);
                Thread.Sleep(300);

            } while (contagem < 20);
        }

        public static void threadParametrosMultiplos2(int contadorPotente, string Nome)
        {
            int contagem = contadorPotente;
            Console.WriteLine(Nome);
            do
            {
                int aumentar = contagem++;
                Console.WriteLine(aumentar);
                Thread.Sleep(300);

            } while (contagem < 20);
        }

            static void Main(string[] args)
        {
            Thread contador = new Thread(new ThreadStart(RevisaoThreadSemParametro));
            contador.Start();
            Console.ReadKey();
            Console.Clear();

            Thread contando = new Thread(new ParameterizedThreadStart(ThreadComParametro));
            contando.Start(11);
            Console.ReadKey();
            Console.Clear();

            Thread thread3 = new Thread(new ParameterizedThreadStart(threadParametrosMultiplos));
            threadComMtosParametros parametroDeUmaThread = new threadComMtosParametros(12, "Alvaro");
            thread3.Start(parametroDeUmaThread);
            Console.ReadKey();
            Console.Clear();

            Thread thread4 = new Thread(()=> threadParametrosMultiplos2(13,"Samira"));
            thread4.Start();
            Console.ReadKey();
            Console.Clear();

            int contadorPotente = 14;
            string Nome = "Theodore";
            Thread thread5 = new Thread(() => 
            {
            int contagem = contadorPotente;
            Console.WriteLine(Nome);
            do
            {
                int aumentar = contagem++;
                Console.WriteLine(aumentar);
                Thread.Sleep(300);

            } while (contagem < 20);
        });
            ;
            thread5.Start();
            Console.ReadKey();
        }
    }
}
