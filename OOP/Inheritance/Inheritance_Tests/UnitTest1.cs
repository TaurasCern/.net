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
        public void UniversityPerson_AssignHobbiesRandomly_Test()
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
            var fakeUniversityPerson = new UniversityPerson() 
            { 
                Id = 1,
                FirstName = "Vardas",
                LastName = "Pavarde",
                Gender = Inheritance.Domain.Enums.EGenderType.MALE,
                BirthDate = new DateTime(2000,1,1),
                Height = 170,
                Weight = 70
            };

            fakeUniversityPerson.Profession = new Profession("1;Accountant;Buhalteris".Split(";"));

            var expected = "1,Vardas,Pavarde,MALE,1/1/2000 12:00:00 AM,170,70,1,Accountant,Buhalteris";
            var actual = fakeUniversityPerson.GetCsv();

            Assert.AreEqual(expected, actual);
        }
    }
}