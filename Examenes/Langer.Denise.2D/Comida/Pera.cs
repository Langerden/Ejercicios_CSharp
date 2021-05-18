using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    public class Pera : Ingredientes
    {

        private string tipo;

        public override string Proceso
        {
            get { return "cubitar" ; }
        }

        public override string UnidadMedida
        {
            get { return "unidades"; }
        }

        public new string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0} Tipo: {1}", base.Informacion(), this.tipo));
            return sb.ToString();
        }

        public Pera(string descripcion, int cantidad, string tipo) : base (descripcion, cantidad)
        {
            this.tipo = tipo;
        }
    }
}
