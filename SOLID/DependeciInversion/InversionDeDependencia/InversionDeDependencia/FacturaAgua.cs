using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal class FacturaAgua : Impuesto
    {
        public FacturaAgua(double importe, string codigoPago): base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de agua {CodigoPago} ");
        }
    }
}
