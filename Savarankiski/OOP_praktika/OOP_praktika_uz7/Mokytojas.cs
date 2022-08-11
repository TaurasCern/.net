using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class Mokytojas
    {
        public string Name { get; private set; }
        public List<Studentas> Students { get; private set; } = new List<Studentas>();
        public Mokytojas()
        {

        }
        public Mokytojas(string name, List<Studentas> students)
        {
            Name = name;
            Students = students;
        }
    }
}
