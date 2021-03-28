using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación.
//b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
//Este método devolverá TRUE si el número es distinto de CERO.
namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2, char operation)
        {
            if (operation == '+')
                return Math.Round((num1 + num2),2);
            else if (operation == '-')
                return Math.Round((num1 - num2), 2);
            else if (operation == '*')
                return Math.Round((num1 * num2), 2);
            else if (operation == '/')
            {
                if (Validar(num2))
                    return Math.Round((num1 / num2), 2);
                else
                    return 0;
            } else
            {
                return -1;
            }
        }

        private static bool Validar (double num2)
        {
            if (num2 != 0)
                return true;
            else
                return false;
        }
    }
}
