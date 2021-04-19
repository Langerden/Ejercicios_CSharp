using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public class Sobreescribir
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        //Sobreescribir el método Equals para que retorne true si son del mismo tipo(objetos de la misma clase), false en caso contrario.
        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
