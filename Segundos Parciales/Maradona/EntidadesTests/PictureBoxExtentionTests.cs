using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.Tests
{
    [TestClass()]
    public class PictureBoxExtentionTests
    {
        [TestMethod()]
        public void ReturnLastChar()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pic1";

            string lastChar = pictureBox.ReturnLastChar();

            Assert.AreEqual("1", lastChar);
        }
    }
}