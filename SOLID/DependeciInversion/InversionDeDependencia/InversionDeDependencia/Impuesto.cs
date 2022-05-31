using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal abstract class Impuesto : Iimprimible
    {
        public Impuesto(double importe)
        {
            Importe = importe;
        }

        public double Importe { get; set; }

        public abstract void Imprimir();
    }
}
