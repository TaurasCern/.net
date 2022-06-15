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

            Console.WriteLine("Abi transporto priemones isskyre {0} gramu CO2 per nuvaziuota kelia.\n", distance * 95 * 2);
            
            Console.WriteLine(" |{0,4}|{1,4}|{2,4}|{3,4}|{4,4}|{5,4}|{6,4}|{7,4}|{8,4}|{9,4}|{10,4}|{11,4}|{12,4}|{13,4}|{14,4}|{15,4}|{16,4}|{17,4}|{18,4}|{19,4}|", distance / 20 * 1, distance / 20 * 2, distance / 20 * 3, distance / 20 * 4, distance / 20 * 5, distance / 20 * 6, distance / 20 * 7, distance / 20 * 8, distance / 20 * 9, distance / 20 * 10, distance / 20 * 11, distance / 20 * 12, distance / 20 * 13, distance / 20 * 14, distance / 20 * 15, distance / 20 * 16, distance / 20 * 17, distance / 20 * 18, distance/20*19, distance);
            Console.WriteLine(" |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |    |");
            // isemamas vienas simbolis proporcingas atstumui ir lentelei ir idedamas 'V' raide nurodyt susikirtimo taska
            Console.WriteLine("_A____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____B_".Remove((int)Math.Round(Convert.ToDecimal(meetingPoint * (100/distance)) + 1, 1)).Insert((int)Math.Round(Convert.ToDecimal(meetingPoint * (100 / distance))) + 1, "V"));
            Console.WriteLine(" |" + new string('-', (int)Math.Round(Convert.ToDecimal(meetingPoint * (100 / distance))) - 1) + "|\n");

            Console.WriteLine("Susitikimo vieta: {0}km", meetingPoint);
            Console.WriteLine("Laikas po kurio susitiks transporto priemones: {0}s\n", timeToMeet * 3600);

            Console.WriteLine("|{0}{1,5}{2}|", new string('>',47), vehicleEndPointTime1 * 60 + "min", new string('>', 47));
            Console.WriteLine("|{0}{1,5}{2}|", new string('<', 47), vehicleEndPointTime2 * 60 + "min", new string('<', 47));
        }
    }
}