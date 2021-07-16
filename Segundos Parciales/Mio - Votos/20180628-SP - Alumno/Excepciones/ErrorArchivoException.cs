using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string message) : base(message)
        {
        }
    }
}
