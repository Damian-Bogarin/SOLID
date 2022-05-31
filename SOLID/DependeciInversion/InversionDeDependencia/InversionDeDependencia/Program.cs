using System;

namespace InversionDeDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Iimprimible factura = new Factura(1234, DateTime.Now, 303);


            impresora.Imprimir(factura);
        }
    }
}
