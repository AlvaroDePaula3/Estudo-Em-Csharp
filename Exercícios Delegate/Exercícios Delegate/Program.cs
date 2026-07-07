using System.Security.Cryptography.X509Certificates;

namespace Exercícios_Delegate
{
    internal class Program
    {
        public delegate double Calculo(double x, double y);

        public double Somar(double x, double y) => x + y;

        public double Multiplicar(double x, double y) => x * y;
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Func");
            Func<double, double> dobro = x => x * 2;

            double resultado = dobro(5.5);

            Console.WriteLine($"{resultado}");

            Console.WriteLine();
            Console.WriteLine("Exercício Action");

            Action<string> cumprimentos = nomear => Console.WriteLine($"Opa {nomear} ta deboas ?");
           cumprimentos("João");

            Console.WriteLine();

            Program p = new Program();

            Calculo operacao = p.Somar;
            Console.WriteLine(operacao(5, 5));

            operacao = p.Multiplicar;
            Console.WriteLine(operacao(2, 5));

            Console.WriteLine();

        }
    }
}