using System;

namespace Entidades
{
    public class SinClientesExcepcion : Exception
    {
        public SinClientesExcepcion()
        {
        }

        public SinClientesExcepcion(string message) : base(message)
        {
        }

        public SinClientesExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
