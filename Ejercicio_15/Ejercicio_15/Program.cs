using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
//Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * ó /).
//El usuario decidirá cuándo finalizar el programa.
//Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
//a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación.
//b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
//Este método devolverá TRUE si el número es distinto de CERO.

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            char operation;

            Console.WriteLine("Ingrese un numero: ");
            number1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            number2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el caracter que corresponda a la operacion matematica (+, -, *, /)");
            operation = Char.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la operacion matematica elegida es: " + Calculadora.Calcular(number1, number2, operation));

            Console.ReadKey();
        }
    }
}
