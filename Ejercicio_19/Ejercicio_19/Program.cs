using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();

            Console.WriteLine(sumador1.Sumar(10, 15));
            Console.WriteLine(sumador1.Sumar(15, 15));
            Console.WriteLine(sumador2.Sumar("Aguante ", "Bokita"));

            int dato = (int)sumador1;
            int dato2 = (int)sumador2;

            Console.WriteLine(dato);
            Console.WriteLine(dato2);
            
            Console.WriteLine(sumador1+sumador2);
            Console.WriteLine(sumador1|sumador2);

            Console.ReadKey();
        }
    }
}
