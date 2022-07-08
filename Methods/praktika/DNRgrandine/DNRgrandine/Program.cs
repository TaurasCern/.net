using System.Text.RegularExpressions;

namespace DNRgrandine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            Menu(txt);
        }
        /// <summary>
        /// Pagrindinis meniu
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        public static void Menu(string txt)
        {
            bool isNormalized = false;
            bool isValid = false;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Menu:\n1) Normalizuoti DNR\n2) Validuoti DNR\n3) Atlikti veiksmus su DNR grandine.");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        txt = NormalizeDNR(txt);
                        isNormalized = true;
                        Console.Clear();
                        Console.WriteLine("Normalizuota.\n");
                        break;
                    case 2:
                        isValid = IsDNRValid(txt);
                        Console.Clear();
                        Console.WriteLine("Validuota.\n");
                        break;
                    case 3:
                        Console.Clear();
                        if (!isValid) { Console.WriteLine("DNR grandine nera validi.\n"); continue; }
                        SubMenu(NormalizeIfNotNormalized(txt, isNormalized)); // issiunciama normalizuota jei nebuvo normalizuota per meniu
                        flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Nera tokio pasirinkimo.\n");
                        break;
                }
            }
        }
        /// <summary>
        /// Sub-meniu is kurio atliekami visi veiksmai
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        public static void SubMenu(string txt)
        {
            while(true)
            {
                Console.WriteLine("Menu:\n1) Pakeisti \"GCT\" i \"AGG\". \n2) Patikrinti ar \"CAT\" yra grandineje.\n3) Spausdinti Trecia ir Penkta segmenta.");
                Console.WriteLine("4) Suskaiciuoti raidziu kieki grandineje.\n5) Ieskoti segmento kieki.\n6) Prideti segmenta.");
                Console.WriteLine("7) Pasalinti segmenta.\n8) Pakeisti segmenta su kitu segmentu.\n9) Gryzti i pradini meniu.");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        txt = txt.Replace("GCT", "AGG");
                        Console.Clear();
                        Console.WriteLine("Pakeista \"GCT\" i \"AGG\": {0}\n", txt);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ar yra \"CAT\" DNR grandineje: {0}\n", DoesDNRContainCAT(txt));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Trecias ir penktas segmentas: {0}\n", Get3rdAnd5thSegment(txt));
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Raidziu kiekis tekste neskaitant \"-\": {0}\n", txt.Replace("-", "").Length);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Iveskite segmenta kurio ieskoti:");
                        string segmentToFind = InputSegment();
                        int? segmentCount = FindDNRCount(txt, segmentToFind);
                        Console.WriteLine("Is kvaviaturos pasikartojantis DNR kodo \"{0}\" skaicius: {1}\n", segmentToFind, segmentCount);
                        segmentCount = null;
                        segmentToFind = null;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Iveskite segmenta kuri prideti prie grandines galo:");
                        string segment = InputSegment();
                        txt = AddSegment(txt, segment);
                        Console.WriteLine("Grandine su prie galo pridetu segmentu: {0}\n", txt);
                        segment = null;
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Iveskite segmenta kuri pasalinti is grandines:");
                        string segmentToRemove = InputSegment();
                        txt = RemoveSpecifiedSegment(txt, segmentToRemove);
                        Console.WriteLine("Grandine su pasalintais \"{0}\" segmentais: {1}\n", segmentToRemove, txt);
                        segmentToRemove = null;
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Iveskite segmenta kuri norite pakeisti:");
                        string segmentToReplace = InputSegment();
                        Console.WriteLine("Iveskite nauja segmenta.");
                        string newSegment = InputSegment();
                        txt = ReplaceSegment(txt, segmentToReplace, newSegment);
                        Console.WriteLine("Grandine su pakeistu segmentu \"{0}\" i segmenta \"{1}\": {2}\n", segmentToReplace, newSegment, txt);
                        segmentToReplace = null;
                        newSegment = null;
                        break;
                    case 9:
                        Console.Clear();
                        Menu(txt);
                        break;
                }
            }
        }
        /// <summary>
        /// Metodas kuris isema specifini segmenta is grandines
        /// Is pradziu isemamas pasirinktas segmentas, tada pasalinami "-", kad neliktu duplikaciju
        /// Tada naudojamas Regex kad kas 3 raides ideti "-"
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <param name="segment"> segmentas kuri panaikinti </param>
        /// <returns> </returns>
        public static string RemoveSpecifiedSegment(string txt, string segment)
        {
            txt = Regex.Replace(txt.Replace(segment, "").Replace("-", ""), ".{3}", "$0-");
            return txt.Remove(txt.Length - 1, 1);
        }
        /// <summary>
        /// Metodas pakeisti viena segmenta kitu
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <param name="segmentToReplace"> segmentas kuris yra pakeiciamas </param>
        /// <param name="newSegment"> naujas segmentas kuris bus idetas vietoje seno </param>
        /// <returns></returns>
        public static string ReplaceSegment(string txt, string segmentToReplace, string newSegment) => txt.Replace(segmentToReplace, newSegment);
        /// <summary>
        /// Metodas prideti segmenta prie dnr grandines galo
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <param name="segment"> segmentas kuri prideti </param>
        /// <returns> visa dnr grandine su pakeistais kodais </returns>
        public static string AddSegment(string txt, string segment) => txt + "-" + segment;
        /// <summary>
        /// Metodas surasti pasirinkto dnr kodo kieki grandineje
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <param name="dnr"> segmento kodas kurio kiekis ieskomas </param>
        /// <returns> nusakyto segmento kiekis </returns>
        public static int FindDNRCount(string txt, string dnr) => (txt.Replace("-", "").Length - txt.Replace("-", "").Replace(dnr, "").Length) / 3;
        /// <summary>
        /// Metodas gauti trecia ir penkta segmenta vinemae string kintamajame, atskirta per "-"
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <returns> trecias ir penktas segmentai </returns>
        public static string Get3rdAnd5thSegment(string txt) => txt.Substring(8, 3) + "-" + txt.Substring(16, 3);
        /// <summary>
        /// Metodas patikrinti ar dnr grandineje yra "CAT" kodas
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <returns> bool kintamasis nusakanti ar dnr grandineje yra "CAT" dnr kodas </returns>
        public static bool DoesDNRContainCAT(string txt) => txt.Contains("CAT");
        /// <summary>
        /// Metodas normalizuoti dnr grandine
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <returns> normalizuota dnr grandine </returns>
        public static string NormalizeDNR(string txt) => txt.Replace(" ", "").ToUpper();
        /// <summary>
        /// Metodas tikrinantis dnr grandines validuma
        /// </summary>
        /// <param name="txt"> dnr grandine </param>
        /// <returns> bool kintamasis nusakantis ar dnr grandine validi </returns>
        public static bool IsDNRValid(string txt) => new Regex("^(A|T|C|G|-)+$").IsMatch(txt); // regex tikrina ar txt sudarytas tik is nusakytu simboliu
        /// <summary>
        /// Metodas skirta dnr kodo ivedimui iki tol kol bus ivestas validus dnr kodas
        /// </summary>
        /// <returns> dnr koda </returns>
        public static string InputSegment() // netestuojama, nes reikia vartotojo ivedimo ir pagrinde naudojama isDNRValid() metodas 
        {
            string segment = Console.ReadLine().ToUpper();
            while (true)
            {
                if (segment.Length == 3 && IsDNRValid(segment)) { break; } // jeigu dnr kodas validus, ciklas stabdomas
                Console.WriteLine("Segmentas ivestas neteisingai. Iveskite is naujo.");
                segment = Console.ReadLine().ToUpper();
            }
            return segment;
        }
        /// <summary>
        /// Metodas skirtas normalizuoti dnr grandine, jei jinai nebuvo normlaizuota pagrindiniame meniu
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="isNormalized"></param>
        /// <returns> normalizuota dnr grandine </returns>
        public static string NormalizeIfNotNormalized(string txt, bool isNormalized) // netestuojama, nes reikia vartotojo duomenu ivedimo ir pagrinde naudojama NormalizeDNR()
        {
            if (!isNormalized)
            {
                while (!isNormalized)
                {
                    Console.WriteLine("1) Normalizuoti.\n2) Iseiti is programos.");
                    int.TryParse(Console.ReadLine(), out int choice);
                    if (choice == 1) { txt = NormalizeDNR(txt); isNormalized = true; }
                    else if (choice == 2) { System.Environment.Exit(1); }
                }
            }
            Console.Clear();
            Console.WriteLine("Normalizuota.\n");
            return txt;
        }
    }
}