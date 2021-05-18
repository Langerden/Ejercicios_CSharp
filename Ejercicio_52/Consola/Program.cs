using Ejercicio_53;
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
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(ConsoleColor.Green, 1);
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");

            Cartuchera1 c1 = new Cartuchera1();
            Cartuchera2 c2 = new Cartuchera2();

            c1.listaAcciones.Add(miLapiz);
            c1.listaAcciones.Add(miBoligrafo);

            c2.listaBoligrafo.Add(miBoligrafo);
            c2.listaLapiz.Add(miLapiz);

            c2.ProbarElementosBoligrafo();

            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.WriteLine(c1.ProbarElementos());
            Console.WriteLine(c2.ProbarElementosBoligrafo());            
            Console.WriteLine(c2.ProbarElementosLapiz());

            Console.ReadKey();
        }
    }
}
