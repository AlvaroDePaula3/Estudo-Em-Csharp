using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Em_C_
{
    internal class Program
    {
        public delegate double operacoesGerais(double a, double b);

        public static double Adicao(double a, double b)
        {
            double somando = a + b;
            Console.WriteLine(somando);
            return somando;
        }

        public static double Multiplicacao(double x, double y)
        {
            double contaDeVezes  = x * y;
            Console.WriteLine(contaDeVezes);
            return contaDeVezes;
        }

        public static double Subtracao(double i, double j)
        {
            double contaDeMenos = i - j;
            Console.WriteLine(contaDeMenos);
            return contaDeMenos;
        }

        public static void realizandoOperacao (operacoesGerais testeDelegate)
        {
            Console.WriteLine("O resultado do método passado como parâmetro de entrada é: ");
            testeDelegate(60, 30);
        }
        static void Main(string[] args)
        {
            operacoesGerais testeDelegate;
            
            testeDelegate = Adicao;
            double resultadoGeral = testeDelegate(10, 50);
            Console.WriteLine("---------------------");
            Console.WriteLine(resultadoGeral);
            Console.WriteLine();

            testeDelegate += Multiplicacao;
            testeDelegate += Subtracao;
            resultadoGeral = testeDelegate(30, 2);
            Console.WriteLine(  resultadoGeral);
            Console.WriteLine();

            //Só uma observação, o último método que foi referenciado no delegate é retornado pelo delegate

            realizandoOperacao(Multiplicacao);

            Console.ReadKey();
        }
    }
}
