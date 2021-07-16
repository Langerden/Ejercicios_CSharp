using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.Tests
{
    [TestClass()]
    public class BomberoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Bombero bombero = new Bombero();
            Bombero bomberoBin = new Bombero("Nombre");
            bombero.Guardar(bomberoBin);
            Assert.IsTrue(File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Binary.bin"));
            //Assert.ThrowsException<Exception>(()=>/*miVariable*/.Importar(Environment.CurrentDirectory + @"\ImportXml\XMLQueNoExiste.xml", out listaDeserializadora));

        }

        [TestMethod()]
        public void LeerTest()
        {
            Bombero bom = new Bombero();
            Bombero bomberoDes = bom.Leer();
            Assert.IsNotNull(bomberoDes);
        }

        [TestMethod()]
        public void BomberoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BomberoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AtenderSalidaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LeerTest1()
        {
            Assert.Fail();
        }
    }
}