namespace debuginimoPraktika
{
    public class Program
    {
        static void Main(string[] args)
        {
            DecimalHour(Console.ReadLine());
        }

        public static string DecimalHour(string input)
        {
            var a = input.Split(".");

            if (a.Length < 2) { return "Invalid time"; }
            if (!int.TryParse(a[0], out int hour) || hour < 0) { return "Invalid time"; }
            if (!int.TryParse(a[1], out int minutes) || minutes < 0 || minutes > 60) { return "Invalid time"; }
            if (a.Length > 2 && (!int.TryParse(a[2], out int sec) || sec < 0 || sec > 60)) { return "Invalid time"; }

            var dec = Convert.ToDecimal(a[0]) + Convert.ToDecimal(a[1]) / 60 + (a.Length > 2 ? Convert.ToDecimal(a[2]) / 3600 : 0);

            return String.Format($"Decimal hour: {dec:0.0000}");
        }
    }
}