using System.Data;

namespace LINQ_treinamento
{
    public class Musicas
    {
        private int id;
        private string nome;
        private string banda;
        private DateTime dataDeLancamento;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }

        public string Banda
        {
            get { return banda; }
            private set { banda = value; }
        }

        public DateTime DataDeLancamento
        {
            get { return dataDeLancamento; }
            private set { dataDeLancamento = value; }
        }

        public Musicas(int id, string nome, string banda, DateTime dataDeLancamento) : base()
        {
            Id = id;
            Nome = nome;
            Banda = banda;
            DataDeLancamento = dataDeLancamento;
        }

        public override string ToString() =>
            $"Id:{Id} | Nome da Música: {Nome} | Banda: {Banda} | Data de Lançamento: {DataDeLancamento}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = new List<Musicas>
            {
                new Musicas(id:1, nome:"Overcompensate", banda: "Twenty One Pilots", dataDeLancamento: new DateTime(year:2024, month:02, day:29)),
                new Musicas(id:2, nome:"Rats", banda: "Motionless In White", dataDeLancamento: new DateTime(year:2017, month:04, day:23)),
                new Musicas(id:3, nome:"Death Of Peace Of Mind", banda: "Bad Omens", dataDeLancamento: new DateTime(year:2021, month:11, day:09)),
                new Musicas(id:4, nome:"Circle With Me", banda: "Spiritbox", dataDeLancamento: new DateTime(year:2021, month:04, day:30)),
            };

            Console.WriteLine("Músicas lançadas em 2021: ");
            var musicas2021 = songs.Where(x => x.DataDeLancamento.Year == 2021);
            foreach(var s in musicas2021)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("Músicas lançadas em abril: ");
            var musicasAbril = songs.Where(z => z.DataDeLancamento.Month == 04).ToList();
            foreach(var sa in musicasAbril)
            {
                Console.WriteLine(sa);
            } 

            Console.WriteLine();
            Console.WriteLine("Mostrar as músicas em ordem alfabética: ");
            var ordemAlfabetica = songs.OrderBy(s => s.Nome).ToList();
            foreach(var oa in ordemAlfabetica)
            {
                Console.WriteLine(oa);
            }

            Console.WriteLine();
            Console.WriteLine("últimas duas músicas mostradas na ordem alfabética: ");

            if (songs.Count <= 2)
            {
                Console.WriteLine("Não é possível mostrar, pois a lista é muito pequena");
            }
            else
            {
                var ultimasAlfabeticas = songs.OrderBy(s => s.Nome).TakeLast(2).ToList();

                foreach (var uA in ultimasAlfabeticas)
                {
                    Console.WriteLine(uA);
                }
            }
        }
    }
}