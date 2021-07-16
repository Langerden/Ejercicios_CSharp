using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Entidades.Tests
{
    [TestClass()]
    public class ComercioTests
    {
        [TestMethod()]
        [ExpectedException(typeof(SinClientesExcepcion))]

        public void WhenLlamarCliente_ThrowException()
        {
            Comercio comercio = new Comercio();
            comercio.LlamarCliente();
        }

        [TestMethod()]
        public void MismoBackUp()
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}//archivo.xml";
            Comercio comercio = new Comercio();
            Comercio comercio2 = new Comercio();
            comercio += new Cliente("Cliente1");
            comercio += new Cliente("Cliente2");
            comercio.SaveBackup(path);
            comercio2.LoadBackup(path);

            Assert.AreEqual(comercio.Clientes.Count, comercio2.Clientes.Count);
        }

        [TestMethod()]
        public void AgregarClientesSuccess()
        {
            Comercio comercio = new Comercio();
            comercio  += new Cliente("Cliente1");
            comercio += new Cliente("Cliente2");
            Assert.AreEqual(1, comercio.Clientes.ElementAt(0).Numero);
            Assert.AreEqual(2, comercio.Clientes.ElementAt(1).Numero);

        }
    }
}