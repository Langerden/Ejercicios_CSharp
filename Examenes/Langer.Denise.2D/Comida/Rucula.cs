using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    public class Rucula : Ingredientes
    {
        public Rucula(string descripcion, int cantidad) : base(descripcion, cantidad)
        {
        }

        public override string Proceso
        {
            get { return "cortar" ; }
        }

        public override string UnidadMedida
        {
            get { return "hojas"; }
        }


    }
}
