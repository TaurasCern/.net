namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aa " + "aa " + "aa"); //konkatinacija
            Console.WriteLine("{0} {1} {2}", "aa", "aa", "aa"); //kompozicija - greiciausias
            Console.WriteLine($"{"aa"} {"aa"} {"aa"}"); //interpoliacija - patogiausias

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iveskite savo varda, o as atspesiu pirma raide:");
            Console.WriteLine("spejimas: \"{0}\"", Console.ReadLine()[0]);

            Console.WriteLine("Iveskite raide");
            var key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("ivestas simbolis: {0}", key.KeyChar);
            Console.WriteLine("ivestas simbolis: {0}", key.Key);
            Console.WriteLine("ivestas simbolis: {0}", (int)key.KeyChar);
            Console.WriteLine("ivestas simbolis: {0}", (int)key.Key);

            Console.ReadKey();
        }
    }
}