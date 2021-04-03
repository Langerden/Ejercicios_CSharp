using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class Conversor
    {
        public static string DecimalBinario(int number)
        {
            string numeroBinario = "";
            char[] numeroBinarioCorrecto;

            if (number < 0)
                return "ERROR. Operacion no valida";
            else if (number == 0)
                return "0";
            else
            {
                while (number > 0)
                {
                    numeroBinario += number % 2;
                    number /= 2;
                }
            }
            numeroBinarioCorrecto = numeroBinario.ToCharArray();
            Array.Reverse(numeroBinarioCorrecto);
            return new string(numeroBinarioCorrecto);
        }

        public static int BinarioDecimal(string binario)
        {
            const int DIVISOR = 10;
            long numeroBinario = long.Parse(binario);
            int modulo = 0;
            int numeroDecimal = 0;

            for (long i = numeroBinario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                modulo = (int)i % DIVISOR;
                if (modulo != 1 && modulo != 0)
                    return -1;
                else
                    numeroDecimal += modulo * (int)Math.Pow(2, j);
            }
            return numeroDecimal;
        }
    }
}
