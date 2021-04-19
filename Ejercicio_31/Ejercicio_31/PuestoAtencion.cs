using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get {
                return ++numeroActual;
            }
        }        
        public bool Atender (Cliente cliente)
        {
            int siguiente = PuestoAtencion.NumeroActual;
            Thread.Sleep(900);
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
