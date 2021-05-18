using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(short edad, string nombre)
        {
            Edad = edad;
            Nombre = nombre;
        }

        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public static explicit operator string (Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            if (persona.Validar())
            {
                sb.AppendLine($"Nombre: {persona.nombre}");
                sb.AppendLine($"Edad: {persona.edad}");
                return sb.ToString();
            }
            else
            {
                return "Informacion sin cargar";
            }            
        }

        protected virtual string Mostrar()
        {
            return (string) this;
        }

        public abstract bool Validar();

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
