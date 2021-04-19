using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
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

        public abstract float CostoLlamada
        {
            get;
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
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"DURACION: {this.Duracion}, NRO DESTINO: {this.NroDestino}, NRO ORIGEN: {this.NroOrigen}");
            return sb.ToString();
        }

        //El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo (utilizar método Equals, sobrescrito en las clases derivadas)
        //y los números de destino y origen son iguales en ambas llamadas.
        public static bool operator == (Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                return true;
            else
                return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
