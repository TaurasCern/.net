using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_5uz
{
    internal class Profesija
    {
        public int ID { get; private set; }
        public string ProfessionInLithuanian { get; private set; }
        public string Profession { get; private set; }

        public Profesija()
        {
            ID = 0;
            ProfessionInLithuanian = "N/A";
            Profession = "N/A";
        }
        public Profesija(int id) : this()
        {
            ID = id;
        }
        public Profesija(int id, string textInLithuanian, string text)
        {
            ID = id;
            ProfessionInLithuanian = textInLithuanian;
            Profession = text;
        }
        public void SetID(int id) { ID = id; }
        public override string ToString() => $"{ID}: {Profession}";
    }
}
