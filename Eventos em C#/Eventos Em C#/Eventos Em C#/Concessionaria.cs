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

        public void carroPronto(object origem, EventArgs e)
        {
            Console.WriteLine("O carro " + carro + " está pronto para ser vendido.");
        }

        public Concessionaria (string carroFeito, Fabrica parametroFabrica)
        {
            carro = carroFeito;
            parametroFabrica.eventoFabrica += carroPronto;
        }
    }
}
