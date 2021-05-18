using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZ
{
    public abstract class Personaje
    {
        protected List<EHabilidad> ataques;
        protected int nivelPoder;
        protected string nombre;

        protected virtual string Description
        {
            get { return ""; }
        }

        private Personaje()
        {
            this.ataques = new List<EHabilidad>();   
        }

        protected Personaje(string nombre, int nivelPoder)
        {
            this.nombre = nombre;
            this.nivelPoder = nivelPoder;
        }

        protected Personaje(string nombre, int nivelPoder, List<EHabilidad> ataque) : this (nombre, nivelPoder)
        {
            this.ataques = ataque;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public abstract string Transformarse();

        public virtual string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nivel poder: {this.nivelPoder}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Ataque: {this.ataques}");
            return sb.ToString();
        }

        public static bool operator == (Personaje p1, List<Personaje> personajes)
        {
            bool result = false;
            foreach (Personaje item in personajes)
            {
                if (personajes.Contains(p1))
                    result = true;
            }
            return result;
        }        
        
        public static bool operator == (Personaje p1, Personaje p2)
        {
            return (p1.GetType().Equals(p2.GetType()) && p1.nombre == p2.nombre);
        }

        public static bool operator !=(Personaje p1, List<Personaje> personajes)
        {
            return !(p1 == personajes);
        }

        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }
    }
}
