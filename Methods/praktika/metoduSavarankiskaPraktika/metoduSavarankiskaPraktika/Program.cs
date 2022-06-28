namespace metoduSavarankiskaPraktika
{
    public class Program
    {

        /*
        static void Main(string[] args)//6
        {
            Console.WriteLine("Tekstas");
            string text = Console.ReadLine();
            Console.WriteLine("Zodziu kiekis: {0}", WordCount(text));
            
        }

        public static int WordCount(string text)
        {
            return text.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }
        */
        /*
        static void Main(string[] args)//7
        {
            Console.WriteLine("Tekstas");
            string text = Console.ReadLine();
            PrintSpacesAfterWord(text);
        }

        public static void PrintSpacesAfterWord(string text)
        {
            Console.WriteLine("Tarpu kiekis: {0}", text.Length - text.TrimEnd().Length);
        }
        */
        /*
        static void Main(string[] args)//8
        {
            Console.WriteLine("Tekstas");
            string text = Console.ReadLine();
            Console.WriteLine("Priekyje: {0}", PrintSpacesAfterWord(text));
        }

        public static int PrintSpacesAfterWord(string text)
        {
            return text.Length - text.TrimStart().Length;
        }
        */
        
        static void Main(string[] args)//9
        {
            Console.WriteLine("Tekstas");
            PrintSpacesBeforeAndAfterWord(Console.ReadLine(), out int countStart, out int countEnd);
            Console.WriteLine("Pradzioje: {0}, Gale: {1}", countStart, countEnd);
        }

        public static void PrintSpacesBeforeAndAfterWord(string text, out int countStart, out int countEnd)
        {
            countStart = text.Length - text.TrimStart().Length;
            countEnd = text.Length - text.TrimEnd().Length;
        }
        
    }
}