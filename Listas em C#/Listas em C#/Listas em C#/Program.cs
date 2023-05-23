using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> desenhos = new List<string>();

            //adicionando elementos a lista 

            desenhos.Add("Mutante rex");
            desenhos.Add("Titã Simbiônico");
            desenhos.Add("samurai jack");
            desenhos.Add("Primal");
            desenhos.Add("Roboboy");

            foreach (string animacao in desenhos) 
            {

                Console.WriteLine(animacao);

            }

            //Removendo elementos da lista

            Console.WriteLine();

            desenhos.Remove("Primal");

            foreach (string animacao in desenhos)
            {

                Console.WriteLine(animacao);

            }

            Console.WriteLine();

            // removendo mais de um elemento da lista

            desenhos.RemoveRange(0, 2);

            //vai aparecer apenas o samurai jack e o roboboy

            foreach (string animacao in desenhos)
            {

                Console.WriteLine(animacao);

            }

            Console.WriteLine() ;

            //Concatenando listas

            List<string> tecnicas = new List<string>()
            {
                "cartoon",
                "mangá",
                "realismo",
                "caricatura",
                "T.H.E"
            };
            List<string> materiais = new List<string>();
            materiais.Add("lápis");
            materiais.Add("borracha");
            materiais.Add("folha A3");
            materiais.Add("nanquim");
            materiais.Add("esfuminho");

            List<string> listaDeDesenhos = tecnicas.Concat(materiais).ToList();

            foreach (string draw in listaDeDesenhos)
            {
                Console.WriteLine(draw);
            }

            Console.WriteLine();

            //Verificando se determinado elemento existe na lista

            bool existir = listaDeDesenhos.Contains("borracha");
            Console.WriteLine(existir);

            Console.WriteLine();

            //índice do objeto na lista

            int indiceNaLista = listaDeDesenhos.IndexOf("folha A3");
            Console.WriteLine(indiceNaLista);

            Console.WriteLine();

            //Operador Where

            List<string> localizarElementoPelaLetra = listaDeDesenhos.Where(x => x.StartsWith("c")).ToList();
            foreach (string local in localizarElementoPelaLetra)
            {
                Console.WriteLine(local);
            }

            Console.ReadKey();

        }
    }
}
