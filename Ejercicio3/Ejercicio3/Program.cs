using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPrimo = 0;

            Console.WriteLine("Ingrese un numero para mostrar todos los numeros primos: ");
            
            if (int.TryParse(Console.ReadLine(), out numeroPrimo))
            {
                for (int i = 1; i <= numeroPrimo; i++)
                {
                    if (numeroPrimo % i == 0)
                        Console.WriteLine("Numero Primo: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
