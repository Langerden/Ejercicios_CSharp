using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Application.Repositories;
using Application.Models;
using Application.Files.Text;
using Application.Files.Xml;

namespace Application.Tests
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Text_Exception_When_Invalid_Path()
        {
            //TODO implementar
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Xml_Exception_When_Invalid_Path()
        {
            //TODO implementar
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod]
       
        public void Xml_Deserialize()
        {
            //TODO implementar
            Assert.Inconclusive("A method that does not return a value cannot be verified.");


        }





    }
}
