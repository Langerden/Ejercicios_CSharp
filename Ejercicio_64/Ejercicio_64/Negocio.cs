using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public Caja Caja1 { get => caja1; }
        public Caja Caja2 { get => caja2;}
        public List<string> Clientes { get => clientes; }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (var item in Clientes)
            {
                Thread.Sleep(1000);
                if(caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                {
                    Caja1.FilaClientes.Add(item);
                } else
                {
                    Caja2.FilaClientes.Add(item);
                }
            }
        }
    }
}
