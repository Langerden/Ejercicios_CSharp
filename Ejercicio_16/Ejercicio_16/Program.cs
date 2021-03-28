using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno facundo = new Alumno("Falcone", 105450, "Facundo");
            Alumno denise = new Alumno("Langer", 110053, "Denise");
            Alumno cata = new Alumno("Heredia", 140047, "Catalina");

            facundo.Estudiar(8, 9);
            denise.Estudiar(3, 8);
            cata.Estudiar(10, 10);
            
            facundo.CalcularFinal();
            denise.CalcularFinal();
            cata.CalcularFinal();

            Console.WriteLine(facundo.Mostrar());
            Console.WriteLine(denise.Mostrar());
            Console.WriteLine(cata.Mostrar());

            Console.ReadKey();
        }
    }
}
