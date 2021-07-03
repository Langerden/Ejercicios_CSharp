using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes() 
        {

            foreach (var item in FilaClientes)
            {
                Console.WriteLine($"Atendiendo a {item} en la {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
            }
        }
    }
}
