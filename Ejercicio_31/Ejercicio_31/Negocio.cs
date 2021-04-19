using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Clientes
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool resultado;
                resultado = this + value;
            }
        }

        public int ClientesPendientes { 
            get
            {
                return this.clientes.Count();
            }         
        }

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this ()
        {   
            this.nombre = nombre;
        }

        public static bool operator == (Negocio n, Cliente c)
        {
            if(n.clientes.Count > 0)
            {
                foreach(Cliente cliente in n.clientes)
                {
                    if (cliente == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator != (Negocio n, Cliente c)
        {
            return !(n == c);
        }        

        public static bool operator ~ (Negocio n)
        {
            return n.caja.Atender(n.clientes.Dequeue());
        }
        
        public static bool operator + (Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
