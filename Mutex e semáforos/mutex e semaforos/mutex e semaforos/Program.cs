using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mutex_e_semaforos
{
    internal class Program
    {
        static Mutex testeMutex;
        static Semaphore semaforo;
        //O mutex faz com que apenas um código possa acessar, enquanto o semáforo faz com que mais de uma task sejam executadas simultâenamente (de acorodo com a regra que decidirmos)
        static void mensagemNaTela(int numeroMutex)
        {
            testeMutex.WaitOne();
            //Se colocar sem o código Mutex.WaitOne() vai fazer todas as tasks de uma vez, o wait one faz com que vá um de cada vez. Comenta aí pra ver.

            semaforo.WaitOne();
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Número da task: " + numeroMutex + ". Número do contador: " + i);
                Thread.Sleep(500);
            }
            //A linha abaixo faz com que quando a task que estava usando o código acima deixar de usar o código, alguma task que esteja livre e ainda não tenha usado o código poderá utiliza-lo.
            testeMutex.ReleaseMutex();

            semaforo.Release();
        }
        static void Main(string[] args)
        {
           testeMutex = new Mutex();
            semaforo = new Semaphore(2, 2);
            // O primeiro número é o número de acessos livres dentro do semáforo, e o número máximo logo em seguida. O número máximo também representa o número de acessos protegidos pelo semáforo.
            //Recomendo comentar os códigos que ativam o mutex para usar os semáforos
            //Lembrando que ambos possuem o mesmo propósito que seria o controle e o acesso.

            Task task1 = Task.Run(() => mensagemNaTela(1));
            Task task2 = Task.Run(() => mensagemNaTela(2));
            Task task3 = Task.Run(() => mensagemNaTela(3));
            Task task4 = Task.Run(() => mensagemNaTela(4));

            Console.ReadKey();
        }
    }
}
