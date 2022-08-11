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
            var students1 = new List<Studentas>();
            var students2 = new List<Studentas>();
            var teachers = new List<Mokytojas>();
            var lessons = new List<Pamoka>();
            var school = new Mokykla("Mokykla 1", teachers);

            teachers.Add(new Mokytojas("Mokytojas1", students1));
            students1.Add(new Studentas("Mokinys1", new PazymiuKnygele()));
            students1.Add(new Studentas("Mokinys2", new PazymiuKnygele()));

            teachers.Add(new Mokytojas("Mokytojas2", students2));
            students2.Add(new Studentas("Mokinys3", new PazymiuKnygele()));
            students2.Add(new Studentas("Mokinys4", new PazymiuKnygele()));

            lessons.Add(new Pamoka("Biologija", new List<Mokytojas> { teachers[0] }));
            lessons.Add(new Pamoka("Anglu kalba", new List<Mokytojas> { teachers[1] }));


            var grades1 = new PazymiuKnygele(lessons, new List<List<int>>() { new List<int>() { 4, 6, 7 }, new List<int> { 3, 4, 5 } }); 
            var grades2 = new PazymiuKnygele(lessons, new List<List<int>>() { new List<int>() { 2, 3, 2 }, new List<int>() { 4, 5, 2 } });
            var grades3 = new PazymiuKnygele(lessons, new List<List<int>>() { new List<int>() { 1, 8, 7 }, new List<int>() { 6, 5, 2 } });
            var grades4 = new PazymiuKnygele(lessons, new List<List<int>>() { new List<int>() { 10, 7, 8 }, new List<int>() { 9, 2, 3 } });

            students1[0].SetGrades(grades1);
            students1[1].SetGrades(grades2);
            students2[0].SetGrades(grades3);
            students2[1].SetGrades(grades4);

            Console.WriteLine(school.GetClasses());
            Console.WriteLine(school.GetGrades());
            Console.WriteLine(school.GetAverages());
            Console.WriteLine(school.Teachers[0].Students[0].GradesBook.Lesson[0].Teachers[0].Students[1].GradesBook.Lesson[1].Teachers[0].Name);
        }
    }
}