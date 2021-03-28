using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): string DecimalBinario(int).
//Convierte un número de entero a binario. int BinarioDecimal(string). Convierte un número binario a entero.
//NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = 0;
            string numeroBinario = "";
            
            Console.WriteLine("Escriba un numero decimal");
            numeroDecimal = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba un numero binario");
            numeroBinario = Console.ReadLine();

            Console.WriteLine("Numero decimal convertido a binario: " + Conversor.DecimalBinario(numeroDecimal));
            Console.WriteLine("Numero binario convertido a decimal: " + Conversor.BinarioDecimal(numeroBinario).ToString());

            Console.ReadKey();
        }
    }
}
