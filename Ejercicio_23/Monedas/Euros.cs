using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euros
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public Euros()
        { }

        static Euros()
        {
            Euros.cotizRespectoDolar = 1.08;
        }

        public Euros(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euros(double cantidad, double cotizacion) : this(cantidad)
        {
            Euros.cotizRespectoDolar = cotizacion;
        }      

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euros.cotizRespectoDolar;
        }

        public static void SetCotizacion(double dolar)
        {
            Euros.cotizRespectoDolar = dolar;
        }

        public static explicit operator Dolar(Euros e)
        {
            return new Dolar(e.GetCantidad() / Euros.GetCotizacion());
        }

        public static explicit operator Pesos(Euros e)
        {
            return new Pesos(((Dolar)e).GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Euros(double d)
        {
            return new Euros(d);
        }

        public static bool operator !=(Euros e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euros e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euros e1, Euros e2)
        {
            return !(e1 == e2);
        }
        public static Euros operator -(Euros e, Dolar d)
        {
            return new Euros(e.GetCantidad() - ((Euros)d).GetCantidad());
        }

        public static Euros operator -(Euros e, Pesos p)
        {
            return new Euros(e.GetCantidad() - ((Euros)p).GetCantidad());
        }

        public static Euros operator +(Euros e, Dolar d)
        {
            return new Euros (e.GetCantidad() + ((Euros)d).GetCantidad());
        }

        public static Euros operator +(Euros e, Pesos p)
        {
            return new Euros(e.GetCantidad() + ((Euros)p).GetCantidad());
        }
        public static bool operator ==(Euros e, Dolar d)
        {
            return (e.GetCantidad() == ((Euros)d).GetCantidad());
        }
        public static bool operator ==(Euros e, Pesos p)
        {
            return (e.GetCantidad() == ((Euros)p).GetCantidad());
        }
        public static bool operator ==(Euros e1, Euros e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
    }
}
