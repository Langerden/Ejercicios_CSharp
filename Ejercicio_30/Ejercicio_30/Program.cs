using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1("Lannister", 10);
            AutoF1 auto2 = new AutoF1("Targaryan", 60);
            AutoF1 auto3 = new AutoF1("Stark", 80);

            Competencia competencia = new Competencia(3, 6);

            if(competencia + auto1)
            {
                Console.WriteLine(auto1.MostrarDatos());
            }

            if (competencia + auto2)
            {
                Console.WriteLine(auto2.MostrarDatos());
            }

            if (competencia + auto3)
            {
                Console.WriteLine(auto3.MostrarDatos());
            }

            if (competencia - auto1)
                Console.WriteLine("Se elimino el competidor: " + auto1.Numero);

            Console.ReadKey();
        }
    }
}
