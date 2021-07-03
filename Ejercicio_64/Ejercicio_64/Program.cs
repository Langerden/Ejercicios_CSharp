using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("Sora");
            negocio.Clientes.Add("Riku");
            negocio.Clientes.Add("Kairi");
            negocio.Clientes.Add("Axel");

            Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            hiloNegocio.Name = "Kingdom Hearts";

            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            hiloCaja1.Name = "Caja 1";

            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            hiloCaja2.Name = "Caja 2";

            hiloNegocio.Start();
            hiloNegocio.Join();

            hiloCaja1.Start();
            Thread.Sleep(5000);

            hiloCaja2.Start();

            Console.ReadKey();

        }
    }
}
