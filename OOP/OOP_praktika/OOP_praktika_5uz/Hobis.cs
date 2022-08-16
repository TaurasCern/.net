using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_5uz
{
    /*
 * Uzduotis 5:
 * (Savarankiskai)Sukurti klases Hobis ir Profesija Klasės interfeise turi būti properčiai:
 * Id (int), 
 * TekstasLietuviskai(string) 
 * ir Tekstas(string) 
 * Sukurti tuscia konstruktorių, kuris inicializuoja duotas reikšmes.
 * Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
 * Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
 * Sukurkite po 3 skirtingus hobius ir profesijas(Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus.
 * 1. Konstruktoriaus pagalba 
 * 2. Tuscio objekto sukurimas ir pildymas eigoje
 * 3. Deklaravimo metu priskirti reiksmes)
 * */
    internal class Hobis
    {
        public int ID { get; private set; }
        public string HobbyInLithuanian { get; private set; }
        public string Hobby { get; private set; }

        public Hobis()
        {
            ID = 0;
            HobbyInLithuanian = "N/A";
            Hobby = "N/A";
        }
        public Hobis(string hobbyInLithuanian, string hobby)
        {
            HobbyInLithuanian = hobbyInLithuanian;
            Hobby = hobby;
        }
        public Hobis(int id, string textInLithuanian, string text)
        {
            ID = id;
            HobbyInLithuanian = textInLithuanian;
            Hobby = text;
        }
        public void SetID(int id) { ID = id; }
        public override string ToString() => $"{ID}: {Hobby}";
    }
}
