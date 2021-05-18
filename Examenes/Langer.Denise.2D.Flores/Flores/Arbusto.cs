using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores
{
    public class Arbusto : Planta
    {

        public override bool TieneFores
        {
            get
            {
                return false;
            }
        }

        public override bool TieneFruta
        {
            get
            {
                return false;
            }
        }

        public Arbusto(string nombre, int tamanio) : base(nombre,tamanio)
        {
            
        }
    }
}
