using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
//a. double CalcularCuadrado(double)
//b. double CalcularTriangulo(double, double)
//c. double CalcularCirculo(double)
//El ingreso de los datos como la visualización se deberán realizar desde el método Main().
namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            if (lado > 0)
                return lado * lado;
            else
                return -1;
        }

        public static double CalcularTriangulo(double lado, double altura)
        {
            if (lado > 0 && altura > 0)
                return (lado * altura) / 2;
            else
                return -1;
        }

        public static double CalcularCirculo(double radio)
        {
            if (radio > 0)
                return Math.Round(Math.PI * radio * radio,2);
            else
                return -1;
        }
    }
}
