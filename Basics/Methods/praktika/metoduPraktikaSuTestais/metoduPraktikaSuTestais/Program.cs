using System.Diagnostics;

namespace metoduPraktikaSuTestais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas skaicius:");
            string input1 = Console.ReadLine();
            bool isNum1Int = int.TryParse(input1, out _);

            Console.WriteLine("Antras skaicius:");
            string input2 = Console.ReadLine();
            bool isNum2Int = int.TryParse(input2, out _);

            Console.WriteLine("Pasirinkite veiksma:");
            string veiksmas = Console.ReadLine();

            if(isNum1Int && isNum2Int) 
            {
                Console.WriteLine("\nAtsakymas: {0}", Skaiciuotuvas(int.Parse(input1), int.Parse(input2), veiksmas));
            }
            else Console.WriteLine("\nAtsakymas: {0}", Skaiciuotuvas(double.Parse(input1), double.Parse(input2), veiksmas));
        }
        public static double Skaiciuotuvas(int num1, int num2, string veiksmas)
        {
            Debug.WriteLine("Naudojamas int");
            double ans = 0;

            switch (veiksmas)
            {
                case "+" or "1":
                    ans = Add(num1, num2);
                    break;
                case "-" or "2":
                    ans = Subtract(num1, num2);
                    break;
                case "*" or "3":
                    ans = Multiply(num1, num2);
                    break;
                case "/" or "4":
                    ans = Divide(num1, num2);
                    break;
                case "^2" or "5":
                    ans = KelimasKvadratu(num1);
                    break;
                case "^3" or "6":
                    ans = KelimasKubu(num1);
                    break;
            }

            return ans;
        }
        public static double Skaiciuotuvas(double num1, double num2, string veiksmas)
        {
            double ans = 0;
            Debug.WriteLine("Naudojamas double");
            switch (veiksmas)
            {
                case "+" or "1":
                    ans = Add(num1, num2);
                    break;
                case "-" or "2":
                    ans = Subtract(num1, num2);
                    break;
                case "*" or "3":
                    ans = Multiply(num1, num2);
                    break;
                case "/" or "4":
                    ans = Divide(num1, num2);
                    break;
                case "^2" or "5":
                    ans = KelimasKvadratu(num1);
                    break;
                case "^3" or "6":
                    ans = KelimasKubu(num1);
                    break;
            }

            return ans;
        }
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Subtract(int num1, int num2) => num1 - num2;
        public static int Multiply(int num1, int num2) => num1 * num2;
        public static double Divide(int num1, int num2) => num1 / num2;
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Subtract(double num1, double num2) => num1 - num2;
        public static double Multiply(double num1, double num2) => num1 * num2;
        public static double Divide(double num1, double num2) => num1 / num2;
        public static double KelimasKvadratu(double num1) => Math.Pow(num1, 2);
        public static double KelimasKubu(double num1) => Math.Pow(num1, 3);
    }
    /*
     *  1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)
      2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams.
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
      3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
      4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija)
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3
     */
}