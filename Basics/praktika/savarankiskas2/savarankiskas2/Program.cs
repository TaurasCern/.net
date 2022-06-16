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

            Console.WriteLine("Farenheit: {0:0}", far);
            Console.WriteLine("Kelvin: {0}", kelvin);

            // konvertuojamos temperaturos ir apvalinamos, kad sutaptu po atliktu matematiniu veiksmu
            Console.WriteLine("Farenheit atgal i Celsiju: {0} | ar sutampa: {1}", Math.Round((far - 32) * 0.5556), celsius == Math.Round((far - 32) * 0.5556));
            Console.WriteLine("Kelvin atgal i Celsiju: {0} | ar sutampa: {1}", kelvin - 273.15, celsius == kelvin - 273.15);
            Console.WriteLine("Perskaiciuota Farenheit i Kelivin: {0} | ar sutampa: {1}", Math.Round(((far - 32) * 0.5556) + 273.15, 2), Math.Round(((far - 32) * 0.5556) + 273.15, 2) == kelvin);

            // prie temperaturu pridedami skaiciai nuo -40 iki 40 kad termometro vizualizacija butu proporcinga temperaturai
            Console.WriteLine("|------------------|");
            Console.WriteLine("|   ^F   _    ^C   |");
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 40) * 9 / 5 + 32,  celsius + 40);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 35) * 9 / 5 + 32,  celsius + 35);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 30) * 9 / 5 + 32,  celsius + 30);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 25) * 9 / 5 + 32,  celsius + 25);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 20) * 9 / 5 + 32,  celsius + 20);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 15) * 9 / 5 + 32,  celsius + 15);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 10) * 9 / 5 + 32,  celsius + 10);
            Console.WriteLine("|{0,4} - | | - {1,3}  |", (celsius + 5) * 9 / 5 + 32,   celsius + 5);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + 0) * 9 / 5 + 32,   celsius + 0);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -5) * 9 / 5 + 32,  celsius + -5);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -10) * 9 / 5 + 32, celsius + -10);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -15) * 9 / 5 + 32, celsius + -15);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -20) * 9 / 5 + 32, celsius + -20);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -25) * 9 / 5 + 32, celsius + -25);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -30) * 9 / 5 + 32, celsius + -30);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -35) * 9 / 5 + 32, celsius + -35);
            Console.WriteLine("|{0,4} - |#| - {1,3}  |", (celsius + -40) * 9 / 5 + 32, celsius + -40);
            Console.WriteLine("|      '***`       |");
            Console.WriteLine("|     (*****)      |");
            Console.WriteLine("|      `---'       |");
            Console.WriteLine("|__________________|");

        }
    }
}