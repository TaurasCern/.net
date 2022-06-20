namespace ifelsePraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Skaicius:");
            int skaicius = int.Parse(Console.ReadLine());
            if(skaicius % 2 == 0) Console.WriteLine("Lyginis");
            if(skaicius < 0) Console.WriteLine("Neigiamas");
            */
            /*
            Console.WriteLine("Kiekis:");
            int kiekis = int.Parse(Console.ReadLine());

            if(kiekis == 1)
            {
                Console.WriteLine("Solo");
            }
            else if(kiekis == 2)
            {
                Console.WriteLine("Duetas");
            }
            else if ( kiekis > 2 && kiekis < 10)
            {
                Console.WriteLine("Kamerinis");
            }
            */

            Console.WriteLine("Valandos:");
            int val = int.Parse(Console.ReadLine());
            if (val < 160) Console.WriteLine("Dar reikia isdirbti: {0}", 160 - val);
            else if (val == 160) Console.WriteLine("Pilnas etatas");
            else if (val > 160) Console.WriteLine("Virs: {0}", val - 160);
        }
    }
}