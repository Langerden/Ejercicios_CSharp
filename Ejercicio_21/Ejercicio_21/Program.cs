using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(10);
            Kelvin kelvin = new Kelvin(298);
            Fahrenheit fahrenheit = new Fahrenheit(77);

            Console.WriteLine("***** Resultados en Celsius *****");
            Celsius cAux = (Celsius)fahrenheit;
            Console.WriteLine("{0} Fahrenheit son {1} Celsius: ", fahrenheit.GetTemperatura(), cAux.GetTemperatura());
            cAux = (Celsius)kelvin;
            Console.WriteLine("{0} Kelvin son {1} Celsius: ", kelvin.GetTemperatura(), cAux.GetTemperatura());

            Console.WriteLine("\n***** Resultados en Kelvin *****");
            Kelvin kAux = (Kelvin)fahrenheit;
            Console.WriteLine("{0} Fahrenheit son {1} Kelvin: ", fahrenheit.GetTemperatura(), kAux.GetTemperatura());
            kAux = (Kelvin)celsius;
            Console.WriteLine("{0} Celsius son {1} Kelvin: ", celsius.GetTemperatura(), kAux.GetTemperatura());

            Console.WriteLine("\n***** Resultados en Fahrenheit *****");
            Fahrenheit fAux = (Fahrenheit)kelvin;
            Console.WriteLine("{0} Kelvin son {1} Fahrenheit: ", kelvin.GetTemperatura(), fAux.GetTemperatura());
            fAux = (Fahrenheit)celsius;
            Console.WriteLine("{0} Celsius son {1} Fahrenheit: ", celsius.GetTemperatura(), fAux.GetTemperatura());

            Console.ReadKey();

        }
    }
}
