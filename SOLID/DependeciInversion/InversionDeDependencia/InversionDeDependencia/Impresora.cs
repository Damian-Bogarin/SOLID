using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal class Impresora
    {
        public void Imprimir(Iimprimible imprimir)
        {
            imprimir.Imprimir();
        }
    }
}
