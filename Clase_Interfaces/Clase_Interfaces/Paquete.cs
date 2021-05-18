using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Interfaces
{
    public abstract class Paquete
    {
        protected string codigoSeguimiento;
        protected double costoEnvio;
        protected string destino;
        protected string origen;
        protected double peso;

        protected Paquete(string codigoSeguimiento, double costoEnvio, string destino, string origen, double peso)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.peso = peso;
        }

        public virtual string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo Seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo Envio: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso: {this.peso}");
            return sb.ToString();
        }

        protected abstract bool Prioridad
        {get;}
    }
}
