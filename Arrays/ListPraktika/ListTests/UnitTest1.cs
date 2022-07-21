using System.Diagnostics;

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
        [TestMethod]
        public void Avg_Test()
        {
            var numbers = new List<int>() { 5, 10, 5, 0 };
            var actual = ListPraktika.Program.Avg(numbers);
            var expected = 5d;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPositive_Test()
        {
            var numbers = new List<int>() { 5, 10, -5, 0 };
            var actual = ListPraktika.Program.IsPositive(numbers);
            var expected = new List<string> { "Teigiamas", "Teigiamas", "Neigiamas", "Teigiamas" };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateGPM_Test()
        {
            var numbers = new List<double>() { 100, 200, 300, 400 };
            var actual = ListPraktika.Program.CalculateGPM(numbers,15);
            var expected = 150d;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IstrauktiSkaicius_Test()
        {
            var fake = "sadc5sdcsa5cds1cdscds2dcsd";
            var actual = ListPraktika.Program.IstrauktiSkaicius(fake);
            var expected = new List<int> { 1, 2, 5, 5};
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sort_Test()
        {
            var fake = "5512";
            var actual = ListPraktika.Program.Sort(fake);
            var expected = new List<int> { 1, 2, 5, 5 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IstrauktiSkaicius_Test1()
        {
            var fake = "sadc5sdcsa5cds1cdscds2dcsd";
            var actual = String.Join("", ListPraktika.Program.IstrauktiSkaicius(fake));
            var expected = "1255";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsmetytiZodziai_Test()
        {
            var fake = "aa bbbbb ee ddd ff zzzzz aaaaaa";
            var actual = ListPraktika.Program.IsmetytiZodziai(fake);
            foreach(var a in actual)
            {            
                Trace.WriteLine(a);
            }

            var expected = new List<string> {"aa", "ddd", "ee", "ff", "aaaaaa", "bbbbb", "zzzzz"};
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineLists_Test()
        {
            var fake1 = new List<string>() { "aaa", "aaa", "aaa"};
            var fake2 = new List<string>() { "bbb", "bbb", "bbb" };
            var actual = ListPraktika.Program.CombineLists(fake1, fake2);
            var expected = new List<string> { "aaa", "aaa", "aaa", "bbb", "bbb", "bbb" };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}