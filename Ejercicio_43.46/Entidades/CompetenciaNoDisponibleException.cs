using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string message, string clase, string metodo, Exception innerException) : base(message, innerException)
        {
        }

        public CompetenciaNoDisponibleException(string message, string clase, string metodo) : base(message)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}:", NombreMetodo, NombreClase);
            sb.AppendLine(base.Message);
            sb.Append(this.InnerException + "\t");
            return sb.ToString();
        }
    }
}
