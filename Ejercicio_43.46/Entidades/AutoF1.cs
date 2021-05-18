using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosFuerza;

        public AutoF1(string escuderia, short numero) : base(escuderia, numero)
        {
        }

        public AutoF1(string escuderia, short numero, short caballosFuerza) : this(escuderia, numero)
        {
            this.caballosFuerza = caballosFuerza;
        }

        public short CaballosFuerza
        {
            get { return this.caballosFuerza; }
            set { this.caballosFuerza = value; }
        }

        public override string MostrarDatos()
        {
            return (base.MostrarDatos() + $"\nCABALLOS DE FUERZA: {CaballosFuerza}");
        }

        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {
            return ((f1.Numero == f2.Numero) && (f1.Escuderia == f2.Escuderia) && (f1.CaballosFuerza == f2.CaballosFuerza));
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }

    }
}
