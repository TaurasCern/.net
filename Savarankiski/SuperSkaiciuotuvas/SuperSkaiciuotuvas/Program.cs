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
        /// <summary>
        /// Method to call SuperSkaiciuotuvas with input until exit
        /// </summary>
        public static void MenuHandler()
        {
            bool exit = false;
            string input;

            Console.WriteLine(
                "1. Naujas veiksmas{0}" +
                "2. Iseiti", Environment.NewLine);

            while (!exit)
            {
                PrintMenu();

                if (isNewMove) // if inputing numbers for calculation
                {
                    input = ReadDoubleNumber().ToString();
                }
                else // else menu choice in int
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
        /// <summary>
        /// Method to check if exit option was chosen
        /// </summary>
        public static bool IsExit(string input) 
            => (isFirst && !isNewMove && !isContinue && !isOperation &&input == "2") 
            || (!isFirst && !isNewMove && !isContinue && !isOperation && input == "3");
        /// <summary>
        /// Method to call Calculate() according to applications status
        /// </summary>
        public static void SuperSkaiciuotuvas(string input)
        {
            if(ProcessInput(input)) { return; }

            if (isNewMove)
            {
                if (firstNumber == null && operation == 6) // square root validation
                {
                    firstNumber = double.Parse(input);
                    Calculate((double)firstNumber, 0);
                }
                else if (firstNumber == null) // first number input
                {
                    firstNumber = double.Parse(input);
                    return;
                }
                else
                {
                    secondNumber = double.Parse(input); // second number input
                    Calculate((double)firstNumber, (double)secondNumber);
                }
            }
            else if (isContinue)
            {
                firstNumber = double.Parse(input);

                Calculate((double)result, (double)firstNumber);
            }

        }
        /// <summary>
        /// Method to process check if input was menu option
        /// </summary>
        public static bool ProcessInput(string input)
        {
            if (!isNewMove && input == "1" && !isContinue && !isOperation) // if new move was selected
            {
                isNewMove = true;
                isOperation = true;
                return true;
            }

            if (!isFirst && input == "2" && !isNewMove && !isOperation && !isContinue) // if continue was selected
            {
                isContinue = true;
                isOperation = true;
                return true;
            }

            if(isOperation && !(0 < int.Parse(input) && int.Parse(input) < 7)) // operation choice validation
            {
                return true;
            }

            if (isOperation) // if operation was selected
            {
                operation = int.Parse(input);
                isOperation = false;

                if (isNewMove && input == "6") // validator if user selects 6 on a new move
                {
                    return true;
                }

                if (input != "6") // if operation was selected return to MenuHandler()
                {
                    return true;
                }
            }



            return false; // continue
        }
        /// <summary>
        /// Calculator state machine
        /// </summary>
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
                    if (isNewMove) // move validation
                        result = SquareRoot(number1); 
                    else 
                        result = SquareRoot((double)result);
                    break;
                default:
                    break;
            }

            ResetVariables();
        }

        /// <summary>
        /// Method to read integer number from console until entered correctly
        /// </summary>
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
        /// <summary>
        /// Method to read double number from console until entered correctly
        /// </summary>
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


        /// <summary>
        /// Method to print menu according to current state of the application
        /// </summary>
        public static void PrintMenu()
        {
            if (!isOperation && !isNewMove && !isContinue && !isFirst) // if not first menu
            {
                Console.Clear();
                Console.WriteLine("Ats: {0}", result);
                Console.WriteLine(
                    "1. Naujas veiksmas{0}" +
                    "2. Testi{0}" +
                    "3. Iseiti", Environment.NewLine);
            }
            if (isOperation) // operation menu
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
            if (!isOperation && (isNewMove || isContinue))
            {
                Console.WriteLine("Iveskite skaiciu");
            }
        }


        /// <summary>
        /// Calculation methods
        /// </summary>
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

        /// <summary>
        /// Method to test global result variable
        /// </summary>
        public static double Rezultatas() => result ?? 0;
        /// <summary>
        /// Method to reset the answer
        /// </summary>
        public static void Reset() 
        {
            result = null;
        }
        /// <summary>
        /// Method to reset global variables after calculation is finished
        /// </summary>
        public static void ResetVariables()
        {
            isFirst = false;
            isNewMove = false;
            isContinue = false;
            firstNumber = null;
            secondNumber = null;
        }
    }
}