using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;
        public Sumador() : this(0) {}

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador sumador) {
            return sumador.cantidadSumas;
        }

        public static bool operator | (Sumador sumador1, Sumador sumador2)
        {   if (sumador1.cantidadSumas == sumador2.cantidadSumas)
                return true;
            else
                return false;
        }

        public static long operator + (Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }
    }
}
