using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal class ReciboSueldo : Iimprimible
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

     public int Legajo { get; set; }
        public double Total { get; set; }


        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo legajo numero {Legajo}");
        }

    }
}
