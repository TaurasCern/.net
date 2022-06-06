namespace uzduotis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda:");
            var letter = Console.ReadLine()[0];
            Console.WriteLine("Pirmoji vardo raide: {0}, raides ASCII kodas: {1}", letter, Convert.ToInt32(letter));
            Console.WriteLine();

            Console.Write("Iveskite skaiciu:");
            var sum = Convert.ToInt32(letter) + int.Parse(Console.ReadLine());
            Console.WriteLine("ASCII kodas sudetasa su ivestu skaiciumi: {0}", sum);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Meniu:");
            Console.WriteLine("(1) Pirkti");
            Console.WriteLine("(2) Parduoti");
            Console.WriteLine("(3) Likuciai");
            string choice = Console.ReadLine();
            Console.Clear();
            if(choice == "1")
            {
                Console.WriteLine("Pasirinkote pirkti.");
            }
            else if(choice == "2")
            {
                Console.WriteLine("Pasirinkote parduoti.");
            }
            else if(choice == "3")
            {
                Console.WriteLine("Pasirinkote likuciai.");
            }else
            {
                Console.WriteLine("Klaida.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}