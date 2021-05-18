using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    public class QuesoAzul : Ingredientes
    {
        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }

        private Procedencia procedencia;

        public QuesoAzul(string descripcion, int cantidad) : base(descripcion, cantidad)
        {
        }        
        
        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia) : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }

        public override string Proceso
        {
            get { return "desgranar" ; }
        }

        public override string UnidadMedida
        {
            get { return "gramos"; }
        }


        public new string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0} Procedente de: {1}", base.Informacion(), this.procedencia));
            return sb.ToString();
        }

    }
}
