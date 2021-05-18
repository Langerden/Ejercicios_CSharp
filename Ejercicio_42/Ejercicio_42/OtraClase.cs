using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public void InstanciarMiClase()
        {
            try
            {
                new MiClase();
            } catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("Error personalizado", ex);
            }
        }
    }
}
