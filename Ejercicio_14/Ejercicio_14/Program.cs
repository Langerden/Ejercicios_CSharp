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
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado = 0;
            double baseTriangulo = 0;
            double alturaTriangulo = 0;
            double radioCirculo = 0;

            Console.WriteLine("Ingrese el valor de un lado del cuadrado para calcular su area: ");
            cuadrado = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el valor de la base del triangulo: ");
            baseTriangulo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingrese el valor de la altura del triangulo para calcular su area: ");
            alturaTriangulo = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el valor del radio del circulo para calcular el area: ");
            radioCirculo = Double.Parse(Console.ReadLine());

            Console.WriteLine("El area del cuadrado es: " + CalculoDeArea.CalcularCuadrado(cuadrado));
            Console.WriteLine("El area del triangulo es: " + CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo));
            Console.WriteLine("El area del circulo es: " + CalculoDeArea.CalcularCirculo(radioCirculo));
           
            Console.ReadKey();
        }
    }
}
