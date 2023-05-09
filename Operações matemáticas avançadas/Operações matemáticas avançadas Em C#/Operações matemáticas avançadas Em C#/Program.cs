using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_matemáticas_avançadas_Em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POTENCIAÇÃO
            double potencia = Math.Pow(3, 2);
            Console.WriteLine(potencia);

            //RAIZ
            double raizQuadrada = 4;
            double raiz = Math.Pow(16, 1/ raizQuadrada);
            Console.WriteLine(raizQuadrada);

            //MÁXIMO
            double valorMaximo = Math.Max(11, 121);
            Console.WriteLine(valorMaximo);

            //MÍNIMO
            double valorMinimo = Math.Min(11, 121);
            Console.WriteLine(valorMinimo);

            //MÓDULO
            double retirarSinal = Math.Abs(-33);
            Console.WriteLine("O valor de -33 ao utilizar o módulo é: " + retirarSinal);

            //OPERAÇÕES TRIGONOMÉTRICAS 
            /* isso aqui serve para casos como o do seno, coseno e tangente 
             */

            /* esse código abaixo declara um número e a parte que diz [ (2 * Math.PI) / 360; ] é literalmente 
             * pra transformar em um ângulo mesmo. fazendo com que o resultado seja em graus (tipo nas razões trigonométricas de um
             * triangulo retângulo. Já no caso do Math.Sín é pra usar a propriedade do seno. */


            double angulo = 30 * (2 * Math.PI) / 360;

            // SENO

            double seno = Math.Sin(angulo);
            Console.Write(seno);

            Console.WriteLine(); //Esse comando é para pular uma linha

            // COSENO
            double coseno = Math.Cos(angulo);
            Console.WriteLine(coseno);

            // TANGENTE

            double tangente = Math.Tan(angulo);
            Console.WriteLine(tangente);

            // Arcseno
            double arcseno = Math.Asin(seno);
            Console.WriteLine(arcseno);

            //Como obter novamente os graus do seno, coseno e/ou tangente: 

            double arcsenoGraus = arcseno * 360 / (2*Math.PI);
            Console.WriteLine(arcsenoGraus);

            /* o código acima funciona para as 3 formas de calcular (seno, coseno e tangente), basta usar a variável correta */

            // Arredondando números 

            //cima
            double numeroExemplo = 5.25;
            double arredondadoParaCima= Math.Ceiling(numeroExemplo);
            Console.WriteLine(arredondadoParaCima);

            //baixo
            double numeroExemplo2 = 5.25;
            double arredondadoParaBaixo = Math.Floor(numeroExemplo2);
            Console.WriteLine(arredondadoParaBaixo);

            //Logaritmo 

            double base1 = Math.Log10(100);
            Console.WriteLine(base1);

            double base2 = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(base2);

            Console.ReadKey();
        }
    }
}
