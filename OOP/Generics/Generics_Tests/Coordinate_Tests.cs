using Generics;

namespace Generics_Tests
{
    [TestClass]
    public class Coordinate_Tests
    {
        [TestMethod]
        public void GetCoordinate_Int_StringCoordinates()
        {
            ICordinate coordinates = new Coordinate<int>(5, 6);

            var expected = "5;6";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ResetCoordinate_Int_ResetCoordinateToDefaultValue()
        {
            ICordinate coordinates = new Coordinate<int>(5, 6);

            coordinates.ResetCoordinate();

            var expected = "0;0";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetCoordinate_Double_StringCoordinates()
        {
            ICordinate coordinates = new Coordinate<double>(5.5, 6);

            var expected = "5.5;6";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ResetCoordinate_Double_ResetCoordinateToDefaultValue()
        {
            ICordinate coordinates = new Coordinate<double>(5, 6.6);

            coordinates.ResetCoordinate();

            var expected = "0;0";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetCoordinate_String_StringCoordinates()
        {
            ICordinate coordinates = new Coordinate<string>("5", "6");

            var expected = "5;6";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ResetCoordinate_String_ResetCoordinateToDefaultValue()
        {
            ICordinate coordinates = new Coordinate<string>("5", "6");

            coordinates.ResetCoordinate();

            var expected = ";";
            var actual = coordinates.GetCoordinate();

            Assert.AreEqual(expected, actual);
        }
    }
}