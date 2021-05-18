using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Interfaces
{
    public class Fragil : Paquete, IAduana
    {
        private bool prioridad;

        public Fragil(string codigoSeguimiento, double costoEnvio, string destino, string origen, double peso, bool prioridad) : base(codigoSeguimiento, costoEnvio, destino, origen, peso)
        {
            this.prioridad = prioridad;
        }

        protected override bool Prioridad
        {
            get { return this.prioridad; }            
        }

        public override string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InformacionPaquete());
            sb.Append($"Prioridad:");
            if (Prioridad)
                sb.AppendLine("SI");
            else
                sb.AppendLine("NO");
            sb.AppendLine($"Total Aduana: {this.CalcularImpuesto()}");
            return sb.ToString();
        }

        //• Implementa la interfaz IAduana, que retornara el impuesto al costo del envió (35%)
        public double CalcularImpuesto()
        {
            return this.costoEnvio * 0.35;
        }
    }
}
