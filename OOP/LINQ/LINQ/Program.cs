namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };

            Console.WriteLine(string.Join(",", Filter3rd(list)));
        }
        public static List<int> Filter1st(List<int> list) => list.Where(n => n >= 35 && n <= 99).ToList();
        public static List<string> Filter2nd(List<string> list) => list.Where(c => c.Length > 4).Select(c => c.ToUpper()).ToList();
        public static List<string> Filter3rd(List<string> list) => list.Where(x => x.StartsWith("d") && x.EndsWith("s")).ToList();
    }
}