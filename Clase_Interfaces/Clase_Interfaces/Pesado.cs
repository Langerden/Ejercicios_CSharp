using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Interfaces
{
    public class Pesado : Paquete, IAduana, IAfip
    {
        private bool prioridad;

        public Pesado(string codigoSeguimiento, double costoEnvio, string destino, string origen, double peso, bool prioridad) : base(codigoSeguimiento, costoEnvio, destino, origen, peso)
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
            sb.AppendLine($"Total Aduana: {((IAduana)this).CalcularImpuesto()}");
            sb.AppendLine($"Total Afip: {((IAfip)this).CalcularImpuesto()}");
            return sb.ToString();
        }

        double IAduana.CalcularImpuesto()
        {
            return this.costoEnvio * 0.35;
        }        
        
        double IAfip.CalcularImpuesto()
        {
            return this.costoEnvio * 0.25;
        }
    }
}
