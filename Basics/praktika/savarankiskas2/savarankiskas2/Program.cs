namespace savarankiskas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura:");
            int celsius = int.Parse(Console.ReadLine());

            double far = celsius * 1.8 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("Farenheit: {0}", far);
            Console.WriteLine("Kelvin: {0}", kelvin);

            // konvertuojamos temperaturos ir apvalinamos, kad sutaptu po atliktu matematiniu veiksmu
            Console.WriteLine("Farenheit atgal i Celsiju: {0} | ar sutampa: {1}", Math.Round((far - 32) * 0.5556), celsius == Math.Round((far - 32) * 0.5556));
            Console.WriteLine("Kelvin atgal i Celsiju: {0} | ar sutampa: {1}", kelvin - 273.15, celsius == kelvin - 273.15);
            Console.WriteLine("Perskaiciuota Farenheit i Kelivin: {0} | ar sutampa: {1}", Math.Round(((far - 32) * 0.5556) + 273.15, 2), Math.Round(((far - 32) * 0.5556) + 273.15, 2) == kelvin);

            // keistas termometro formos islaikymas, nes pamirsau kad galiu naudoti {0,5}
            Console.WriteLine("|------------------|");
            Console.WriteLine("|   ^F   _    ^C   |");
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 40) * 9 / 5 + 32).ToString().Length), (celsius + 40) * 9 / 5 + 32, celsius + 40, new string(' ', 5 - (celsius + 40).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 35) * 9 / 5 + 32).ToString().Length), (celsius + 35) * 9 / 5 + 32, celsius + 35, new string(' ', 5 - (celsius + 35).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 30) * 9 / 5 + 32).ToString().Length), (celsius + 30) * 9 / 5 + 32, celsius + 30, new string(' ', 5 - (celsius + 30).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 25) * 9 / 5 + 32).ToString().Length), (celsius + 25) * 9 / 5 + 32, celsius + 25, new string(' ', 5 - (celsius + 25).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 20) * 9 / 5 + 32).ToString().Length), (celsius + 20) * 9 / 5 + 32, celsius + 20, new string(' ', 5 - (celsius + 20).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 15) * 9 / 5 + 32).ToString().Length), (celsius + 15) * 9 / 5 + 32, celsius + 15, new string(' ', 5 - (celsius + 15).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 10) * 9 / 5 + 32).ToString().Length), (celsius + 10) * 9 / 5 + 32, celsius + 10, new string(' ', 5 - (celsius + 10).ToString().Length));
            Console.WriteLine("|{0}{1}- | | - {2}{3}|", new string(' ', 5 - ((celsius + 5) * 9 / 5 + 32).ToString().Length), (celsius + 5) * 9 / 5 + 32, celsius + 5, new string(' ', 5 - (celsius + 5).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + 0) * 9 / 5 + 32).ToString().Length), (celsius + 0) * 9 / 5 + 32, celsius + 0, new string(' ', 5 - (celsius + 0).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -5) * 9 / 5 + 32).ToString().Length), (celsius + -5) * 9 / 5 + 32, celsius + -5, new string(' ', 5 - (celsius + -5).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -10) * 9 / 5 + 32).ToString().Length), (celsius + -10) * 9 / 5 + 32, celsius + -10, new string(' ', 5 - (celsius + -10).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -15) * 9 / 5 + 32).ToString().Length), (celsius + -15) * 9 / 5 + 32, celsius + -15, new string(' ', 5 - (celsius + -15).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -20) * 9 / 5 + 32).ToString().Length), (celsius + -20) * 9 / 5 + 32, celsius + -20, new string(' ', 5 - (celsius + -20).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -25) * 9 / 5 + 32).ToString().Length), (celsius + -25) * 9 / 5 + 32, celsius + -25, new string(' ', 5 - (celsius + -25).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -30) * 9 / 5 + 32).ToString().Length), (celsius + -30) * 9 / 5 + 32, celsius + -30, new string(' ', 5 - (celsius + -30).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -35) * 9 / 5 + 32).ToString().Length), (celsius + -35) * 9 / 5 + 32, celsius + -35, new string(' ', 5 - (celsius + -35).ToString().Length));
            Console.WriteLine("|{0}{1}- |#| - {2}{3}|", new string(' ', 5 - ((celsius + -40) * 9 / 5 + 32).ToString().Length), (celsius + -40) * 9 / 5 + 32, celsius + -40, new string(' ', 5 - (celsius + -40).ToString().Length));
            Console.WriteLine("|      '***`       |");
            Console.WriteLine("|     (*****)      |");
            Console.WriteLine("|      `---'       |");
            Console.WriteLine("|__________________|");

        }
    }
}