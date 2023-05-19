using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Em_C_
{
    internal class Program
    {
        enum Dinheiro
        {
         real1 = 1,
         real2 = 2,
         real5 = 5,
         real10 = 10,
         real20 = 20,
         real50 = 50,
         real100 = 100
        }

        enum Ordem
        {
            numero100 = 100,
            numero101,
            numero102,
            numero103,
            numero104,
        }

        static void Main(string[] args)
        {
            Dinheiro notas = Dinheiro.real10;
            Console.WriteLine("O valor de " + notas + " é " + Convert.ToUInt32(notas));

            Console.WriteLine();

            Ordem teste = Ordem.numero102;
            Console.WriteLine("O valor de " +  teste + " é na verdade " + Convert.ToUInt32(teste));

            Console.WriteLine();

            /*Essa regra também funciona para números negativos, porém vc não pode converter para UInt32, afinal isso só aceita
            números negativos */

            Console.ReadKey();
        }
    }
}
