namespace ListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindBiggestNumber_Test()
        {
            var numbers = new List<int>() { 1, 4, 2, 7, 2 };
            var actual = ListPraktika.Program.FindHighestNumber(numbers);
            var expected = 7;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindBiggestNumbers_Test1()
        {
            var numbers = new List<int>() { 5,1,6,8,7 };
            var actual = ListPraktika.Program.FindHighestNumber(numbers);
            var expected = 8;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DidesnisUzDidziausia_Test()
        {
            var numbers = new List<int>() { 5, 1, 6, 8, 7 };
            var actual = ListPraktika.Program.DidesnisUzDidziausia(numbers);
            var expected = new List<int>() { 5, 1, 6, 8, 7, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DidesnisUzDidziausia1_Test()
        {
            var numbers = new List<int>() { 5, 1, 6, 8, 7 };
            var actual = ListPraktika.Program.DidesnisUzDidziausia1(numbers);
            var expected = new List<int>() { 1, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DidesnisUzDidziausia2_Test()
        {
            var numbers = new List<int>() { 5, 1, 6, 8, 7 };
            var actual = ListPraktika.Program.DidesnisUzDidziausia2(numbers);
            var expected = new List<int>() { 5, 1, 6, 8, 7, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveLowestNumber_Test()
        {
            var numbers = new List<int>() { 5, 1, 6, 8, 7, 1 };
            var actual = ListPraktika.Program.RemoveLowestNumber(numbers);
            var expected = new List<int>() { 5, 6, 8, 7 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}