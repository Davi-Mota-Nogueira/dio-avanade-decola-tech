using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aritmetica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica.Tests
{
    [TestClass()]
    public class AritmeticaTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            //Arrange
            var x = 4;
            var y = 5;
            var esperado = 9;
            var aritmetica = new Aritmetica();

            //Act
            var result = aritmetica.Soma(x, y);

            //Assert
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            //Arrange
            var x = 10;
            var y = 5;
            var esperado = y;
            var aritca = new Aritmetica(); 

            //Act
            var result = aritca.Subtracao(x, y);

            //Assert
            Assert.AreEqual(esperado, result);
        }
    }
}