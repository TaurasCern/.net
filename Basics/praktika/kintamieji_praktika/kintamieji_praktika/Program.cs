namespace kintamieji_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kintamieji");

            byte mazasSkaicius = 255; // max 255
            short trumpasSkaicius = 32467; // max 32767
            int skaicius = int.MaxValue; // max (+-)2147483647
            long ilgasSkaicius = long.MaxValue; // didelis


            int? skaiciusKurisGaliButiNUll = null;    // rekomenduojamas budas
            Nullable<int> skaiciusKurisGaliButiNUll2 = null;

            uint tikTeigiamasSkaicius = 2; // uint gali but tik teigiamas, bet turi dvigubai daugiau tegiamu reiksmiu

            // floating point types

            float maziausiasTrupmeninis = 8.5f;
            var trupmeninisVar = 8.5; // priskiria double
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;

            // patogesni sxkaiciu uzrasymai
            double avagadrosNumber = 6.022e23; // taip uzrasoma 6.022x10^23
            double digitSeparator = 522_1_000.000_001; // digit separator

            int trylika = 0b00001101; //13 binary (0b) budu
            int suSimtaiPenkiasdesimt = 0xFA; // 250 sesioliktainiu(0x)

            int kint1, kint2, kint3;
            kint1 = kint2 = kint3 = 100; // keliem vienu kartu priskirt
        }
    }
}