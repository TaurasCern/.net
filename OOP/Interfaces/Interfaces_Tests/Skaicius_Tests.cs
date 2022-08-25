using Interfaces.Domain.Models;
namespace Interfaces_Tests
{
    [TestClass]
    public class Skaicius_Tests
    {
        [TestMethod]
        public void Prideti_Test()
        {
            var fakeNumberObject = new Skaicius(5);
            var fakeNumber = 5;

            var expected = 10;
            var actual = fakeNumberObject.Prideti(fakeNumber);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Atimti_Test()
        {
            var fakeNumberObject = new Skaicius(5);
            var fakeNumber = 5;

            var expected = 0;
            var actual = fakeNumberObject.Atimti(fakeNumber);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Padauginti_Test()
        {
            var fakeNumberObject = new Skaicius(5);
            var fakeNumber = 5;

            var expected = 25;
            var actual = fakeNumberObject.Padauginti(fakeNumber);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Padalinti_Test()
        {
            var fakeNumberObject = new Skaicius(5);
            var fakeNumber = 5;

            var expected = 1;
            var actual = fakeNumberObject.Padalinti(fakeNumber);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PakeltiKvadratu_Test()
        {
            var fakeNumberObject = new Skaicius(5);

            var expected = 25;
            var actual = fakeNumberObject.PakeltiKvadratu();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PakeltiKubu_Test()
        {
            var fakeNumberObject = new Skaicius(5);

            var expected = 125;
            var actual = fakeNumberObject.PakeltiKubu();

            Assert.AreEqual(expected, actual);
        }
    }
}