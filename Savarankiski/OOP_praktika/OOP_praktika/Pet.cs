using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika
{
    internal class Pet
    {
        public string Name { get; set; }
        public DateTime BirhtDate { get; set; }
        public string Disposition { get; set; }

        public Pet(string name, DateTime birhtDate, string disposition)
        {
            this.Name = name;
            this.BirhtDate = birhtDate;
            this.Disposition = disposition;
        }
        public Pet()
        {

        }

        public override string ToString() => this.Name + ": " + this.Disposition;
    }
}
