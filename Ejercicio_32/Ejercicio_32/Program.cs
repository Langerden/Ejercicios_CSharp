using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(11, "Carlos", 3, 5);
            Jugador j2 = new Jugador(22, "Pedro", 7, 1);
            Jugador j3 = new Jugador(33, "Leo", 10, 15);
            Equipo original = new Equipo(3, "YKC");

            Console.WriteLine("Promedio Goles J1: " + j1.PromedioGoles);
            Console.WriteLine("Promedio Goles J2: " + j2.PromedioGoles);
            Console.WriteLine("Promedio Goles J3: " + j3.PromedioGoles);

            if (original + j1 && original + j2 && original + j3)
            {
                Console.WriteLine(j1.MostrarDatos());
                Console.WriteLine(j2.MostrarDatos());
                Console.WriteLine(j3.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
