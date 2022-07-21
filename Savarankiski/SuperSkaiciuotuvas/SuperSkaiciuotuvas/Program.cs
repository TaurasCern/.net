namespace SuperSkaiciuotuvas
{
    public class Program
    {
        private static bool isFirst = true;
        private static double? result = null;
        static void Main(string[] args)
        {
            //Menu();
        }
        public static void SuperSkaiciuotuvas(string move)
        {

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
        public static double Rezultatas()
        {
            return result ?? 0;
        }
        public static void Reset() { result = null; }
    }
}