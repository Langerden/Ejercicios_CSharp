using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        static double cotizRespectoDolar;

        public Pesos()
        { }

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
       
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }

        public static explicit operator Euros(Pesos p)
        {
            return new Euros(((Dolar)p).GetCantidad() / Euros.GetCotizacion());
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Pesos p, Euros e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euros e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euros e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p.GetCantidad() == ((Pesos)d).GetCantidad());
        }
        public static bool operator ==(Pesos p, Euros e)
        {
            return (p.GetCantidad() == ((Pesos)e).GetCantidad());
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
    }
}
