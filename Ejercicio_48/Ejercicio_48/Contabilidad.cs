using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad <T, U> 
        where T : Documento 
        where U : Documento, new ()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad <T,U> operator + (Contabilidad <T,U> contabilidad, T egreso)
        {
            if (contabilidad != null && egreso != null)
                contabilidad.egresos.Add(egreso);
           return contabilidad;
        }        
        
        public static Contabilidad <T,U> operator + (Contabilidad <T,U> contabilidad, U ingresos)
        {
            if (contabilidad != null && ingresos != null)
                contabilidad.ingresos.Add(ingresos);
            return contabilidad;
        }
    }
}
