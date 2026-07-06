using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Exercícios_de_LINQ
{
    public class Aluno
    {
        private int id;
        private string nome;
        private int idade;
        private string curso;
        private double nota;
        private bool ativo;
        private List<string> habilidades = new List<string>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public List<string> Habilidades
        {
            get { return habilidades; }
            set { habilidades = value; }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno { Id = 1, Nome = "Ana", Idade = 22, Curso = "Engenharia", Nota = 85, Ativo = true, Habilidades = new List<string>{"C#", "SQL", "JavaScript"} },
                new Aluno { Id = 2, Nome = "João", Idade = 25, Curso = "Computação", Nota = 45, Ativo = false, Habilidades = new List<string>{"Python", "Java"} },
                new Aluno { Id = 3, Nome = "Maria", Idade = 20, Curso = "Sistemas", Nota = 92, Ativo = true, Habilidades = new List<string>{"C#", "React", "Azure"} },
                new Aluno { Id = 4, Nome = "Pedro", Idade = 28, Curso = "Engenharia", Nota = 68, Ativo = true, Habilidades = new List<string>{"C++", "Python"} },
                new Aluno { Id = 5, Nome = "Carla", Idade = 23, Curso = "Sistemas", Nota = 78, Ativo = false, Habilidades = new List<string>{"JavaScript", "Node.js", "MongoDB"} },
            };

            Console.WriteLine("FILTRAR E ORDENAR: ");
            var maior70 = alunos
                .Where(x => x.Nota > 70)
                .OrderByDescending(x => x.Nota)
                .Select(x => new { x.Nome, x.Nota })
                .ToList();

            foreach(var notas in maior70)
            {
                Console.WriteLine($"As notas maiores que 70 são: {notas.Nota}");
            }

            Console.WriteLine();
            Console.WriteLine("AGRUPAR E CONTAR: ");

            var agruparCurso = alunos
                .GroupBy(y => y.Curso)
                .Select(z => new
                {
                    Curso = z.Key,
                    Quantidade = z.Count(),
                    mediaNota = z.Average(z => z.Nota)
                })
            .OrderByDescending(b => b.mediaNota)
            .ToList();

            foreach(var cursos in agruparCurso)
            {
                Console.WriteLine($"Cursos: {cursos.Curso}");
                Console.WriteLine($"Quantidade de alunos: {cursos.Quantidade}");
                Console.WriteLine($"Média nota: {cursos.mediaNota:F2}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Any, All e FirstOrDefault:");

            bool gabaritado = alunos.Any(v => v.Nota == 100);
            Console.WriteLine($"Temos alunos com a nota igual a 100 ? {gabaritado}");
            bool AlunosAtivos = alunos.All(w => w.Ativo == true);
            Console.WriteLine($"Todos os alunos estão ativos ? {AlunosAtivos}");

            var alunoMaiorQue90 = alunos.FirstOrDefault(y => y.Nota > 90, null);
            if(alunoMaiorQue90 != null)
            {
                Console.WriteLine($"O(A) aluno(a) {alunoMaiorQue90.Nome} tem a nota {alunoMaiorQue90.Nota}");
            } else
            {
                Console.WriteLine("Nenhum aluno com a nota superior a 90");
            }

            Console.WriteLine();
            Console.WriteLine("SelectMany e Habilidades");

            var rankingNotas = alunos.SelectMany(a => a.Habilidades)
                .GroupBy(b => b)
                .Select(c => new
                {
                    Habilidades = c.Key,
                    Total = c.Count()
                })
                .OrderByDescending(d => d.Total)
                .ToList();
                
            foreach(var alunosHabilidades in rankingNotas)
            {
                Console.WriteLine($"{alunosHabilidades.Habilidades}:{alunosHabilidades.Total}");
                Console.WriteLine();
            }

            var filtroAtivos = alunos
                .Where(a => a.Ativo == true)
                .Select(b => new
                {
                    b.Nome,
                    b.Nota,
                    Conceito = b.Nota >= 90 ? "A" :
                               b.Nota >= 70 ? "B" :
                               b.Nota >= 50 ? "C" : "D",
                    QtdHabilidades = b.Habilidades.Count()
                }) 
                .GroupBy( c => c.Conceito)
                .Select(d => new 
                { 
                    Conceito = d.Key,
                    Quantidade = d.Count(),
                    Media = d.Average(c => c.Nota),
                    MHabilidades = d.Average(c => c.QtdHabilidades),
            })
                .OrderBy(c => c.Conceito)
                .ToList();

            foreach(var relatorio in filtroAtivos)
            {
                Console.WriteLine(relatorio);
            }
        }
    }
}