using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Em_C_
{
    internal class eventoVariante: EventArgs
    {
        private UInt32 precoDoCarro;

        public UInt32 valorDoCarro
        {
            get { return precoDoCarro; }
        }
        public eventoVariante(UInt32 preco)
        {
            precoDoCarro = preco;
        }
    }
}
