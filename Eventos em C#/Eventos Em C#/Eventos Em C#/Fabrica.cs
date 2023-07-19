using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Em_C_
{
    internal class Fabrica
    {
        public delegate void delegateFabrica (object origem, EventArgs e);

        public event delegateFabrica eventoFabrica;

        public void mensagemDaFabrica()
        {
            if (eventoFabrica != null)
            {
                EventArgs e = new EventArgs();
                eventoFabrica(this, e);
            }
        }
    }
}
