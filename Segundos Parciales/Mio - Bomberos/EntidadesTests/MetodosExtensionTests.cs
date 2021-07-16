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
    public class MetodosExtensionTests
    {
        [TestMethod()]
        public void DiferenciaEnMinutosTest()
        {
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now.AddMinutes(55);

            int dif = fechaInicio.DiferenciaEnMinutos(fechaFin);

            Assert.AreEqual(55, dif);
        }
    }
}