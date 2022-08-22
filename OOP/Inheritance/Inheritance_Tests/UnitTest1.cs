using Inheritance.Domain.Models;

namespace Inheritance_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hobby_SetInitialData_Test()
        {
            var fakeHobby = new Hobby();
            fakeHobby.EncodeCsv("3,Animation,Animacija");

            var expected = new Hobby() { Id = 3, Text = "Animation", TextLt = "Animacija" };
            var actual = fakeHobby;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UniversityPerson_PickProfessionRandomly_Test()
        {
            var fakeUniversityPerson = new UniversityPerson();
            fakeUniversityPerson.Profession = new Profession("1;Accountant;Buhalteris".Split(";"));
            var random = new Random(1);
            fakeUniversityPerson.AssignHobbiesRandomly(random);

            var expected = 0;
            var actual = fakeUniversityPerson.Hobbies.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UniversityPerson_GetCsv_Test()
        {
            var fakeUniversityPerson = new UniversityPerson();
            fakeUniversityPerson.Profession = new Profession("1;Accountant;Buhalteris".Split(";"));
            fakeUniversityPerson.Hobbies = new List<Hobby>()
            {
                new Hobby() { Id = 1, Text = "Astrology", TextLt = "Astrologija"}
            };

            var expected = "1,Accountant,Buhalteris,1,Astrology,Astrologija";
            var actual = fakeUniversityPerson.GetCSV();

            Assert.AreEqual(expected, actual);
        }
    }
}