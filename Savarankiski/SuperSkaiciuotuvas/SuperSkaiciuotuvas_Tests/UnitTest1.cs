using System.Diagnostics;

namespace SuperSkaiciuotuvas_Tests
{
    [TestClass()]
    public class UnitTest1
    {
        
        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_Test()
        {
            var fake = 15;
            var fake1 = 15;

            var expected = 30d;

            var actual = SuperSkaiciuotuvas.Program.Add(fake, fake1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Substract_Test()
        {
            var fake = 15;
            var fake1 = 15;

            var expected = 0d;

            var actual = SuperSkaiciuotuvas.Program.Substract(fake, fake1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Multiply_Test()
        {
            var fake = 13;
            var fake1 = 3;

            var expected = 39d;

            var actual = SuperSkaiciuotuvas.Program.Multiply(fake, fake1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Divide_Test()
        {
            var fake = 15;
            var fake1 = 15;

            var expected = 1d;

            var actual = SuperSkaiciuotuvas.Program.Divide(fake, fake1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Power_Test()
        {
            var fake = 4;
            var fake1 = 3;

            var expected = 64d;

            var actual = SuperSkaiciuotuvas.Program.Power(fake, fake1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SquareRoot_Test()
        {
            var fake = 25;

            var expected = 5d;

            var actual = SuperSkaiciuotuvas.Program.SquareRoot(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}