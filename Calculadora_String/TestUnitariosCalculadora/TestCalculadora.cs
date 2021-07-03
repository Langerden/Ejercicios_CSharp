using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora_String; 

namespace TestUnitariosCalculadora
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void WhenAddEmptyString_ReturnCero()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(0, calculadora.Add(""));
        }

        [TestMethod]
        public void WhenAddOne_Return1()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(1, calculadora.Add("1"));
        }

        [TestMethod]
        public void WhenAddTwoNumbers_ThenReturnSum()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(3, calculadora.Add("1,2"));
        }       
        
        [TestMethod]
        public void WhenAddManyNumbers_ThenReturnSum()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(8, calculadora.Add("1,2,5"));
        }

        [TestMethod]
        [ExpectedException(typeof (FormatException))]
        public void WhenAddAnyLetter_ThrowFormatException()
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Add("A, 2");
        }

        [TestMethod]
        public void WhenAddSpace_ThrowFormatException()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(8, calculadora.Add("1,2\n5"));
        }        
        
        [TestMethod]
        public void WhenAddBarras_ThenReturnSumByDelimitador()
        {
            Calculadora calculadora = new Calculadora();

            Assert.AreEqual(3, calculadora.Add("//;1;2"));
        }
    }
}
