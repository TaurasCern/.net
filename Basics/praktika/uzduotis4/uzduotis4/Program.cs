namespace uzduotis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;

            Console.WriteLine("Sudetis:");
            Console.WriteLine("Iveskite pirma skaiciu:");
            num1 = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu:");
            num2 = Console.ReadLine();
            Console.WriteLine("suma = {0}", Convert.ToInt32(num1[0]) - 48 + Convert.ToInt32(num2[0]) - 48);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iveskite trecia skaiciu:");
            num1 = Console.ReadLine();
            Console.WriteLine("Iveskite ketvirta skaiciu:");
            num2 = Console.ReadLine();
            Console.WriteLine("likutis = {0}", (Convert.ToInt32(num1[0]) - 48) - (Convert.ToInt32(num2[0]) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iveskite penkta skaiciu:");
            num1 = Console.ReadLine();
            Console.WriteLine("Iveskite sesta skaiciu:");
            num2 = Console.ReadLine();
            Console.WriteLine("sandauga = {0}", (Convert.ToInt32(num1[0]) - 48) * (Convert.ToInt32(num2[0]) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iveskite septinta skaiciu:");
            num1 = Console.ReadLine();
            Console.WriteLine("Iveskite astunta skaiciu:");
            num2 = Console.ReadLine();
            Console.WriteLine("dalmuo = {0}", (Convert.ToInt32(num1[0]) - 48) / (Convert.ToInt32(num2[0]) - 48));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}