using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class Studentas
    {
        public string Name { get; private set; }
        public PazymiuKnygele GradesBook { get; private set; }
        public Studentas()
        {

        }
        public Studentas(string name, PazymiuKnygele grades)
        {
            Name = name;
            GradesBook = grades;
        }
        public void SetGrades(PazymiuKnygele grades)
        {
            GradesBook = grades;
        }

    }
}
