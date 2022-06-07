namespace uzduotis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char num1;
            char num2;

            Console.WriteLine("Sudetis:");
            Console.WriteLine("Iveskite pirma skaiciu:");
            num1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite antra skaiciu:");
            num2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nsuma = {0}", Convert.ToInt32(num1) - 48 + Convert.ToInt32(num2) - 48);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Atimtis:");
            Console.WriteLine("Iveskite trecia skaiciu:");
            num1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite ketvirta skaiciu:");
            num2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nlikutis = {0}", (Convert.ToInt32(num1) - 48) - (Convert.ToInt32(num2) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Daugyba:");
            Console.WriteLine("Iveskite penkta skaiciu:");
            num1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite sesta skaiciu:");
            num2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nsandauga = {0}", (Convert.ToInt32(num1) - 48) * (Convert.ToInt32(num2) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dalyba:");
            Console.WriteLine("Iveskite septinta skaiciu:");
            num1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite astunta skaiciu:");
            num2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\ndalmuo = {0}", (Convert.ToInt32(num1) - 48) / (Convert.ToInt32(num2) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}