namespace MetoduPraktikosTestai
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void WordCount_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = metoduSavarankiskaPraktika.Program.WordCount(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WordCount_Test2()
        {
            var fake = "as mokausi programuoti                  ";
            var expected = 3;
            var actual = metoduSavarankiskaPraktika.Program.WordCount(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WordCount_Test3()
        {
            var fake = "as mokausi                programuoti                  ";
            var expected = 3;
            var actual = metoduSavarankiskaPraktika.Program.WordCount(fake);
            Assert.AreEqual(expected, actual);
        }
        */

        [TestMethod]
        public void PrintSpacesBeforeAndAfterWord_Test1()
        {
            var fake = "as mokausi programuoti ";
            var expected1 = 0;
            var expected2 = 1;
            metoduSavarankiskaPraktika.Program.PrintSpacesBeforeAndAfterWord(fake, out int actual1, out int actual2);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}