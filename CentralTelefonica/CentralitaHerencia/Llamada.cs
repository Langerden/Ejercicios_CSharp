using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return duracion; }            
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public string NroOrigen
        {
            get
            { return nroDestino; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        //OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
        public static int OrdenarPorDuracion (Llamada l1, Llamada l2)
        {
            return l1.Duracion.CompareTo(l2.Duracion);
        }

        //Mostrar es un método de instancia. Utiliza StringBuilder.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"DURACION: {this.Duracion}, NRO DESTINO: {this.NroDestino}, NRO ORIGEN: {this.NroOrigen}");
            return sb.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
