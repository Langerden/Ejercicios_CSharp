using Ejercicio_30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(string escuderia, short numero) : base(escuderia, numero)
        {
        }

        public MotoCross(string escuderia, short numero, short cilindro) : this(escuderia, numero)
        {
            this.cilindrada = cilindro;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public override string MostrarDatos()
        {
            return (base.MostrarDatos() + $"\nCILINDRADA: {Cilindrada}");
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return ((m1.Numero == m2.Numero) && (m1.Escuderia == m2.Escuderia) && (m1.Cilindrada == m2.Cilindrada));
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

    }
}
