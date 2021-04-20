using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            Circulo circulo = new Circulo(3);
            Cuadrado cuadrado = new Cuadrado(4);
            Rectangulo rectangulo = new Rectangulo(2,3);

            figuras.Add(circulo);
            figuras.Add(cuadrado);
            figuras.Add(rectangulo);

            foreach(Figura figura in figuras)
            {
                Console.WriteLine("*****************");
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine("Perimetro: " + Math.Round(figura.CalcularPerimetro()),2);
                Console.WriteLine("Superficie: " + Math.Round(figura.CalcularSuperficie()),2);
                Console.WriteLine("Tipo de Figura: " + figura.GetType().Name);
                
            }
            Console.ReadKey();
        }
    }
}
