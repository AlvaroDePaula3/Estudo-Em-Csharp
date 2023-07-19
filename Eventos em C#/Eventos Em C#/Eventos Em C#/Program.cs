using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabrica novaFabrica = new Fabrica();
            Concessionaria novaConcessionaria = new Concessionaria("HB20", novaFabrica);

            novaFabrica.mensagemDaFabrica(6000);

            Console.ReadKey();
        }
    }
}
