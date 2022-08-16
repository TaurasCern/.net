namespace cikluPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        
        public static void DoWhile()
        {
            int zaidsk = 0;
            do
            {
                Console.WriteLine("kiek");
                zaidsk = Convert.ToInt32(Console.ReadLine());
            }
            while (zaidsk < 1 || zaidsk > 10);
        }
        
        public static void Uzduotis1()
        {
            Console.WriteLine("skaicius:");
            int sk = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int ats = 0;
            while (i <= sk)
            {
                ats += i;
                i++;
            }
            Console.WriteLine(ats);
        }
        public static void Uzduotis2()
        {
            Console.WriteLine("skaicius:");
            int sk = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= sk)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        public static void Uzduotis3()
        {
            int sk = 0;
            int sum = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("skaicius:");
                sk = Convert.ToInt32(Console.ReadLine());
                if (sk < 0)
                {
                    flag = false;
                }
                else sum += sk;
            }
            Console.WriteLine(sum);
        }
        public static void Uzduotis3_2()
        {
            int sk = 0;
            int sum = 0;
            bool flag = true;
            do
            {
                Console.WriteLine("skaicius:");
                sk = Convert.ToInt32(Console.ReadLine());
                if (sk < 0)
                {
                    flag = false;
                }
                else sum += sk;
            }
            while (flag);
            Console.WriteLine(sum);
        }
        public static void Uzduotis4()
        {
            Console.WriteLine("slaptazodis:");
            string s = Console.ReadLine();
            int failedPass = 0;
            while (true)
            {

                Console.WriteLine("iveskite slaptazodi:");
                string input = Console.ReadLine();
                if (!s.Equals(input))
                {
                    Console.WriteLine("Slaptazodis neteisingas. Bandykite dar karta");
                    failedPass++;
                }
                else { Console.WriteLine("Prisijungta"); break; }
                if (failedPass == 3) 
                {
                    Console.WriteLine("Jus uzblokuotas");
                    break;
                }
            }
        }
        public static void Uzduotis5()


        {
            Random rand = new Random();
            int coin = rand.Next(1, 3);
            int i = 0;

            int won = 0;
            int lost = 0;

            while(true)
            {
                Console.WriteLine("skaicius ar herbas:");
                int input = int.Parse(Console.ReadLine());

                if (coin == input) { Console.WriteLine("Atspeta"); won++; }
                else { Console.WriteLine("Neatspeta"); lost++; }

                if (won == 10 || lost == 10) { Console.WriteLine("Laimeta: {0}, Pralaimeta: {1}", won, lost); break; }

                coin = rand.Next(1, 3);
                i++;
            }
        }
        public static void test()
        {
            var txt = "TCG-TAC";
            Console.WriteLine(txt.Split("-")[0].Length + "-"  + txt.Split("-")[1].Length);
        }
    }
}