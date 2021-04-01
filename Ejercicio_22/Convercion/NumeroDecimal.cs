using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumeroDecimal()
        {
            return this.numero;
        }

        public static implicit operator NumeroDecimal (double number)
        {
            return new NumeroDecimal(number);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(numeroBinario.GetNumeroBinario()));
        }

        public static NumeroDecimal operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return new NumeroDecimal(numeroDecimal.GetNumeroDecimal() + ((NumeroDecimal)numeroBinario).GetNumeroDecimal());
        }

        public static NumeroDecimal operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return new NumeroDecimal(numeroDecimal.GetNumeroDecimal() - ((NumeroDecimal)numeroBinario).GetNumeroDecimal());
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.GetNumeroDecimal() == ((NumeroDecimal)numeroBinario).GetNumeroDecimal();
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
    }
}
