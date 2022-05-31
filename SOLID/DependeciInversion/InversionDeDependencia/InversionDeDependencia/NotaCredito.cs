using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "NC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura{Numero} del {Fecha} ");
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}
