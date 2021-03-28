using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;


//a.Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
//b.El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
//c.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
//d.Colocar dentro del Main el código necesario para probar todos los métodos.
//e.Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.
//f.Los comparadores == compararan cantidades.
//g.Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
//Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
//h.Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.
namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {   
            Dolar dolar = new Dolar(1.08);
            Euros euro = new Euros(1, 1.08);
            Pesos peso = new Pesos(71.28, 66);

            Euros auxE = euro + dolar;
            Console.WriteLine("***************************");
            Console.WriteLine("Euro + Dolar: " + Math.Round(auxE.GetCantidad(),2));
            Console.WriteLine($"Euro + Dolar (Facu Style): {Math.Round(auxE.GetCantidad(),2)}");
            auxE = euro + peso;
            Console.WriteLine("Euro + Pesos: " + Math.Round(auxE.GetCantidad(),2)); 
            auxE = euro - dolar;
            Console.WriteLine("Euro - Dolar: " + Math.Round(auxE.GetCantidad(), 2));
            bool euroDolar = euro == dolar;
            Console.WriteLine("¿Euro == Dolar?: " + euroDolar);

            Console.WriteLine("***************************");
            Dolar auxD = dolar + euro;
            Console.WriteLine("Dolar + Euro: " + Math.Round(auxD.GetCantidad(),2));
            auxD = dolar + peso;
            Console.WriteLine("Dolar + Peso: " + Math.Round(auxD.GetCantidad(),2));

            Console.WriteLine("***************************");
            Pesos auxP = peso + dolar;
            Console.WriteLine("Peso + Dolar: " + Math.Round(auxP.GetCantidad(),2));
            auxP = peso + euro;
            Console.WriteLine("Peso + Euro: " + Math.Round(auxP.GetCantidad(),2));
            bool pesoDolar = peso == dolar;
            Console.WriteLine("¿Peso == Dolar?: " + pesoDolar);

            Console.ReadKey();
        }
    }
}
