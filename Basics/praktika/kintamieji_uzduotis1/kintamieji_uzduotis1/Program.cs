namespace kintamieji_uzduotis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string schoolName = "CodeAcademy";
            string courseName = ".Net programavimas";
            int studentCount = 18;
            DateTime currentDate = new DateTime(2022, 06, 08);
            DateTime courseStartDate = new DateTime(2022, 05, 30);
            DateTime courseEndDate = new DateTime(2022, 12, 01);

            string pirmasKintamasis = "Tekstinis";
            int antrasKintamasis = 1;
            bool treciasKintamasis = true;


            Console.WriteLine(schoolName);
            Console.WriteLine(courseName);
            Console.WriteLine("Studentu kiekis: {0}", studentCount);
            Console.WriteLine("{0:yyyy/MM/dd}", currentDate);
            Console.WriteLine("Pradzia: {0:yyyy/MM/dd}", courseStartDate);
            Console.WriteLine("Pabaiga: {0:yyyy/MM/dd}", courseEndDate);
            Console.WriteLine("Nuo pradzios: {0} dienos", (currentDate - courseStartDate).Days);

            Console.WriteLine(pirmasKintamasis + " " + antrasKintamasis + " " + treciasKintamasis);
            Console.WriteLine("{0} {1} {2}", pirmasKintamasis, antrasKintamasis, treciasKintamasis);
            Console.WriteLine($"{pirmasKintamasis} {antrasKintamasis} {treciasKintamasis}");


        }
    }
}