using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BomberoOcupadoException : Exception
    {
        public BomberoOcupadoException(string message) : base("Salida bombero X no concretada")
        {
        }
    }
}
