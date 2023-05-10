using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Avançado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Título do console, esse comando literalmente muda o nome do console.
            Console.Title = "Date Time Avançado";

            //DateTime básico.
            DateTime aniversario = new DateTime(2003, 03, 30, 15, 55, 42);
            Console.WriteLine(aniversario.ToString());

            Console.WriteLine();

            //DateTime pegando cada elemento especificamente.

            DateTime dataAleatoria = new DateTime(2022, 02, 12, 15,55, 44);
            Console.WriteLine("Ano: " + dataAleatoria.Year);
            Console.WriteLine("Mês: " + dataAleatoria.Month);
            Console.WriteLine("Dia: " + dataAleatoria.Day);
            Console.WriteLine("Hora: " + dataAleatoria.Hour);
            Console.WriteLine("Minuto:" + dataAleatoria.Minute);
            Console.WriteLine("Segundo: " + dataAleatoria.Second);
            Console.WriteLine("Dia da semana: " + dataAleatoria.DayOfWeek);
            Console.WriteLine("Dia do ano: " + dataAleatoria.DayOfYear);

            Console.WriteLine();
            //Data e hora atual

            DateTime dataDeHoje = DateTime.Now;
            Console.WriteLine(dataDeHoje.ToString());

            Console.WriteLine();

            //Convertendo string em DateTime

            DateTime ConversorDeData = (Convert.ToDateTime("2025/06/12"));
            Console.WriteLine(ConversorDeData);

            //Formatando a hora e a data impressa

            Console.WriteLine(aniversario.ToString("dd/MM/yyyy"));
            Console.WriteLine(dataAleatoria.ToString("dd:MM:yyyy:HH:mm:ss"));

            Console.WriteLine();

            //Resolvendo operações com DateTime

            DateTime operacaoDate = new DateTime(2022, 05, 17, 14, 29, 50);
            operacaoDate = operacaoDate.AddDays(9);
            Console.WriteLine(operacaoDate.ToString("dd/MM/yyyy"));

            Console.WriteLine();

            //adicionando um espaço de tempo

            DateTime dateOperacoes = new DateTime(2022, 06, 18, 15, 30, 51);
            dateOperacoes = dateOperacoes.Add(new TimeSpan(12, 06, 03, 01));
            Console.WriteLine(dateOperacoes);

            Console.WriteLine();

            //Removendo espaço de tempo

            dateOperacoes = dateOperacoes.Subtract(new TimeSpan(08, 04, 02, 01));
            Console.WriteLine(dateOperacoes.ToString("dd/MM/yyyy - HH:mm:ss"));

            Console.WriteLine();

            //Removendo dias

            DateTime removendoDias = new DateTime(2005, 04, 12, 14, 05, 30);
            removendoDias = removendoDias.AddDays(-5);
            Console.WriteLine(removendoDias.ToString("dd/MM/yyyy"));

            Console.ReadKey();

        }
    }
}
