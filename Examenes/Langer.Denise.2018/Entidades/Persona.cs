using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        protected Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.documento = documento;
            this.nombre = nombre;
        }

        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Documento
        {
            get { return this.documento; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {Nombre} APELLIDO: {Apellido} DNI: {Documento}");
            return sb.ToString();
        }

        protected abstract bool ValidarDocumento(string doc);
    }
}
