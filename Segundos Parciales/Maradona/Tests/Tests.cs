using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Entidades
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(JugadaActivaException))]
        public void IniciarJugada_ThrowException()
        {
            GolDelSiglo golDelSiglo = new GolDelSiglo();

            golDelSiglo.IniciarJugada();
            golDelSiglo.IniciarJugada();
        }

        [TestMethod]
        public void TestPictureBoxExtension()
        {
            
        }
    }
}
