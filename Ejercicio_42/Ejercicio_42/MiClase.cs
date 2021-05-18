using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodo();
            }
            catch (DivideByZeroException exDiv)
            {
                throw exDiv;
            }
        }

        public MiClase(int cualquierCosa)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException exDiv)
            {
                throw new UnaExcepcion("No se puede dividir por 0, bestia peluda", exDiv);
            }
        }

        public static void MiMetodo()
        {
            try
            {
                int num01 = 20;
                int num02 = 0;
                int resultado = num01 / num02;
            }
            catch (DivideByZeroException exDiv)
            {
                throw exDiv;
            }
        }
    }
}
