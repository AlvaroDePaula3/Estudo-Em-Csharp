using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_De_decisões_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite o DDD de sua cidade: ");
            UInt32 Cidade = Convert.ToUInt32(Console.ReadLine());

            if (Cidade == 21) //Obrigatório
            {
                Console.WriteLine("Você é do Rio de Janeiro");
            }
            else //Opcional
            {
                Console.WriteLine(" Você é de outro estado do Brasil ");
            }

            Console.WriteLine("Digite sua idade aqui: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());

            if (Idade <= 12)
            {
                Console.WriteLine("Você é criança");

            }
            else if (Idade <= 17) //quantos desejarmos
            {
                Console.WriteLine("Você é jovem");
            }
            else  if (Idade <= 59){
                Console.WriteLine("Você é adulto");
            }
            else {
                Console.WriteLine( "Você está na terceira idade");
                    }

            //SWITCH

            Console.WriteLine( "Quantos GB RAM tem o seu computador ?");
            char ram = Console.ReadKey(true).KeyChar;
            switch (ram)
            {
                case '2':
                    Console.WriteLine("Você tem 2GB RAM");
                    break;
                case '4':
                    Console.WriteLine("Você tem 4GB RAM");
                    break;
                case '8':
                    Console.WriteLine("Você tem 8GB RAM");
                    break;
                default: 
                    break;
        }
            
            Console.ReadKey();
        }
    }
}
