using System.Text;

namespace Hangman
{
    internal class Program
    {
        //public static wrongg
        static void Main(string[] args)
        {
            var names = new string[] { "Ignas", "Dominykas", "Matas", "Martynas", "Tauras", "Emilija", "Ieva", "Viktorija", "Agata" ,"Justina" };
            var cities = new string[] { "Kaunas", "Vilnius", "Kėdainiai", "Klaipėda", "Telšiai", "Tauragė", "Plungė", "Panevėžys", "Lazdijai", "Alytus" };
            var countries = new string[] { "Lietuva", "Latvija", "Estija", "Vokietija", "Japonija", "Kinija", "Prancūzija", "Ukraina", "Ispanija", "Rusija" };
            var other = new string[] { "Bananas", "Obuolys", "Kriaušė", "Agurkas", "Pomidoras", "Svogunas", "Abrikosas", "Čedario sūris", "Česnakas", "Lokomotyvas"};

            Start(names, cities, countries, other);
        }
        public static void Start(string[] names, string[] cities, string[] countries, string[] other)
        {
            PrintMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    if (names.Length < 1) Start(names, cities, countries, other);
                    else Hangman(ref names, "Vardai");
                    break;

                case "2":

                    if (cities.Length < 1) Start(names, cities, countries, other);
                    else Hangman(ref cities, "Miestai");
                    break;

                case "3":

                    if (countries.Length < 1) Start(names, cities, countries, other);
                    else Hangman(ref countries, "Valstybė");
                    break;

                case "4":

                    if(other.Length < 1) Start(names, cities, countries, other);
                    else Hangman(ref other, "Kita");                  
                    break;

                default:

                    Start(names, cities, countries, other);
                    break;
            }

            if (Continue())
            {
                Start(names, cities, countries, other);
            }
        }
        public static void Hangman(ref string[] words, string theme)
        {
            string word = PickRandomString(words);
            StringBuilder sb = new StringBuilder(new string('_', word.Length));
            var fails = 0;
            List<string> guessed = new List<string>();

            bool isGuessed = false;
            bool isBadInput = false;

            while(true)
            {
                Console.Clear();
                PrintGame(sb.ToString(), theme, fails);

                PrintError(isGuessed,isBadInput);

                Console.Write("Spejimas: ");
                var guess = Console.ReadLine();
                Console.WriteLine();

                if (guessed.Contains(guess))
                {
                    isGuessed = true;
                    continue;
                }
                else if(guess.Length != word.Length && guess.Length != 1)
                {
                    isBadInput = true;
                    continue;
                }

                if (guess.Length > 1)
                {
                    if (CheckIfWon(word, guess))
                    {
                        break;
                    }
                }
                else
                {
                    sb = LetterGuess(sb, word, ref fails, guess, guessed);
                    if (CheckIfWon(sb, fails))
                    {
                        break;
                    }
                }
            }

            PrintGame(word, theme, fails);

            words = ArrayRemove(words, word);
        }
        public static void PrintError(bool isGuessed, bool isBadInput)
        {
            if (isGuessed)
            {
                Console.WriteLine("Raide jau buvo speta");
            }
            else if (isBadInput)
            {
                Console.WriteLine("Ivestas neteisingo ilgio zodis");
            }
        }
        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine(
                "Pasirinkite temą:{0}" +
                "1. Vardai{0}" +
                "2. Miestai{0}" +
                "3. Valstybės{0}" +
                "4. Kita{0}",
                Environment.NewLine);

        }
        public static void PrintGame(string word, string theme, int fails)
        {
            string[] body = new string[] {    "o",
                                         "\\","|","/",
                                              "0",
                                          "/",    "\\"};

            string[] failsBody = new string[7];

            for (int i = 0; i < fails; i++)
            {
                failsBody[i] = body[i];
            }



            Console.WriteLine("Tema: {0}", theme);

            Console.WriteLine("------------|");
            Console.WriteLine("|           {0}", failsBody[0]);
            Console.WriteLine("|          {0}{1}{2}", failsBody[1], failsBody[2], failsBody[3]);
            Console.WriteLine("|           {0}", failsBody[4]);
            Console.WriteLine("|          {0} {1}", failsBody[5], failsBody[6]);
            Console.WriteLine("|           ");
            Console.WriteLine("|           ");
            

            Console.WriteLine("Zodis: {0}", word);

        }
        public static string PickRandomString(string[] words)
        {
            var random = new Random();

            return words[random.Next(0, words.Length)];
        }
        public static bool CheckIfWon(StringBuilder sb, int fails)
        {
            if (!sb.ToString().Contains('_') && (fails < 7))
            {
                Console.Clear();
                Console.WriteLine("Laimejote{0}",Environment.NewLine);
                return true;
            }
            else if (fails == 7)
            {
                Console.Clear();
                Console.WriteLine("Pralaimejote{0}", Environment.NewLine);
                return true;
            }
            return false;
        }
        public static bool CheckIfWon(string word, string guess)
        {
            if (word.ToLower() != guess.ToLower())
            {
                Console.Clear();
                Console.WriteLine("Pralaimejote");
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Laimejote");
                return true;
            }
        }
        public static StringBuilder LetterGuess(StringBuilder sb, string word, ref int fails, string guess, List<string> guessed)
        {
            if (!word.ToLower().Contains(guess.ToLower()))
            {
                fails++;
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString().ToLower() == guess.ToLower())
                    {
                        sb[i] = word[i];
                    }
                }
            }

            guessed.Add(guess.ToLower());
            guessed.Add(guess.ToUpper());

            return sb;
        }
        public static bool Continue()
        {
            Console.WriteLine("Ar norite testi zaidima?(T/N)");

            var choice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            if (choice.ToUpper() == "T")
            {
                return true;
            }
            else if (choice.ToUpper() == "N")
            {
                return false;
            }
            else
            {
                Console.Clear();
                Continue();
            }

            return false;
        }
        public static string[] ArrayRemove(string[] words, string word)
        {
            var newWords = new string[words.Length - 1];
            var newWordsIndex = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (!(words[i].ToLower() == word.ToLower()))
                {
                    newWords[newWordsIndex] = words[i];
                    newWordsIndex++;
                }
            }
            return newWords;
        }
    }
}