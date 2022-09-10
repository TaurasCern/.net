namespace LINQ_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Filterint_IEnumerableInt_FilteredIEnuberableInt()
        {
            List<int> list = new List<int>() { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 };
            var expected = new List<int> { 78, 85, 39, 49, 55, 95};

            var actual = LINQ.Program.Filter1st(list);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FilterString_IEnumerableString_FilteredIEnuberableString()
        {
            List<string> list = new List<string>() { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };
            var expected = new List<string> { "GREEN", "PURPLE", "MAGENTA", "TOMATO"};

            var actual = LINQ.Program.Filter2nd(list);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FilterString3rd_IEnumerableString_FilteredIEnuberableString()
        {
            List<string> list = new List<string>() { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };
            var expected = new List<string> { "dangus", "darzelis", "daumantas" };

            var actual = LINQ.Program.Filter3rd(list);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}