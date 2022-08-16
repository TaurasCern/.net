namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DecimalHour_Test1()
        {
            var fake = "30.30";
            var expected = "Decimal hour: 30.5";
            var actaul = debuginimoPraktika.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void DecimalHour_Test2()
        {
            var fake = "20.30.30";
            var expected = "Decimal hour: 20.5083";
            var actaul = debuginimoPraktika.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void DecimalHour_Test3()
        {
            var fake = "20";
            var expected = "Invalid time";
            var actaul = debuginimoPraktika.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actaul);
        }
    }
}