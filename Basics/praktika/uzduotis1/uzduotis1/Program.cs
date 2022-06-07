namespace uzduotis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite savo varda:");
            //char letter = Console.ReadLine()[0];
            //Console.WriteLine("Pirmoji vardo raide: {0}, raides ASCII kodas: {1}", letter, Convert.ToInt32(letter));
            //Console.WriteLine();
            //
            //Console.Write("Iveskite skaiciu:");
            //
            //Console.WriteLine("ASCII kodas sudetasa su ivestu skaiciumi: {0:C}", Convert.ToInt32(letter) + int.Parse(Console.ReadLine()));
            //
            //Console.WriteLine();
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine("Meniu:\n(1) Pirkti\n(2) Parduoti\n(3) Likuciai\n");
            Console.WriteLine("\nPasirinktas \"{0}\"", Convert.ToInt32(Console.ReadKey().KeyChar) - 48);
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}