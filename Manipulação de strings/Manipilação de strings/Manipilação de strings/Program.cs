using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipilação_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONCATENANDO STRINGS
            string nome = "Billie ";
            string sobrenome = "Elish";

            string nomeCompleto = nome + sobrenome;

            Console.WriteLine(nomeCompleto);

            //Removendo/Substituindo nomes em uma string


            string flor2 = "Alvaro da camélia";
            flor2 = flor2.Remove(0, 7);
            Console.WriteLine(flor2);

            string flor = "Alvaro da camélia";
            flor = flor.Replace("camélia", "orquídea");

            Console.WriteLine(flor);

            //localizar letra na string
            string obra = "The Witcher";
            char caracter = obra[4];

            Console.WriteLine(caracter);

            //Transformar em maíusculo ou minúsculo
            string sistema = "tormenta20";
            sistema = sistema.ToUpper();
            Console.WriteLine(sistema);

            string cantora = "AURORA";
            cantora = cantora.ToLower();

            Console.WriteLine(cantora);

            //localizar palavra na string

            string musica = "Shine on you crazy diamond";
            int song = musica.IndexOf("you");
            Console.WriteLine(song);

            //Numero de caracteres
            string musica2 = "seed";
            int song2 = musica2.Length;
            Console.WriteLine(song2);

            //Divisão de strings
            string palavraQualquer = "Sorvete de Baunilha";
            string[] dividirString = { "de" };
            string[] stringDividida = palavraQualquer.Split(dividirString, StringSplitOptions.None);
            foreach (string divisao  in dividirString)
            {
                Console.WriteLine(divisao);
            }

            //Substring

            string nome2 = "Cleiton do Santos";
            string verdadeiroSobrenome = nome2.Substring(11, 6);
            Console.WriteLine(verdadeiroSobrenome);

            //Formatação composta

            string exemplo1 = "George {0} {1} {2}";
            Console.WriteLine(exemplo1, "R", "R", "Martin" );
            /* Este mostrado acima não é muito usado, mas todo conhecimento é válido*/

            //Contém
            string Pokemon = "Pokemon black and white";
            bool pokedex = Pokemon.Contains("black");
            Console.WriteLine(pokedex);

            string RPG = "Dungeons and Dragons";
            bool sistema2 = RPG.Contains("Tormenta20");
            Console.WriteLine(sistema2);

            Console.ReadKey();
        }
    }
}
