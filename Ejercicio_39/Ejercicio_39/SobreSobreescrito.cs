using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    public class SobreSobreescrito : Sobreescribir
    {
        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
