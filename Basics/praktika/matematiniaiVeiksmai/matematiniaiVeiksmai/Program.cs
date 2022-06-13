namespace matematiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pirmas;
            double antras;
            double trecias;

            Console.WriteLine("Iveskite 1-a skaiciu:");
            pirmas = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite 2-a skaiciu:");
            antras = double.Parse(Console.ReadLine());

            Console.WriteLine("Sudetis: {0}", pirmas + antras);
            Console.WriteLine("Atimtis: {0}", pirmas - antras);
            Console.WriteLine("Daugyba: {0}", pirmas * antras);
            Console.WriteLine("Dalyba: {0}", pirmas / antras);

            Console.WriteLine("Iveskite 1-a skaiciu:");
            pirmas = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite 2-a skaiciu:");
            antras = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite 3-ia skaiciu:");
            trecias = double.Parse(Console.ReadLine());

            Console.WriteLine("Vidurkis: {0}", (pirmas + antras + trecias) / 3);
        }
    }
}