using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int numeroUsuario;
            bool esPrimo;

            Console.WriteLine("Ingrese un numero para calcular los numeros primos: ");
            numeroUsuario = int.Parse(Console.ReadLine());
            if (numeroUsuario > 1)
            {
                while (numeroUsuario > 1)
                {
                    esPrimo = true;
                    for (int i = 2; i < numeroUsuario; i++)
                    {
                        if (numeroUsuario % i == 0)
                            esPrimo = false;
                    }
                    if (esPrimo)
                        Console.WriteLine(numeroUsuario + " es primo");
                    numeroUsuario--;
                }
            }
            Console.ReadKey();
        }
    }
}