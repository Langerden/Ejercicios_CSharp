using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit()
        { }

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        } 

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetTemperatura() - 32) * 5/ 9);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin ((f.GetTemperatura() + 459.67) * 5/9);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f.GetTemperatura() == ((Fahrenheit)k).GetTemperatura());
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return (f.GetTemperatura() == ((Fahrenheit)c).GetTemperatura());
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetTemperatura() == f2.GetTemperatura());
        }


        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetTemperatura() - ((Fahrenheit)k).GetTemperatura());
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetTemperatura() - ((Fahrenheit)c).GetTemperatura());
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetTemperatura() + ((Fahrenheit)k).GetTemperatura());
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetTemperatura() + ((Fahrenheit)c).GetTemperatura());
        }
        
    }
}
