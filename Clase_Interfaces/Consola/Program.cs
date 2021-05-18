using Clase_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesado pesado = new Pesado("AABBCC", 150, "Chile", "Argentina", 15, true);
            Fragil fragil = new Fragil("HHGGTT", 170, "Mexico", "Buenos Aires", 10, false);

            GestionImpuestos impuestos = new GestionImpuestos();

            impuestos.recaudoAduana.Add(fragil);
            impuestos.recaudoAduana.Add(pesado);

            impuestos.recaudoAfip.Add(pesado);

            Console.WriteLine(pesado.InformacionPaquete());
            Console.WriteLine(fragil.InformacionPaquete());

            Console.WriteLine($"Total Impuestos Aduana: {impuestos.CalcularImpuestosTotalesAduana()}");
            Console.WriteLine($"Total Impuestos Afip: {impuestos.CalcularImpuestosTotalesAfip()}");

            Console.ReadKey();
        }
    }
}
