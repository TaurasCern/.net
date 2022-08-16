namespace SkaiciuotuvoTestai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test1()
        {
            var num1 = 15;
            var num2 = 20;
            var actual = cikluPraktika2.Program.Add(num1, num2);
            var expected = 35;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_Test1()
        {
            var num1 = 15;
            var num2 = 20;
            var actual = cikluPraktika2.Program.Substract(num1, num2);
            var expected = -5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiply_Test1()
        {
            var num1 = 15;
            var num2 = 20;
            var actual = cikluPraktika2.Program.Multiply(num1, num2);
            var expected = 300;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test1()
        {
            var num1 = 15;
            var num2 = 5;
            var actual = cikluPraktika2.Program.Divide(num1, num2);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Pow_Test1()
        {
            var num1 = 4;
            var num2 = 3;
            var actual = cikluPraktika2.Program.Pow(num1, num2);
            var expected = 64;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareRoot_Test1()
        {
            var num1 = 16;
            var actual = cikluPraktika2.Program.SquareRoot(num1);
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}