using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class MetodoExtension
    {
        public static string FormatearPrecio(this double valor)
        {
            return string.Format("${0:n2}", (valor));
        }
    }
}
