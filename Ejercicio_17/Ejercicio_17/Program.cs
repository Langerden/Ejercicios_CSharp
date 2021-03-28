using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impresora;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string printAzul;
            string printRojo;

            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine("Color: " + azul.GetColor());
            Console.WriteLine("Tinta: " + azul.GetTinta());
            
            azul.Pintar(-20, out printAzul);
            Console.WriteLine("Tinta Actual: " + azul.GetTinta() + "\nNivel tinta: \n" + azul.PrintGasto(azul.GetTinta()));

            azul.Pintar(-40, out printAzul);
            Console.WriteLine("Tinta Actual: " + azul.GetTinta() + "\nNivel tinta: \n" + azul.PrintGasto(azul.GetTinta()));

            azul.Pintar(-60, out printAzul);
            Console.WriteLine("Tinta Actual: " + azul.GetTinta() + "\nNivel tinta: \n" + azul.PrintGasto(azul.GetTinta()));

            azul.Recargar();
            Console.WriteLine("\nTinta: " + azul.GetTinta());

            Console.ReadKey();

        }
    }
}
