using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace métodos_em_C_
{
    internal class Program
    {
        //tipo-de-acesso modificador-de-instancia  tipo-de-retorno nome-do-retorno(parametros-de-entrada)
        public static double Multiplicar(double a, double b)
        {
            double Resultado = a * b;
            return Resultado;
        }

        public static void metodoVazio()
            {
            Console.WriteLine("Não há nada aqui... cri cri");
            }

        public static void Subtracao(double x, double y, ref double resultadoSubtracao)
        {
            double resultado = x - y;
            resultadoSubtracao = resultado;

        }

        public static void Divisao(double i, double j, out double dividindoNumeros)
        {
            double quoeficiente = i / j;
            dividindoNumeros = quoeficiente;
        }
        static void Main(string[] args)
        {
            double resultadoMultiplicacao = Multiplicar(20, 2);
            Console.WriteLine(resultadoMultiplicacao);
            
            metodoVazio();

            double numero = 10;
            double numero2 = 20;
            double multiplicando = Multiplicar(numero, numero2);
            Console.WriteLine(multiplicando);

            Console.WriteLine();

            double contaDeMenos = 0;
             Subtracao(numero2, numero, ref contaDeMenos);
            Console.WriteLine(contaDeMenos);

            Console.WriteLine();

            double divisor = 50;
            double dividendo = 2;
            double contaDeDividir = 0;
            Divisao(divisor, dividendo, out contaDeDividir);
            Console.WriteLine(contaDeDividir);

            Console.ReadKey();
        }
    }
}
