using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.InstanciarMiClase();//provoco la excepción.
            }
            catch (MiExcepcion miEx)//se produce una excepción del tipo MiExcepcion
            {
                Console.WriteLine(miEx.Message);
                //Console.WriteLine(miEx.InnerException); //SI DEJO ESTO MUESTRA TODO EL PATH DE LOS ERRORES.
                Console.WriteLine(miEx.InnerException.Message);

                Exception ex = miEx.InnerException;
                Console.WriteLine($"MENSAJE: {ex.Message} EN: {ex.Source}");//Muestro solo la InnerException.
            }

            Console.ReadKey();
        }
    }
}
