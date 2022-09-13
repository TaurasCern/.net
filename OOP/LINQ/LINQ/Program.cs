namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>() { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };
            int[] arr = { 3, 9, 2, 8, 6, 5, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //Console.WriteLine(string.Join(",", ));
            Console.WriteLine(String.Join(",", Filter7th(arr)));
        }
        public static List<int> Filter1st(List<int> list) => list.Where(n => n >= 35 && n <= 99).ToList();
        public static List<string> Filter2nd(List<string> list) => list.Where(c => c.Length > 4).Select(c => c.ToUpper()).ToList();
        public static List<string> Filter3rd(List<string> list) => list.Where(x => x.StartsWith("d") && x.EndsWith("s")).ToList();
        public static int[] Filter4th(int[] numbers) => (from n in numbers where n % 2 == 0 select n).ToArray();
        public static int[] Filter5th(int[] numbers) => (from n in numbers where n > 0 select n).ToArray();
        public static int[] Filter6th(int[] numbers) => (from n in numbers select n * n).ToArray();
        public static Dictionary<int, int> Filter7th(int[] numbers) => (from n in numbers group n by n into g select new { Number = g.Key, Count = (from n in g select n).Count()}).ToDictionary(n => n.Number, n => n.Count);
    }
}