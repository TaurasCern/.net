using System.Text;

namespace ListPraktika
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string sentence = "as esu ir Labas Kodelskis labai megstu programuoti";
            //IsmetytiZodzius(sentence);
            List<string> types = new List<string> 
            { 
                "Sirdziu",
                "Bugnu",
                "Vynu",
                "Kryziu"
            };
            List<string> cards = new List<string> 
            {
                "Tuzas",
                "Dviake",
                "Triake",
                "Keturake",
                "Penkake",
                "Sesake",
                "Septynake",
                "Astuonake",
                "Devynakės",
                "Desimtake",
                "Valetas",
                "Dama",
                "Karalius"
            };

            PrintDeck(SukonstruotiKalade(types, cards));
        }
        // 07-19
        public static int FindHighestNumber(List<int> numbers) => numbers.Max();
        public static List<int> DidesnisUzDidziausia(List<int> numbers)
        {
            numbers.Add(FindHighestNumber(numbers) + 1);
            return numbers;
        }
        public static List<int> DidesnisUzDidziausia1(List<int> numbers)
        {
            numbers.Sort();
            numbers.Add(numbers[numbers.Count - 1] + 1);
            return numbers;
        }
        public static List<int> DidesnisUzDidziausia2(List<int> numbers)
        {
            numbers.Add(FindHighestNumber1(numbers) + 1);
            return numbers;
        }
        public static int FindHighestNumber1(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (max < number) { max = number; }
            }
            return max;
        }
        public static int FindLowestNumber(List<int> numbers)
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (min > number) { min = number; }
            }
            return min;
        }
        public static List<int> RemoveLowestNumber(List<int> numbers)
        {
            int min = FindLowestNumber(numbers);
            while (numbers.Contains(min))
            {
                numbers.Remove(min);
            }
            return numbers;
        }
        //---------------------------------------------------------------------------
        // 07-20 + 7-21
        /// <summary>
        /// 1
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double Avg(List<int> numbers)
        {
            double avg = 0;
            foreach (int number in numbers)
            {
                avg += number;
            }
            return avg / numbers.Count;
        }
        /// <summary>
        /// 2
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static List<string> IsPositive(List<int> numbers)
        {
            List<string> result = new List<string>();
            foreach (int number in numbers)
            {
                if (number >= 0) { result.Add("Teigiamas"); }
                else if (number < 0) { result.Add("Neigiamas"); }
            }
            return result;
        }
        /// <summary>
        /// 3
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="gpm"></param>
        /// <returns></returns>
        public static double CalculateGPM(List<double> numbers, int gpm)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result * (gpm / 100d);
        }
        /// <summary>
        /// 4
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<int> IstrauktiSkaicius(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in text)
            {
                if (Char.IsDigit(ch)) { sb.Append(ch); }
            }
            return Sort(sb.ToString());
        }
        public static List<int> Sort(string numbersInText)
        {
            List<int> numbers = new List<int>();
            foreach(char ch in numbersInText)
            {
                numbers.Add(ch - 48);
            }
            numbers.Sort();
            return numbers;
        }
        /// <summary>
        /// 5
        /// </summary>
        public static List<string> IsmetytiZodzius(string sentence)
        {
            List<string> words = new List<string>();
            List<string> wordsLessThan5 = new List<string>();
            string[] wordsArr = sentence.Split(" ");

            foreach(string word in wordsArr)
            {
                if(word.Length >= 5) { words.Add(word); }   
                else { wordsLessThan5.Add(word); }
            }

            words.Sort();

            return CombineLists(wordsLessThan5, words);
        }
        public static List<string> CombineLists(List<string> a, List<string> b)
        {
            List<string> combined = new List<string>();

            foreach (string word in a)
            {
                combined.Add(word);
            }
            foreach(string word in b)
            {
                combined.Add(word);
            }

            Console.WriteLine(String.Join(" ", combined));

            return combined;
        }
        /// <summary>
        /// 6
        /// </summary>
        public static List<string> SukonstruotiKalade(List<string> types, List<string> cards)
        {
            List<string> deck = new List<string>();

            foreach(var type in types)
            {
                foreach(var card in cards)
                {
                    deck.Add(type + " " + card);
                }
            }

            return SortDeck(deck);
        }
        public static List<string> SortDeck(List<string> deck)
        {
            deck.Sort();
            return deck;
        }
        public static void PrintDeck(List<string> deck)
        {
            foreach(var card in deck)
            {
                Console.WriteLine(card);
            }
        }
    }
}