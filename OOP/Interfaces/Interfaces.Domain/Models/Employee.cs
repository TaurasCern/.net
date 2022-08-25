using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Employee : Person, IPayable
    {
        public Employee() : base() { MailingAdress = ""; }
        public Employee(int id, string name, string lastName, int salary, string mailingAdress) : base(id, name, lastName)
        {
            Salary = salary;
            MailingAdress = mailingAdress;
        }
        public int Salary { get; set; }
        public string MailingAdress { get; set; }

        public string GetAdress() => MailingAdress;

        public int GetSalary() => Salary;

        public void IncreaseSalary(int amount) { Salary += amount; }
    }
}
