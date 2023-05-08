using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_matemáticas_Em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroMatematico = 15;
            double numeroMatematico2 = 20.2;
            //SOMA (+)
            double resultadoSoma = numeroMatematico + numeroMatematico2;
            Console.WriteLine(" O resultado da soma entre " + numeroMatematico + " e " + numeroMatematico2 + " é igual a: " + resultadoSoma );

            //SUBTRAÇÃO (-)
            double resultadoSubtracao = numeroMatematico - numeroMatematico2;
            Console.WriteLine(" O resultado da subtração entre " + numeroMatematico + " e " + numeroMatematico2 + " é igual a: " + resultadoSubtracao);

            //MULTIPLICAÇÃO (*)
            double resultadoMultiplicacao = numeroMatematico * numeroMatematico2;
            Console.WriteLine(" O resultado da multiplicação entre " + numeroMatematico + " e " + numeroMatematico2 + " é igual a: " + resultadoMultiplicacao);

            // DIVISÃO (/)
            double resultadoDivisao = numeroMatematico / numeroMatematico2;
            Console.WriteLine(" O resultado da divisão entre " + numeroMatematico + " e " + numeroMatematico2 + " é igual a: " + resultadoDivisao);

            //RESTO (%)
            double restoNumerico = 50;
            double restoNumerico2 = 15;
            double resultadoResto = restoNumerico % restoNumerico2;
            Console.WriteLine(" O resto entre " + restoNumerico + " e " + restoNumerico2 + " é igual a: " + resultadoResto);

            //INCREMENTAR (++)
            int incrementar = 1;
            int adicionarIncremento = incrementar++;
            Console.WriteLine(" o valor de " + 1 + " quando é incrementado é igual a " + incrementar);

            //DECREMENTAR (--)
            double decremento = 10.5;
            double decrementarNumero = decremento--;
            Console.WriteLine(" o valor de " + 10.5 + " quando é decrementado é igual a " + decremento);

            //SOMAR OU SUBTRAIR O CONTEÚDO DE UMA VARIÁVEL(+=) e (-=)
            int numero1 = 22;
            numero1 += 22;
            Console.WriteLine(" O resultado de " + 21 + " mais " + 21 + " é igual a " + numero1);        

            int numero2 = 21;
            numero2 -= 21;
            Console.WriteLine(" O resultado de " + 20 + " menos " + 20 + " é igual a " + numero2);

            //MULTIPLICAR OU DIVIDIR O CONTEÚDO DE UMA VARIÁVEL (*=) e (/=)
            int numero3 = 20;
            numero3 *= 20;
            Console.WriteLine(" O resultado da multiplicação de " + 19 + " vezes " + 19 + " é igual a " + numero3);

            int numero4 = 19;
            numero4 /= 19;
            Console.WriteLine(" O resultado da divisão de " + 19 + " dividido por " + 19 + " é igual a " + numero4);

            Console.ReadKey();
        }
    }
}
