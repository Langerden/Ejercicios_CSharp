using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Interfaces
{
    public class GestionImpuestos
    {
        public List<IAduana> recaudoAduana;
        public List<IAfip> recaudoAfip;

        public GestionImpuestos()
        {
            this.recaudoAduana = new List<IAduana>();
            this.recaudoAfip = new List<IAfip>();
        }

        public double CalcularImpuestosTotalesAfip()
        {
            double result = 0;
            foreach (IAfip item in this.recaudoAfip)
            {
                result += item.CalcularImpuesto();
            }
            return result;
        }       
        
        public double CalcularImpuestosTotalesAduana()
        {
            double result = 0;
            foreach (IAduana item in this.recaudoAduana)
            {
                result += item.CalcularImpuesto();
            }
            return result;
        }
    }
}
