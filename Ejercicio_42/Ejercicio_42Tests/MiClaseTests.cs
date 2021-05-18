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
    public class MiClaseTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClaseTest()
        {
            MiClase clase = new MiClase();
        }

        [TestMethod()]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseTest1()
        {
            MiClase clase = new MiClase(4);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiMetodoTest()
        {
            MiClase.MiMetodo();
        }
    }
}