using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int count;
            int sum = 0;

            for(count = 0; count < 5; count++)
            {
                Console.WriteLine("Ingrese un numero por consola: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > max)
                        max = numero;
                    else if (numero < min)
                        min = numero;
                    sum += numero;
                }
            }
        Console.WriteLine("El numero maximo es {0}, el minimo es {1} y el promedio es {2}",max,min,(sum/count));
        Console.ReadKey();
        }
    }
}
