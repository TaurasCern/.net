namespace ListPraktika
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
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
            foreach(int number in numbers)
            {
                if(max < number) { max = number; }
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

    }
}