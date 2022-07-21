namespace SuperSkaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu(0);
        }
        public static int ReadIntNumber()
        {

            while (true)
            {
                Console.WriteLine("Ivesti skaiciu:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int sk))
                {
                    return sk;
                }
                Console.WriteLine("neteisingas skaicius");
            }
        }
        public static double ReadDoubleNumber()
        {

            while (true)
            {
                Console.WriteLine("Ivesti skaiciu:");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double sk))
                {
                    return sk;
                }
                Console.WriteLine("neteisingas skaicius");
            }
        }
        public static int CalculatorChoice()
        {
            int choice = ReadIntNumber();
            while (choice > 6 || choice < 1)
            {
                Console.WriteLine("Tokio pasirinkimo nera.");
                choice = ReadIntNumber();
            }
            return choice;
        }
        public static void SqrtInputValidation(ref double num1, ref double num2, int choice, bool arTesti)
        {
            if (choice != 6)
            {
                num1 = ReadDoubleNumber();
                if (!arTesti)
                {
                    num2 = ReadDoubleNumber();
                }
            }
            else if (!arTesti) { num1 = ReadIntNumber(); }
        }
        public static void Skaiciuotuvas(double ans, bool arTesti)
        {
            int choice = CalculatorChoice();
            double num1 = 0;
            double num2 = 0;

            SqrtInputValidation(ref num1, ref num2, choice, arTesti);

            while (true)
            {
                switch (choice)
                {
                    case 1:
                        if (arTesti) ans = Add(ans, num1);
                        else { ans = Add(num1, num2); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    case 2:
                        if (arTesti) ans = Substract(ans, num1);
                        else { ans = Substract(num1, num2); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    case 3:
                        if (arTesti) ans = Multiply(ans, num1);
                        else { ans = Multiply(num1, num2); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    case 4:
                        if (arTesti) ans = Divide(ans, num1);
                        else { ans = Divide(num1, num2); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    case 5:
                        if (arTesti) ans = Pow(ans, (int)num1);
                        else { ans = Pow(num1, (int)num2); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    case 6:
                        if (arTesti) ans = SquareRoot(ans);
                        else { ans = SquareRoot(num1); }
                        Console.Clear();
                        Console.WriteLine("Ats: {0}", ans);
                        Menu(ans);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogai ivestas skaicius");
                        break;
                }
            }

        }
        public static void Menu(double ans)
        {
            string table = "1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba\n5. Kelti laipsniu\n6. Traukti sakni";
            while (true)
            {
                Console.WriteLine("1) Nauja operacija\n2) Testi su rezultatu\n3) Iseiti");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(table);
                        Skaiciuotuvas(ans, false);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(table);
                        Skaiciuotuvas(ans, true);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogai ivestas skaicius");
                        break;
                }
            }
        }
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Substract(double num1, double num2) => num1 - num2;
        public static double Multiply(double num1, double num2) => num1 * num2;
        public static double Divide(double num1, double num2)
        {
            while (num2 == 0)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Is nulio dalyba negalima");
                    num2 = ReadDoubleNumber();
                }
            }

            return num1 / num2;
        }
        public static double Pow(double num1, int pow) => Math.Pow(num1, pow);
        public static double SquareRoot(double num1) => Math.Sqrt(num1);
    }
}