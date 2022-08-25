using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;
using Interfaces.Domain.Models;

namespace Interfaces_Tests
{
    [TestClass]
    public class Employee_Tests
    {
        [TestMethod]
        public void GetAdress_Empty_ReturnsAdressOfEmployee()
        {
            IPayable fakeEmployee = new Employee(0, "Vardas", "Pavarde", 1000, "adresas");

            var expected = "adresas";
            var actual = fakeEmployee.GetAdress();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSalary_Empty_ReturnsSalaryOfEmployee()
        {
            IPayable fakeEmployee = new Employee(0, "Vardas", "Pavarde", 1000, "adresas");

            var expected = 1000;
            var actual = fakeEmployee.GetSalary();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncreaseSalary_IncreaseOfSalary_IcreasesSalaryProperty()
        {
            IPayable fakeEmployee = new Employee(0, "Vardas", "Pavarde", 1000, "adresas");
            fakeEmployee.IncreaseSalary(500);
            
            var expected = 1500;
            var actual = fakeEmployee.GetSalary();

            Assert.AreEqual(expected, actual);
        }
    }
}
