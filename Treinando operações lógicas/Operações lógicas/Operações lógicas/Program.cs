using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_lógicas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Negação
            
            int Exemplo1 = 0b00011110;
            int negacaoExemplo1 = ~Exemplo1;
            Console.WriteLine("A variável " + (Convert.ToString(negacaoExemplo1, 2)) + " é a negação da variável " + (Convert.ToString(Exemplo1, 2)));

            int Exemplo2 = 10;
            int negacaoExemplo2 = ~Exemplo2;
            Console.WriteLine("A variável " + (Convert.ToString(negacaoExemplo2)) + " é a negação da variável " + (Convert.ToString(Exemplo2)));

            //OU
            int codigo = 0b11100000;
            int codigo2 = 0b00000111;
            int ResultadoOU = codigo | codigo2;
            Console.WriteLine("A comparação entre: " + (Convert.ToString(codigo, 2)) + " e " + (Convert.ToString(codigo2, 2)) + " resulta em " + (Convert.ToString(ResultadoOU, 2)));

            //E
            int codigoE = 0b11100111;
            int codigoE2 = 0b10010011;
            int resultadoE = codigoE & codigoE2;
            Console.WriteLine("O resultado entre: " + (Convert.ToString(codigoE, 2)) + " e " + (Convert.ToString(codigoE2, 2)) + " é " + (Convert.ToString(resultadoE, 2)));

            //XOR
            int codigoXOR = 0b00110011;
            int codigoXOR2 = 0b11000011;
            int resultadoXOR = codigoXOR ^ codigoXOR2;
            Console.WriteLine("O resultado entre: " + (Convert.ToString(codigoXOR, 2)) + " e " + (Convert.ToString(codigoXOR2, 2)) + " é " + (Convert.ToString(resultadoXOR, 2)));

            //MAIOR QUE (>) E MENOR QUE (<):

            int evee = 15;
            int pikachu = 30;
            Console.WriteLine("O valor de " + evee + " é maior que (>) " + pikachu + " ? " + (evee > pikachu));
            Console.WriteLine("O valor de " + evee + " é menor que (<) " + pikachu + " ? " + (evee < pikachu));

            // MAIOR OU IGUAL (>=) E MENOR OU IGUAL (<=)

            Console.WriteLine(" O valor de " + evee + " é (>=) do que o " + pikachu + " ?: " + (evee >= pikachu));
            Console.WriteLine(" O valor de " + evee + " é (<=) do que o " + evee + " ?: " + (evee <= evee));
            Console.WriteLine(" O valor de " + pikachu + " é (<=) do que o " + evee + " ?: " + (pikachu <= evee));
            Console.WriteLine(" O valor de " + pikachu + " é (<=) do que o " + pikachu + " ?: " + (pikachu <= pikachu));

            // IGUAL (==)

            bool igualdade = (evee == evee);
            Console.WriteLine(" O valor de " + evee + " é igual(==) ao valor de " + pikachu + " ?: " + (evee == pikachu));
            Console.WriteLine(" O valor de " + evee + " é igual(==) ao valor de " + evee + " ?: " + (evee == evee));


            Console.ReadKey();

        }
    }
}
