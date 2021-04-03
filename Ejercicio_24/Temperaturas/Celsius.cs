using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        private double temperatura;

        public Celsius()
        { }

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public void SetTemperatura (double temperatura)
        {
            this.temperatura = temperatura;
        }

        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }


        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetTemperatura() + 459.67) * 5 / 9);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetTemperatura() * 9 / 5 + 32);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.GetTemperatura() == ((Celsius)k).GetTemperatura();
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.GetTemperatura() == ((Celsius)f).GetTemperatura();
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetTemperatura() == c2.GetTemperatura();
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetTemperatura() - ((Celsius)k).GetTemperatura());
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetTemperatura() - ((Celsius)f).GetTemperatura());
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetTemperatura() + ((Celsius)k).GetTemperatura());
        }
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetTemperatura() + ((Celsius)f).GetTemperatura());
        }

    }
}
