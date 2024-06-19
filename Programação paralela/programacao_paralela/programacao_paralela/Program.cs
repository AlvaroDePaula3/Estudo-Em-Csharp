using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacao_paralela
{
    internal class Program
    {
        static Thread primeiraThread;
        static Thread segundaThread;
        static bool finalizacao;
        static UInt16 numeroDaThread;
        static object travarobjeto;
        static Mutex travaObjMutex;

        static void minhaPrimeiraThread()
        {
            try
            {
                while (finalizacao == false)
                {
                    /*lock (travarobjeto)
                {
                    numeroDaThread = 1;
                    Thread.Sleep(1000);
                    Console.WriteLine("1ª THREAD - Já se passou um segundo. Número da Thread: " + numeroDaThread);
                    } */
                    {
                        travaObjMutex.WaitOne();
                        numeroDaThread = 1;
                        Thread.Sleep(1000);
                        Console.WriteLine("1ª THREAD - Já se passou um segundo. Número da Thread: " + numeroDaThread);
                        travaObjMutex.ReleaseMutex();
                    }
                }
                } catch (ThreadAbortException e)
            {
                Console.WriteLine("1ª EXCEÇÃO: " + e.Message);
            }
            finally
            {

            Console.WriteLine("Falou");
            }
        }

        static void minhaPrimeiraThread2()
        {
            try
            {
                while (finalizacao == false)
                {
                   // lock (travarobjeto)
                    {
                        travaObjMutex.WaitOne();
                        numeroDaThread = 2;
                        Thread.Sleep(1000);
                        Console.WriteLine("2ª THREAD - Já se passou um segundo. Número da Thread: " + numeroDaThread);
                        travaObjMutex.ReleaseMutex();
                    }
                }
            } catch(ThreadAbortException e)
            {
                Console.WriteLine("2ª EXCEÇÃO: " + e.Message);
            }
            finally
            {

            Console.WriteLine("Valeu");
            }
        }

        static void Main(string[] args)
        {
            //O Sleep é usado pra execução ser pausada por um determinado tempo 
            /*int i = 0;
            while (i < 5)
            {
                int adicionar = i++;
                Console.WriteLine("Passou 1 segundo");
                Thread.Sleep(1000);
            }*/

            finalizacao = false;

            travarobjeto = new object();
            travaObjMutex = new Mutex();

            primeiraThread = new Thread(minhaPrimeiraThread);
            segundaThread = new Thread(minhaPrimeiraThread2);

            primeiraThread.Priority = ThreadPriority.AboveNormal;
            segundaThread.Priority = ThreadPriority.BelowNormal;

            primeiraThread.Start();
            segundaThread.Start();            
            
            Console.ReadKey();
            finalizacao = true;

            primeiraThread.Abort();
            segundaThread.Abort();

            Console.WriteLine("Pressione qualquer tecla para sair da aplicação meu nobre");

            Console.ReadKey();
        }
    }
}
