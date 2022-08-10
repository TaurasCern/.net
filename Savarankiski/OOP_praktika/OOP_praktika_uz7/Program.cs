namespace OOP_praktika_uz7
{
    internal class Program
    {
        /*
         * Uzduotis 7: Sukurkite 4 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos sukomponuokite (Sudekite rysius tarp ju).
        Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
        Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
        Kiekvienas studentas turi 1 pažymių knygelę.
        Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
        Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
        Inicializuokite klases su duomenimis 
        (turi buti maziausiai uzpildytos 2 mokyklos) 
        ir sukurkite 3 metodus, kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. 
        Objektai gali buti skirtingi tarp metodu):       Mokyklos pavadinima
        Kiekviena mokytoja kartu su jo mokiniu vardais
       (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
       (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki
         * */
        static void Main(string[] args)
        {
            var school = new Mokykla(new List<Mokytojas>(new List<Studentas>(new List<PazymiuKnygele>(new List<Pamoka>(), new List<int>()))));
        }
    }
}