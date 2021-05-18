using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;
        
        public int Tamanio
        {
            get { return this.tamanio; }            
        }

        public abstract bool TieneFores { get; }
        public abstract bool TieneFruta { get; }

        protected Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public virtual string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0} tiene un tamaño de {1}", this.nombre, this.Tamanio));
            if(this.TieneFores)
                sb.AppendLine(String.Format("TIENE FLORES: SI"));
            else
                sb.AppendLine(String.Format("TIENE FLORES: NO"));

            if (this.TieneFruta)
                sb.AppendLine(String.Format("TIENE FRUTOS: SI"));
            else
                sb.AppendLine(String.Format("TIENE FRUTOS: NO"));
            return sb.ToString();
        }
    }
}
