using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
//Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                Console.WriteLine("El cuadrado es: " + Math.Pow(numero, 2) + " y el cubo es: " + Math.Pow(numero, 3));

            } else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            Console.ReadKey();
        }
    }
}
