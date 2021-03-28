using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)".
//En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir = 'S';
            int numero;
            int suma = 0;
            do
            {
                Console.WriteLine("Ingrese un numero por consola: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    suma += numero;
                }
                Console.WriteLine("¿Continuar? (S/N): ");
                seguir = Char.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N(seguir));
            Console.WriteLine("La suma total es: " + suma);
            Console.ReadKey();
        }
    }
}
