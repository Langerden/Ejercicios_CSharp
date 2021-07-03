using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;

        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { 
                this.nombre = value;
                this.EventoString.Invoke(this.Mostrar());
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { 
                this.apellido = value;
                this.EventoString.Invoke(this.Mostrar());
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            return sb.ToString();
        }
    }
}
