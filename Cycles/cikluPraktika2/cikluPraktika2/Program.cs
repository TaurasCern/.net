using System.Text;

namespace cikluPraktika2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = ReadIntNumber();
            //IntegerToBinary(number);

            //int ans = PakeltiLaipsniu(ReadIntNumber(), ReadIntNumber());
            //Console.WriteLine("Ats: {0}", ans);
            Console.WriteLine(DidejanciuSkaiciuStatusTrikampis(ReadIntNumber()));
            Console.WriteLine(DidejanciuSkaiciuPiramide(ReadIntNumber()));
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
            
            for (int i = 0; i < number; i++)
            {
                sb2.Append(number);
                sb1.Append(sb2);
                sb1.Append(Environment.NewLine);
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
    }
}