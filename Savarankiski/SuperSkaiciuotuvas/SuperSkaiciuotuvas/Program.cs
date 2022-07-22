namespace SuperSkaiciuotuvas
{
    public class Program
    {
        private static bool isFirst = true;
        private static bool isNewMove = false;
        private static bool isContinue = false;

        private static int? operation = null;
        private static bool isOperation = false;

        private static double? firstNumber = null;
        private static double? secondNumber = null;
        private static double? result = null;

        static void Main(string[] args)
        {
            MenuHandler();
        }
        public static void MenuHandler()
        {
            bool exit = false;
            string input;

            Console.WriteLine(
                "1. Naujas veiksmas{0}" +
                "2. Iseiti", Environment.NewLine);

            while (!exit)
            {
                if (!isOperation && !isNewMove && !isContinue && !isFirst)
                {
                    
                    Console.WriteLine(
                        "1. Naujas veiksmas{0}" +
                        "2. Testi{0}" +
                        "3. Iseiti", Environment.NewLine);
                }
                if (isOperation) 
                {
                    Console.Clear();
                    Console.WriteLine(
                    "1. Sudetis{0}" +
                    "2. Atimtis{0}" +
                    "3. Daugyba{0}" +
                    "4. Dalyba{0}" +
                    "5. Kelti laipsniu{0}" +
                    "6. Istraukti sakni", Environment.NewLine); 
                }
                if (isNewMove)
                {
                    input = ReadDoubleNumber().ToString();
                }
                else
                {
                    input = ReadIntNumber().ToString();                    
                }

                exit = IsExit(input);

                if(!exit)
                {
                    SuperSkaiciuotuvas(input);
                }               
            }
        }
        public static bool IsExit(string input) 
            => (isFirst && !isNewMove && !isContinue && !isOperation &&input == "2") 
            || (!isFirst && !isNewMove && !isContinue && !isOperation && input == "3");
        public static void SuperSkaiciuotuvas(string input)
        {
            if (!isNewMove && input == "1" && !isContinue && !isOperation)
            {
                Console.WriteLine("new move");
                isNewMove = true;
                isOperation = true;
                return;
            }

            if (!isFirst && input == "2" && !isNewMove && !isOperation && !isContinue)
            {
                Console.WriteLine("continue");
                isContinue = true;
                isOperation = true;
                return;
            }

            if (isOperation)
            {
                Console.WriteLine("operation");
                operation = int.Parse(input);
                isOperation = false;
                if (input != "6")
                {
                    return;
                }
            }

            if (isNewMove)
            {
                if(firstNumber == null)
                {
                    firstNumber = double.Parse(input);
                    return;
                }
                else secondNumber = double.Parse(input);

                Calculate((double)firstNumber, (double)secondNumber);
            }
            else if (isContinue)
            {
                firstNumber = double.Parse(input);

                Calculate((double)result, (double)firstNumber);
            }

        }

        private static void Calculate(double number1, double number2)
        {
            switch (operation)
            {
                case 1:
                    result = Add(number1, number2);
                    break;
                case 2:
                    result = Substract(number1, number2);
                    break;
                case 3:
                    result = Multiply(number1, number2);
                    break;
                case 4:
                    result = Divide(number1, number2);
                    break;
                case 5:
                    result = Power(number1, (int)number2);
                    break;
                case 6:
                    if (isNewMove) { result = SquareRoot(number1); }
                    else { result = SquareRoot((double)result); }
                    break;
                default:
                    break;
            }
            Reset();
            Console.WriteLine("Ats: {0}", result);
        }


        public static int ReadIntNumber()
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int sk))
                {
                    return sk;
                }
                Console.WriteLine("Ivestas ne sveikasis skaicius");
            }
        }
        public static double ReadDoubleNumber()
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double sk))
                {
                    return sk;
                }
                Console.WriteLine("neteisingas skaicius");
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
        public static double Power(double num1, int pow) => Math.Pow(num1, pow);
        public static double SquareRoot(double num1) => Math.Sqrt(num1);

        public static double Rezultatas() => result ?? 0;
        public static void Reset() 
        { 
            result = null;
            isFirst = false;
            isNewMove = false;
            isContinue = false;
            firstNumber = null;
            secondNumber = null;
            Console.Clear();
        }
    }
}