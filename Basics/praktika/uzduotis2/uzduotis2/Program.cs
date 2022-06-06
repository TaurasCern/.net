namespace uzduotis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("A");
            Console.WriteLine("S");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("L\tA\tB\tA\tS");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\"LABAS\"");
            Console.WriteLine("\u0022LABAS\u0022");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iveskite savo varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Antra vardo raide: {0}", name[1]);
            Console.WriteLine("|\t{0} |\t{1} |{2}{3}{4}{5}{6}", name, name.Length, Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine, name);
            
        }
    }
}