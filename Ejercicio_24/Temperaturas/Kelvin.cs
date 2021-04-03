using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        private double temperatura;

        public Kelvin()
        { }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public void SetTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((((Fahrenheit)k).GetTemperatura() - 32) * 5 / 9);
        }

        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetTemperatura() * 9 / 5) - 459.67);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.GetTemperatura() == ((Kelvin)f).GetTemperatura();
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k.GetTemperatura() == ((Kelvin)c).GetTemperatura());
        }
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.GetTemperatura() == k2.GetTemperatura());
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
        public static Kelvin operator -(Fahrenheit f, Kelvin k)
        {
            return new Kelvin(k.GetTemperatura() - ((Kelvin)f).GetTemperatura());
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetTemperatura() - ((Kelvin)c).GetTemperatura());
        }

        public static Kelvin operator +(Fahrenheit f, Kelvin k)
        {
            return new Kelvin(k.GetTemperatura() + ((Kelvin)f).GetTemperatura());
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetTemperatura() + ((Kelvin)c).GetTemperatura());
        }

    }
}
