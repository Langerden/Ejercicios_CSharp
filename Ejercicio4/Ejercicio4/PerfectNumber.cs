using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
//(excluido el mismo) que son divisores del número.
//El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
//Escribir una aplicación que encuentre los 4 primeros números perfectos.
//Nota: Utilizar estructuras repetitivas y selectivas
namespace Ejercicio4
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            int divisor;
            int suma = 0;
            int iterar = 0;

            for (int numero = 1; iterar < 4; numero++)
            {
                suma = 0;
                for (divisor = 1; divisor <= (numero / 2); divisor++)
                {
                    if (numero % divisor == 0)
                        suma += divisor;
                }

                if (suma == numero)
                {
                    Console.WriteLine("El numero " + numero + " es perfecto");
                    iterar++;
                }
            }
            Console.ReadKey();
        }
    }
}
