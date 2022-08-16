namespace OOP_praktika_5uz
{
    internal class Program
    {
        /*
         * Uzduotis 5:
         * (Savarankiskai)Sukurti klases Hobis ir Profesija Klasės interfeise turi būti properčiai:
         * Id (int), 
         * TekstasLietuviskai(string) 
         * ir Tekstas(string) 
         * Sukurti tuscia konstruktorių, 
         * kuris inicializuoja duotas reikšmes.
         * Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
         * Kintamieji gali būti tik pasiekiami iš išorės,
         * bet reikšmės gali būti nustatomos tik klasės viduje.
         * Sukurkite po 3 skirtingus hobius ir profesijas(Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus.
         * 1.Konstruktoriaus pagalba 
         * 2. Tuscio objekto sukurimas ir pildymas eigoje
         * 3. Deklaravimo metu priskirti reiksmes)
         * */
        static void Main(string[] args)
        {
            var hobbies = new List<Hobis>()
            {
                new Hobis(),
                new Hobis("Sokiai", "Dancing"),
                new Hobis(2, "Zvejyba", "Fishing")
            };

            hobbies[1].SetID(1);

            var professions = new List<Profesija>()
            {
                new Profesija(),
                new Profesija(1),
                new Profesija(2, "Darbininkas", "Worker")
            };

            professions[1].SetID(1);

            foreach (Hobis hobby in hobbies)
            {
                Console.WriteLine(hobby.ToString());
            }
            foreach(Profesija profession in professions)
            {
                Console.WriteLine(profession.ToString());
            }
        }
    }
}