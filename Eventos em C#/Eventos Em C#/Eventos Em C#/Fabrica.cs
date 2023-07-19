using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Em_C_
{
    internal class Fabrica
    {
        public delegate void delegateFabrica (object origem, eventoVariante e);

        public event delegateFabrica eventoFabrica;

        public void mensagemDaFabrica(UInt32 preco)
        {
            if (eventoFabrica != null)
            {
                eventoVariante e = new eventoVariante(preco);
                eventoFabrica(this, e);
            }
        }
    }
}
