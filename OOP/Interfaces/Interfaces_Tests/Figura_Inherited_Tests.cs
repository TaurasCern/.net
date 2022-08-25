using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Models;
using Interfaces.Domain.Interfaces;


namespace Interfaces_Tests
{
    [TestClass]
    public class Figura_Inherited_Tests
    {
        [TestMethod]
        public void Figura_Name_Test()
        {
            var fakeFigura = new Kvadratas(5);

            var expected = "Kvadratas";
            var actual = fakeFigura.Name;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Kvadratas_Perimetras_Test()
        {
            var fakeFigura = new Kvadratas(5);

            var expected = 20;
            var actual = fakeFigura.Perimetras();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Kvadratas_Plotas_Test()
        {
            IGeometrija fakeFigura = new Kvadratas(5);

            var expected = 25;
            var actual = fakeFigura.Plotas();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Apskritimas_Perimetras_Test()
        {
            var fakeFigura = new Apskritimas(5);

            var expected = Math.PI * 5d * 2d;
            var actual = fakeFigura.Perimetras();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Apskritimas_Plotas_Test()
        {
            var fakeFigura = new Apskritimas(5);

            var expected = Math.PI * 5 * 5;
            var actual = fakeFigura.Plotas();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Staciakampis_Perimetras_Test()
        {
            var fakeFigura = new Staciakampis(5, 5);

            var expected = 20;
            var actual = fakeFigura.Perimetras();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Staciakampis_Plotas_Test()
        {
            var fakeFigura = new Staciakampis(5, 5);

            var expected = 25;
            var actual = fakeFigura.Plotas();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StatusisTrikampis_Perimetras_Test()
        {
            var fakeFigura = new StatusisTrikampis(5, 5);

            var expected = 10 + Math.Sqrt(50);
            var actual = fakeFigura.Perimetras();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StatusisTrikampis_Plotas_Test()
        {
            var fakeFigura = new StatusisTrikampis(5, 5);

            var expected = 12.5;
            var actual = fakeFigura.Plotas();

            Assert.AreEqual(expected, actual);
        }
    }
}
