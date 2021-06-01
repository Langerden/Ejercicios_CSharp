using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class TechnicalException : Exception
    {

            public TechnicalException() { }
            public TechnicalException(string message) : base(message) { }
            public TechnicalException(string message, Exception inner) : base(message, inner) { }
        
    }
}
