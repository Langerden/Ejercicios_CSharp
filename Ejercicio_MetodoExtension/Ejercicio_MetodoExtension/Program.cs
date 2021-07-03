using Biblioteca_Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_MetodoExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            string invierno = date.ObtenerPlacaCronica(Estaciones.Invierno);
            string verano = date.ObtenerPlacaCronica(Estaciones.Verano);
            string otonio = date.ObtenerPlacaCronica(Estaciones.Otonio);
            string primavera = date.ObtenerPlacaCronica(Estaciones.Primavera);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(invierno);
            Console.WriteLine(verano);
            Console.WriteLine(otonio);
            Console.WriteLine(primavera);
            Console.ReadKey();
        }
    }
}
