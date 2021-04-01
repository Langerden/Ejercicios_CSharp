using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversores;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario binario = "1001";
            NumeroDecimal decimalNumber = 9;

            NumeroBinario auxB = (NumeroBinario)decimalNumber;
            Console.WriteLine("El numero decimal {0} es en binario: {1}", decimalNumber.GetNumeroDecimal(),auxB.GetNumeroBinario());
            NumeroDecimal auxD = (NumeroDecimal)binario;
            Console.WriteLine("El numero binario {0} es en decimal: {1}", binario.GetNumeroBinario(), auxD.GetNumeroDecimal());

            Console.WriteLine("\n**** SUMAS *****");
            auxB = (binario + decimalNumber).GetNumeroBinario();
            Console.WriteLine("La suma del decimal {0} y el numero binario {1} es en binario: {2}",
                decimalNumber.GetNumeroDecimal(), binario.GetNumeroBinario(), auxB.GetNumeroBinario());
            
            auxD = (decimalNumber + binario).GetNumeroDecimal();
            Console.WriteLine("La suma del decimal {0} y el numero binario {1} es en decimal: {2}",
                decimalNumber.GetNumeroDecimal(), binario.GetNumeroBinario(), auxD.GetNumeroDecimal());

            Console.WriteLine("\n**** RESTAS *****");
            auxB = (binario - decimalNumber).GetNumeroBinario();
            Console.WriteLine("La resta del decimal {0} y el numero binario {1} es en binario: {2}",
                decimalNumber.GetNumeroDecimal(), binario.GetNumeroBinario(), auxB.GetNumeroBinario());

            auxD = (decimalNumber - binario).GetNumeroDecimal();
            
            if (auxD.GetNumeroDecimal() < 0) 
            {
                Console.WriteLine("No se puede convertir a binario un numero negativo. ");
            }
            else
            {
                Console.WriteLine("La resta del decimal {0} y el numero binario {1} es en decimal: {2}",
                    decimalNumber.GetNumeroDecimal(), binario.GetNumeroBinario(), auxD.GetNumeroDecimal());
            }

            Console.ReadKey();
        }
    }
}
