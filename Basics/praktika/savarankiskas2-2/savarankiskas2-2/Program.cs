namespace savarankiskas2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atstuma(km) tarp tasku a ir b:");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite pirmos transporto priemones greiti:");
            double vehicleSpeed1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antros transporto priemones greiti:");
            double vehicleSpeed2 = double.Parse(Console.ReadLine());

            double timeToMeet = distance / (vehicleSpeed1 + vehicleSpeed2); // laikas kada transporto priemones susitiks (valandomis)
            double meetingPoint = vehicleSpeed1 * timeToMeet; // kokiame taske transporto priemones susitiks nuo A tasko (kilometrais)
            double vehicleEndPointTime1 = distance / vehicleSpeed1;
            double vehicleEndPointTime2 = distance / vehicleSpeed2;

            Console.WriteLine("Susitikimo taskas nuo A tasko: {0}", meetingPoint);
            Console.WriteLine("Laikas po kurio susitiks transporto priemones: {0}s", timeToMeet * 3600);
            Console.WriteLine("Laikas po kurio transporto priemones pasieks kelio gala: pirma pasieks per {0}min, antra pasieks per {1}min", vehicleEndPointTime1 * 60, vehicleEndPointTime2 * 60);
            Console.WriteLine("Abi transporto priemones isskyre {0} gramu CO2 per nuvaziuota kelia.", distance * 95 * 2);
        }
    }
}