using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42.Tests
{
    [TestClass()]
    public class OtraClaseTests
    {
        [TestMethod()]
        [ExpectedException(typeof(MiExcepcion))]
        public void InstanciarMiClaseTest()
        {
            OtraClase otraClase = new OtraClase();
            otraClase.InstanciarMiClase();
        }
    }
}