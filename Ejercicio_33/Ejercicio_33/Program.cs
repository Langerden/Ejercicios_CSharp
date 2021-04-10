using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Epilogo";
            libro[1] = "Capitulo 1";
            libro[2] = "Capitulo 2";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(libro[i]);
            }

            Console.ReadKey();
        }
    }
}
