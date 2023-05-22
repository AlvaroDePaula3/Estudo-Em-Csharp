using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_em_C_
{
    internal class Program
    {
        struct Musica{
            public string nome;
            public string album;
            public DateTime dataDeLancamento;
            public string Artista;
        }
        static void Main(string[] args)
        {
            Musica song;

            song.nome = "The pretender";
            song.album = "Echoes, Silence, Patience & Grace";
            song.dataDeLancamento = Convert.ToDateTime("20/02/2002");
            song.Artista = "Foo fighters";

            Console.WriteLine(song.nome);
            Console.WriteLine(song.album);
            Console.WriteLine(song.dataDeLancamento);
            Console.WriteLine(song.Artista);

            Console.ReadKey();
        }
    }
}
