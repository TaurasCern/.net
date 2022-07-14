using System.Text;

namespace MasyvuPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pyramid(5);
            //Reverse(12345);
        }
        public static void Pyramid(int count)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            bool flag = true;
            for (int i = 0; i  < count; i++)
            {
                if (flag)
                {
                    sb1.Insert(0, 1);
                    flag = false;
                }
                else
                {
                    sb1.Insert(0, 0);
                    flag = true;
                }

                sb2.Append(sb1).Append(Environment.NewLine);
            }
            Console.WriteLine(sb2.ToString());
        }
        public static void Reverse(int number)
        {
            int reversed = 0;
            while(number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
           //Console.WriteLine(((0 * 10 + 12345 % 10) * 10 + 1234 % 10));
            Console.WriteLine(reversed);
        }
    }
}