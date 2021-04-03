using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumeroBinario()
        {
            return this.numero;
        }

        public static implicit operator NumeroBinario(string number)
        {
            return new NumeroBinario(number);
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return new NumeroBinario(Conversor.DecimalBinario((int)numeroDecimal.GetNumeroDecimal()));
        }

        public static NumeroBinario operator + (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            int binario1 = Conversor.BinarioDecimal(numeroBinario.GetNumeroBinario());//Binario a Decimal
            int sum = binario1 + (int)numeroDecimal.GetNumeroDecimal(); //Suma en Decimales

            return new NumeroBinario(Conversor.DecimalBinario(sum)); //Decimal a Binario);
        }

        public static NumeroBinario operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {

            double binario1 = (double)Conversor.BinarioDecimal(numeroBinario.GetNumeroBinario());//Binario a Decimal
            double resta = numeroDecimal.GetNumeroDecimal() - binario1; //Resta en Decimales
            return new NumeroBinario(Conversor.DecimalBinario((int)resta).ToString());
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.GetNumeroBinario() == ((NumeroBinario)numeroDecimal).GetNumeroBinario();
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }        
    }
}
