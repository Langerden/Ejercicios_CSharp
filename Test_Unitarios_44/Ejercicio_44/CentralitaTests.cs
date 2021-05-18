using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia.Tests
{
    [TestClass()]
    public class CentralitaTests
    {
        [TestMethod]
        public void ListaLlamadas_IsNotNull()
        {
            Centralita centralita = new Centralita();

            Assert.IsNotNull(centralita.Llamadas);
        }

        //Dentro de un método de test unitario
        //crear dos llamadas Local y dos Provincial,
        //todos con los mismos datos de origen y destino.
        //Luego comparar cada uno de estos cuatro objetos contra
        //los demás, debiendo ser iguales solamente las instancias
        //de Local y de Provincial entre sí.

        [TestMethod]
        public void ValidarObjetos()
        {

            Local local1 = new Local("Cordoba", 145, "CABA", 66);
            Local local2 = new Local("Cordoba", 145, "CABA", 66);
            Provincial prov1 = new Provincial("Cordoba", Provincial.Franja.Franja_2, 145, "CABA");
            Provincial prov2 = new Provincial("Cordoba", Provincial.Franja.Franja_2, 145, "CABA");

            Assert.AreEqual(local1, local2);
            Assert.AreEqual(prov1, prov2);
            Assert.AreNotEqual(local1, prov1);
            Assert.AreNotEqual(local2, prov2);
        }
    }
}