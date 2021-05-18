using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    public abstract class Ingredientes
    {
        private int cantidad;
        private string descripcion;

        public int Cantidad
        {
            get { return this.cantidad; }
        }

        public virtual string Proceso
        {
            get { return this.descripcion; }
        }        
        
        public abstract string UnidadMedida
        {
            get;
        }

        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("CANTIDAD: {0}, DESCRIPCION: {1}", Cantidad, Proceso));
            return sb.ToString();
        }

        protected Ingredientes(string descripcion, int cantidad)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }
    }
}
