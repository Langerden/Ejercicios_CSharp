using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Tests
{
    [TestClass()]
    public class GolDelSigloTests
    {
        [TestMethod()]
        [ExpectedException(typeof(JugadaActivaException))]
        public void IniciarJugada_ThrowException()
        {
            GolDelSiglo golDelSiglo = new GolDelSiglo();

            golDelSiglo.IniciarJugada();
            golDelSiglo.IniciarJugada();
            
        }
    }
}