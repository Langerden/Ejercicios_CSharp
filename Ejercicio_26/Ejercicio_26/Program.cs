using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    /**
     * Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
     * a. Mostrar el vector tal como fue ingresado
     * b. Luego mostrar los positivos ordenados en forma decreciente.
     * c. Por último, mostrar los negativos ordenados en forma creciente.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 50);
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************");

            for (int k = 0; k < numbers.Length; k++)
            {
                for (int f = 0; f < numbers.Length - 1; f++)
                {
                    if (numbers[f] < numbers[f + 1])
                    {
                        int aux;
                        aux = numbers[f];
                        numbers[f] = numbers[f + 1];
                        numbers[f + 1] = aux;
                    }
                }
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
