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
        [TestMethod]
        public void Exercise4()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = { 0, 2, 4, 6, 8 };

            var actual = LINQ.Program.Filter4th(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exercise5()
        {
            int[] arr =  { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] expected = { 1, 3, 12, 19, 6, 9, 10, 14 };

            var actual = LINQ.Program.Filter5th(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exercise6()
        {
            int[] arr = { 3, 9, 2, 8, 6, 5 };
            int[] expected = { 9, 81, 4, 64, 36, 25 };

            var actual = LINQ.Program.Filter6th(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exercise7()
        {
            int[] arr = { 3, 9, 2, 8, 6, 5, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var expected = new Dictionary<int, int>()
            {
                { 3, 3 },
                { 9, 3 },
                { 2, 3 },
                { 8, 2 },
                { 6, 4 },
                { 5, 4 },
                { 1, 1 },
                { 7, 3 },              
                { 4, 1 },
            };

            var actual = LINQ.Program.Filter7th(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}