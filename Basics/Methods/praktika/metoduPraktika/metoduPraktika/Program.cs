namespace metoduPraktika
{
    internal class Program
    {
        /*
        public static void Main(string[] args)//1
        {
            PrintHello();
            PrintToScreen();
        }

        public static void PrintHello()
        {
            Console.WriteLine("Sveiki visi");
        }

        public static void PrintToScreen()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }
        */
        /*
        public static void Main(string[] args)//2
        {
            PrintToScreen();
        }

        public static string EnterName()
        {
            string name;
            Console.WriteLine("Iveskite varda");
            name = Console.ReadLine();
            Console.WriteLine("Labas {0}", name);
            return name;
        }

        public static void PrintToScreen()
        {
            Console.WriteLine("Linkiu jums {0} geros dienos", EnterName());
        }
        */
        /*
        public static void Main(string[] args)//3
        {
            bool in1 = int.TryParse(Console.ReadLine(), out int num1);
            if(!in1) { Console.WriteLine("blogai ivestas skaicius"); }
            bool in2 = int.TryParse(Console.ReadLine(), out int num2);
            if (!in2) { Console.WriteLine("blogai ivestas skaicius"); }
            Sum(num1, num2);
        }

        public static void Sum(int num1, int num2)
        {
            Console.WriteLine("Rezultatas: {0}", num1 + num2);
        }
        */
        /*
        public static void Main(string[] args)//4
        {
            string text = Console.ReadLine();
            WhiteSpaceCount(text);
        }

        public static void WhiteSpaceCount(string text)
        {
            int count = text.Replace(" ", "").Length;
            Console.WriteLine("Tarpu kiekis: {0}", text.Length - count);
        } 
        */
        
        public static void Main(string[] args)//5
        {
            string text = Console.ReadLine();
            TextLength(text);
        }

        public static void TextLength (string text)
        {
            string trimmed = text.Trim();
            Console.WriteLine("Teksto ilgis yra: {0}", trimmed.Length);
        }
        
    }
}