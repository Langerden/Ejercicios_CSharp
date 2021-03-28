using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("Perro", "Lola",DateTime.Now);
            Mascota mascota2 = new Mascota("Gato", "Shina", new DateTime(2012, 05, 25));
            Mascota mascota3 = new Mascota("Gato", "Shazam", new DateTime(2020, 08, 17));
            Mascota mascota4 = new Mascota("Perro", "Piri", new DateTime(2018, 03, 09));

            Cliente cliente1 = new Cliente("Calle 123", "Pedro", "Perez", "4587-1254");
            Cliente cliente2 = new Cliente("Av 457", "Juan", "Alvarez", "4700-5478");
            Cliente cliente3 = new Cliente("Calle 999", "Alejo", "Nuñez", "7845-0478");
            
            Vacuna vacunaRabia = new Vacuna("Rabia");

            mascota2.AgregarVacuna(vacunaRabia);
            cliente1.AgregarMascota(mascota2);

            Console.WriteLine(cliente1.MostrarDatos());

            Console.ReadKey();
        }
    }
}
