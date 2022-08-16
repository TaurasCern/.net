using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class Pamoka
    {
        public string Name { get; private set; }
        public List<Mokytojas> Teachers { get; private set; }
        public Pamoka()
        {

        }
        public Pamoka(string name, List<Mokytojas> teachers)
        {
            Name = name;
            Teachers = teachers;
        }
    }
}
