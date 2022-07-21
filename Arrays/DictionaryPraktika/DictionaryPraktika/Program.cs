namespace DictionaryPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDictionary(Create(ReadInt()));
        }
        public static int ReadInt()
        {
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out int _);

            while (!isInt)
            {
                Console.WriteLine("Ivestas ne sveikasis skaicius");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
        /// <summary>
        /// 1
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static Dictionary<int, int> Create(int count)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 1; i <= count; i++)
            {
                dictionary.Add(i, i * i);
            }

            return dictionary;
        }
        public static void PrintDictionary(Dictionary<int, int> dictionary)
        {
            foreach (KeyValuePair<int, int> entry in dictionary)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
        }
    }
}