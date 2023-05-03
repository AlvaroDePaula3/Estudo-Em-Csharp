using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEmC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool rell1 = true;
            bool rell2 = false;

            //negação
            bool negationRell1 = !rell1;
            bool negationRell2 = !rell2;

            Console.WriteLine("o resultado de " + negationRell1 + " é falso");
            Console.WriteLine("o resultado de " + negationRell2 + " é verdadeiro");

            //E
            bool ERell1 = rell1 & rell2;
            bool ERell2 = rell1 & rell1;
            bool ERell3 = rell2 & rell2;

            Console.WriteLine("O resultado de " + ERell1 + " é falso");
            Console.WriteLine("O resultado de " + ERell2 + " é verdadeiro");
            Console.WriteLine("O resultado de " + ERell3 + " é falso");

            //OU

            bool OURell1 = rell1 | rell2;
            bool OURell2 = rell1 | rell1;
            bool OURell3 = rell2 | rell2;

            Console.WriteLine("O resultado de " + OURell1 + " é verdadeiro");
            Console.WriteLine("O resultado de " + OURell2 + " é verdadeiro");
            Console.WriteLine("O resultado de " + OURell3 + " é falso");

            //XOR

            bool XORRell1 = rell1 ^ rell2;
            bool XORRell2 = rell1 ^ rell1;
            bool XORRell3 = rell2 ^ rell2;

            Console.WriteLine("O resultado de " + XORRell1 + " é verdadeiro");
            Console.WriteLine("O resultado de " + XORRell2 + " é falso");
            Console.WriteLine("O resultado de " + XORRell3 + " é falso");


            Console.ReadKey();
        }
    }
}
