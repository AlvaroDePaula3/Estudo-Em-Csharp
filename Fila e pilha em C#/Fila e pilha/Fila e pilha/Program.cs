using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_e_pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaDeFilmes = new Queue<string>();

            {

                //adicionando elementos na fila

                filaDeFilmes.Enqueue("D&D honra entre rebeldes");
                filaDeFilmes.Enqueue("Como treinar o seu dragão");
                filaDeFilmes.Enqueue("Gato de botas 2: O último desejo");
                filaDeFilmes.Enqueue("A casa monstro");
                filaDeFilmes.Enqueue("A bruxa de blair");

                foreach (string filme in filaDeFilmes)
                {
                    Console.WriteLine(filme);
                }

                //Removendo itens da fila de filmes

                Console.WriteLine();

                string sairDeCartaz = filaDeFilmes.Dequeue();
                Console.WriteLine(sairDeCartaz);
                sairDeCartaz = filaDeFilmes.Dequeue();
                Console.WriteLine(sairDeCartaz);

                Console.WriteLine();

                //Espiando conteúdo da fila
                string vendoFila = filaDeFilmes.Peek();
                Console.WriteLine(vendoFila);
                /* Nesse caso o console mostrará o filme do Gato de botas devido a remoção que foi feita anteriormente no filme "D&D honra entre rebeldes"
                 * e no "como treinar o seu dragão", fazendo com que o filme do "Gato de botas 2" se tornasse o primeiro filme da lista. */

                Console.WriteLine();
                int contarFila = filaDeFilmes.Count();
                Console.WriteLine(contarFila);

                Console.WriteLine();
                
                //STACK - PILHA
                Stack<string> pilhaDeLivros = new Stack<string>();
                pilhaDeLivros.Push("Coração de aço");
                pilhaDeLivros.Push("As crônicas de gelo e fogo");
                pilhaDeLivros.Push("trono de vidro");
                pilhaDeLivros.Push("A espada do destino");

                foreach (string livro in pilhaDeLivros)
                {
                    Console.WriteLine(livro);
                }

                Console.WriteLine();

                int contarLivros = pilhaDeLivros.Count();
                Console.WriteLine(contarLivros);

                Console.WriteLine();

                //Remover elementos da pilha
                string removerPilha = pilhaDeLivros.Pop();
                Console.WriteLine(removerPilha);

                Console.WriteLine();

                string espiarPilha = pilhaDeLivros.Peek();
                Console.WriteLine(espiarPilha);

                Console.ReadKey();
            }
        }
    }
}
