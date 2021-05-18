using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento estacionamiento = new Estacionamiento("PEDRO", 7);
            Assert.IsNotNull(estacionamiento);
            
        }
    }
}
