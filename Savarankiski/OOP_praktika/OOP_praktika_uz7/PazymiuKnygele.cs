using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class PazymiuKnygele
    {
        public List<Pamoka> Lesson { get; private set; } = new List<Pamoka>();
        public List<List<int>> Grades { get; private set; }
    }
}
