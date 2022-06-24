namespace savarankiskas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sukuriami kintamieji toliasnniam if naudojimui
            int tempYear = new int();
            bool isDateEntered = false;
            bool isAgeEntered = false;
            bool codeValid = false;
            string gender = "N/A";
            string ageByCode = "N/A";
            DateTime birthDateByCode = new DateTime();

            Console.WriteLine("Iveskite varda ir pavarede:");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite asmesns koda(11 skaitmenu):");
            string code = Console.ReadLine();

            if (code.Length == 11) { codeValid = true; }

            Console.WriteLine("Iveskite gimimo data(YYYY-MM-DD):");
            string birthDate = Console.ReadLine();
            if (!String.IsNullOrEmpty(birthDate)) { isDateEntered = true; }     // tikrinama ar ivesta data ar amzius      

            Console.WriteLine("Iveskite amziu:");
            string age =  Console.ReadLine();
            if (!String.IsNullOrEmpty(age)) { isAgeEntered = true; }

            Console.Clear();

            string ageValidity = "";
            if (codeValid)
            {
                // pagal pirma asmens kodo skaitmeni nustatoma asmens lytis
                if (int.Parse(code[0].ToString()) % 2 == 1) { gender = "Vyras"; }
                else { gender = "Moteris"; }

                // pagal pirma kodo skaitmeni nustasomas simtmetis ir suskaiciuojami gimimo metai
                if (code[0] == '1' || code[0] == '2') { tempYear = 1800 + int.Parse(code[1].ToString()) * 10 + int.Parse(code[2].ToString()); }
                else if (code[0] == '3' || code[0] == '4') { tempYear = 1900 + int.Parse(code[1].ToString()) * 10 + int.Parse(code[2].ToString()); }
                else if (code[0] == '5' || code[0] == '6') { tempYear = 2000 + int.Parse(code[1].ToString()) * 10 + int.Parse(code[2].ToString()); }

                // paemami 4,5/6,7 skaitmenys is asmens kodo ir nustatoma gimimo data
                int tempMonth = int.Parse(code.Substring(3, 2));
                int tempDay = int.Parse(code.Substring(5, 2));
                birthDateByCode = new DateTime(tempYear, tempMonth, tempDay);

                // nustatomas amzius naudojant asmens koda
                ageByCode = (DateTime.Today.Year - birthDateByCode.Year).ToString() ;

                // amziaus melavimo validacija
                if (isAgeEntered && !isDateEntered)
                {
                    if (int.Parse(age) == int.Parse(ageByCode)) { ageValidity = "Amzius patikimas"; }
                    else { ageValidity = "Amzius pameluotas"; }
                }
                else if (isDateEntered && !isAgeEntered)
                {
                    if (DateTime.Parse(birthDate) == birthDateByCode) { ageValidity = "Amzius patikimas"; }
                    else { ageValidity = "Amzius pameluotas"; }
                }
                else if (isAgeEntered && isDateEntered)
                {
                    if (int.Parse(age) == int.Parse(ageByCode) && DateTime.Parse(birthDate) == birthDateByCode) { ageValidity = "Amzius patikimas"; }
                    else if (int.Parse(age) == int.Parse(ageByCode) || DateTime.Parse(birthDate) == birthDateByCode) { ageValidity = "Amzius nepatikimas"; }
                    else { ageValidity = "Amzius pameluotas"; }
                }
                else if (!isAgeEntered && !isDateEntered) { ageValidity = "Patikimumui truksta duomenu"; }
            }
            else { ageValidity = "Patikimumui truksta duomenu"; code = "Kodas neteisingas"; }

            // sudaroma lentele
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1}{2}", new string('▓', 25), "ATASKAITA APIE ASMENI", new string('▓', 25));
            Console.WriteLine("{0}{1}{2}", new string('▓', 31), DateTime.Now.ToShortDateString(), new string('▓', 31));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Vardas, pavarde", name, new string('▓',5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Lytis", gender, new string('▓', 5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Asmens kodas", code, new string('▓', 5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Amzius", ageByCode, new string('▓', 5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Gimimo data", birthDateByCode.ToShortDateString(), new string('▓', 5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine("{0}{1,19}▓{2,40}{3}", new string('▓', 6), "Amziaus patikimumas", ageValidity, new string('▓', 5));
            Console.WriteLine(new string('▓', 71));
            Console.WriteLine(new string('▓', 71));
            Console.ReadKey();
        }
    }
}