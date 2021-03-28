using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la siguiente firma: bool Validar(int valor, int min, int max):
//a.valor: dato a validar
//b. min y max: rango en el cual deberá estar la variable valor.
//Pedir al usuario que ingrese 10 números enteros.
//Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100.
//Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int numero = 0;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100: ");
                numero = int.Parse(Console.ReadLine());
                if (Validacion.Validar(numero, -100, 100))
                {
                    if (numero < min)
                        min = numero;
                    else if (numero > max)
                        max = numero;
                    acumulador += numero;
                } else {
                    Console.WriteLine("Numero no valido");
                }
            }
            Console.WriteLine("El numero minimo ingresado es: " + min + " el maximo es " + max + " y el promedio total es " + (acumulador / 10));
            Console.ReadKey();
        }
    }
}
