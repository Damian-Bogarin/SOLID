using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDeDependencia
{
    internal class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo impuesto municipal {Partida} valor: {Importe} ");
        }
    }

}
