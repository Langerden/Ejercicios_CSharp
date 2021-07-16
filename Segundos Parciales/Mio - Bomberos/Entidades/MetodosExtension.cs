using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosExtension
    {
        public static int DiferenciaEnMinutos(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).Minutes;
        }
    }
}
