using System.Text;

namespace cikluPraktika2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int number = ReadIntNumber();
            //IntegerToBinary(number);

            //int ans = PakeltiLaipsniu(ReadIntNumber(), ReadIntNumber());

            //Console.WriteLine("Ats: {0}", ans);
            //Console.WriteLine(SkaiciuTrikampis(ReadIntNumber())); //4
            //Console.WriteLine(SkaiciuPiramide(ReadIntNumber())); //5
            //Console.WriteLine(DidejanciuSkaiciuStatusTrikampis(ReadIntNumber())); //6
            //Console.WriteLine(DidejanciuSkaiciuPiramide(ReadIntNumber())); //7
            //Console.WriteLine(SkaiciuEile(ReadIntNumber(), ReadIntNumber())); //8
            //Console.WriteLine(DaugybosLentele(ReadIntNumber())); //9
            Menu(0); //10
            //Diamond(); //11
        }
        /// <summary>
        /// Uzduotis 1
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Uzduotis 2
        /// </summary>
        public static string IntegerToBinary(int number)
        {
            string binary = "";
            while(number >= 1)
            {
                binary += number - (number / 2 * 2);
                number = number / 2;
            }
            char[] temp = binary.ToCharArray();
            Array.Reverse(temp);
            binary = new string(temp);
            Console.WriteLine(binary);
            return binary;
        }
        /// <summary>
        /// Uzduotis 3
        /// </summary>
        /// <param name="number"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        public static int PakeltiLaipsniu(int number, int pow)
        {
            if(number >  0  && pow == 0) { return 1; }
            if(number == 0  && pow == 0) { return 0; }
            if(pow == 1)                 { return number; }

            int numberCopy = number;

            for(; 1 < pow; pow--)
            {
                number = number * numberCopy;
            }
            return number;
        }
        /// <summary>
        /// Uzduotis 4
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string SkaiciuTrikampis(int number)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            if(number > 0 && number < 10)
            {
                for (int i = 0; i < number; i++)
                {
                    sb2.Append(number);
                    sb1.Append(sb2);
                    sb1.Append(Environment.NewLine);
                }
            }

            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 5
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string SkaiciuPiramide(int number)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < number * 2; i++)
            {
                if (i < number)
                {
                    sb2.Append(number);
                    sb1.Append(sb2);
                    sb1.Append(Environment.NewLine);
                }
                else if (i > number)
                {
                    sb2.Remove(sb2.Length - 1, 1);
                    sb1.Append(sb2);
                    sb1.Append(Environment.NewLine);
                }
                
            }
            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 6
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string DidejanciuSkaiciuStatusTrikampis(int number)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            if (number > 0 && number < 10)
            {
                for (int i = 1; i < number + 1; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        sb2.Append(i);

                    }
                    sb1.Append(sb2);
                    sb1.Append(Environment.NewLine);
                    sb2.Clear();
                }
            }


            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 7
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string DidejanciuSkaiciuPiramide(int number)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            int pyramidSize = number * 2;

            for (int i = 1; i < pyramidSize; i++)
            {
                if(i <= number)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sb2.Append(i);
                    }
                }
                else if (i > number)
                {
                    for (int j = pyramidSize; j > i; j--)
                    {
                        sb2.Append(pyramidSize - i);
                    }
                }

                 sb1.Append(sb2);
                 sb1.Append(Environment.NewLine);
                 sb2.Clear();
            }

            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 1 (Nauja)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string SkaiciuEile(int number, int count)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                sb2.Append(number);
                sb1.Append("-> ").Append(sb2).Append(" ");

            }
            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 2 (Nauja)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string DaugybosLentele(int number)
        {
            int ans = 0;
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb1.Append(number).Append(" ")
                    .Append("X").Append(" ")
                    .Append(i+1).Append(" ")
                    .Append("=").Append(" ")
                    .Append(number * (i + 1))
                    .Append(Environment.NewLine);
            }
            return sb1.ToString();
        }
        /// <summary>
        /// Uzduotis 3 (Skaiciuotuvas)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="choice"></param>
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
            while(num2 == 0)
            {
                if(num2  == 0)
                {
                    Console.WriteLine("Is nulio dalyba negalima");
                    num2 = ReadDoubleNumber();      
                }
            }

            return num1 / num2;
        }
        public static double Pow(double num1, int pow) => Math.Pow(num1, pow);
        public static double SquareRoot(double num1) => Math.Sqrt(num1);
        /// <summary>
        /// Uzduotis 4 (Nauja)
        /// </summary>
        public static void Diamond()
        {
            StringBuilder sb = new StringBuilder();
            int size = ReadIntNumber();
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size - i; j++)
                {
                    sb.Append(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    sb.Append("*");
                }
                for(int j = i - 1; j > 0; j--)
                {
                    sb.Append("*");
                }
                sb.Append(Environment.NewLine);
            }
            for (int i = size; i >= 1; i--)
            {
                for(int j = 0; j < size - i; j++)
                {
                    sb.Append(" ");
                }
                for(int j = 0; j < i; j++)
                {
                    sb.Append("*");
                }
                for (int j = i - 1; j > 0; j--)
                {
                    sb.Append("*");
                }
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}