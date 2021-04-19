using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(10, "Carlos");
            Cliente cliente2 = new Cliente(7, "Fede");
            Cliente cliente3 = new Cliente(2, "Juan");
            Negocio negocio1 = new Negocio("Mc Donalds");

            bool comparacionClientes = cliente1 == cliente2;
            Console.WriteLine($"{cliente1.Nombre} es igual que {cliente2.Nombre}?: {comparacionClientes}");

            if(negocio1 + cliente3)
                Console.WriteLine("El cliente se agregó al negocio ");
            else
                Console.WriteLine("No se pudo agregar al cliente");

            if (negocio1 == cliente3)
                Console.WriteLine("El cliente está en la tienda");
            else
                Console.WriteLine("El cliente no está en la tienda");

            if (~negocio1)
                Console.WriteLine($"Se está atendiendo al cliente {cliente1.Nombre}");


            Console.ReadKey();
        }
    }
}
