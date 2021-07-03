using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_String
{
    public class Calculadora
    {
        public int Add(string numero)
        {
            int aux = 0;
            if(numero.StartsWith("//"))
            {
                char separador = numero[2];
                numero = numero.Substring(2).Replace(separador, ',');                
            }

            string[] numerosComa = numero.Split(',','\n');

            foreach (string item in numerosComa)
            {
                if(!string.IsNullOrWhiteSpace(item))
                    aux += int.Parse(item);            
            }
         return aux;        
        }
    }
}

