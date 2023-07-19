using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Em_C_
{
    internal class Concessionaria
    {
        private string carro;

        public void carroPronto(object origem, eventoVariante e)
        {
            Console.WriteLine("O carro " + carro + " pode ser vendido pelo valor de: R$" + e.valorDoCarro) ;
        }

        public Concessionaria (string carroFeito, Fabrica parametroFabrica)
        {
            carro = carroFeito;
            parametroFabrica.eventoFabrica += carroPronto;
        }
    }
}
