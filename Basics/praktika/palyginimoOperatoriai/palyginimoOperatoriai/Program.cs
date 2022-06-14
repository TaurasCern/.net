namespace palyginimoOperatoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            long pirmas = long.MaxValue;
            short antras = short.MaxValue;

            Console.WriteLine((pirmas / antras) - long.MaxValue + int.MaxValue); 
            */
            /*
            double sk = 8888888888;

            //Console.WriteLine(Convert.ToInt32(sk));
            Console.WriteLine((int)sk);
            //Console.WriteLine(Convert.ToInt16(sk));
            Console.WriteLine((short)sk);
            //Console.WriteLine(Convert.ToInt64(sk));
            Console.WriteLine((long)sk);
            */
            /*
            Console.WriteLine("Iveskite rutulio diametra: ");
            double diametras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rutulio plotas: {0}", 4 * Math.PI * Math.Pow((diametras/2), 2));
            Console.WriteLine("Rutulio turis: {0}", 4/3 * Math.PI * Math.Pow((diametras / 2), 3) );
            */
            /*
            Console.WriteLine("Iveskite atstuma: ");
            double atstumas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite laikas: ");
            double laikas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("km/h: {0}", atstumas/1000 / (laikas/3600));
            Console.WriteLine("km/h: {0}", atstumas / 1000 / laikas);
            */
            /*
            Console.WriteLine("skaiciai: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ats: {0}", y + 2 * y + x + 1);
            */
            /*
            Console.WriteLine("skaiciai: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ats: {0}", Math.Pow(y,2) + x / 2);
            */
            /*
            Console.WriteLine("penkiazenklis skacius:");
            double number = double.Parse(Console.ReadLine().Replace('1','0'));
            Console.WriteLine("ats: {0}", number / 2);
            */


            Console.WriteLine("Iveskite 1 skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());

            skaicius++;
            Console.WriteLine(skaicius);
            skaicius++;
            Console.WriteLine(skaicius);
            skaicius++;
            Console.WriteLine(skaicius);
            skaicius++;
            Console.WriteLine(skaicius);
            skaicius++;
            Console.WriteLine(skaicius);
        }
    }
}