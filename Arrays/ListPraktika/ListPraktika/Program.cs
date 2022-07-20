using System.Text;

namespace ListPraktika
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        // 07-20
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
        public static List<string> IsmetytiZodziai(string sentence)
        {
            List<string> words = new List<string>();
            string[] wordsArr = sentence.Split(" ");
            foreach(string word in wordsArr)
            {
                if(word.Length >= 5) { words.Add(word); }              
            }
            words.Sort();
            return words;
        }
        public static List<string> CombineLists(List<string> a, List<string> b)
        {
            List<string> combined = new List<string>();
            foreach(string st in a)
            {
                combined.Add(st);
            }
            foreach (string st in b)
            {
                combined.Add(st);
            }
            return combined;
        }
    }
}