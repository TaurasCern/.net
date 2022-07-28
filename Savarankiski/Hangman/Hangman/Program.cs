using System.Text;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            var names = new string[] { "Ignas", "Dominykas", "Matas", "Martynas", "Tauras", "Emilija", "Ieva", "Viktorija", "Agata" ,"Justina" };
            var cities = new string[] { "Kaunas", "Vilnius", "Kėdainiai", "Klaipėda", "Telsiai", "Tauragė", "Plungė", "Panevėžys", "Lazdijai", "Alytus" };
            var countries = new string[] { "Lietuva", "Latvija", "Estija", "Vokietija", "Japonija", "Kinija", "Prancūzija", "Ukraina", "Ispanija", "Rusija" };
            var other = new string[] { "Bananas", "Obuolys", "Kriaušė", "Agurkas", "Pomidoras", "Svogunas", "Abrikosas", "Čedario sūris", "Česnakas", "Lokomotyvas"};


            Start(names, cities, countries, other);
        }
        /// <summary>
        /// Hangman menu state machine
        /// </summary>
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
        /// <summary>
        /// Main method of the hangman game
        /// </summary>
        public static void Hangman(ref string[] words, string theme)
        {
            string word = PickRandomString(words, new Random());
            var fails = 0;

            StringBuilder wordField = new StringBuilder(new string('_', word.Length));

            List<string> guessed = new List<string>();

            bool isGuessed = false;
            bool isBadInput = false;
            bool isNotLetter = false;

            while (true)
            {
                Console.Clear();

                PrintGame(wordField.ToString(), theme, fails);
                Console.WriteLine("Jau spetos raides: {0}", String.Join(", ", guessed));
                Console.WriteLine();

                PrintError(ref isGuessed, ref isBadInput, ref isNotLetter);

                Console.Write("Spejimas: ");
                var guess = Console.ReadLine().ToLower();
                Console.WriteLine();

                if(CheckForError(guessed, word, guess, ref isNotLetter, ref isGuessed, ref isBadInput)) { continue; }

                wordField = Guess(wordField, word, ref fails, guess, guessed);

                if (CheckIfLost(word, guess, fails))
                {
                    Console.Clear();
                    Console.WriteLine("Pralaimejote{0}", Environment.NewLine);
                    break;
                }
                if (CheckIfWon(word, wordField.ToString(), guess))
                {
                    Console.Clear();
                    Console.WriteLine("Laimejote{0}", Environment.NewLine);
                    break;
                }
            }

            PrintGame(word, theme, fails);

            words = ArrayRemove(words, word);
        }
        /// <summary>
        /// Method to validate input
        /// </summary>
        /// <returns> True if not valid, False if valid </returns>
        public static bool CheckForError(List<string> guessed, string word, string guess, ref bool isNotLetter, ref bool isGuessed, ref bool isBadInput)
        {
            if (guessed.Contains(guess.ToLower()))
            {
                isGuessed = true;
                return true;
            }
            else if (guess.Length != word.Length && guess.Length != 1)
            {
                isBadInput = true;
                return true;
            }
            else if(guess.Length > 0)
            {
                foreach(var ch in guess)
                {
                    if (!Char.IsLetter(ch))
                    {
                        isNotLetter = true;
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Method to print input error
        /// </summary>
        public static void PrintError(ref bool isGuessed, ref bool isBadInput, ref bool isNotLetter)
        {
            if (isGuessed)
            {
                Console.WriteLine("Raide jau buvo speta");
                isGuessed = false;
            }
            else if (isBadInput)
            {
                Console.WriteLine("Ivestas neteisingo ilgio zodis");
                isBadInput = false;
            }
            else if (isNotLetter)
            {
                Console.WriteLine("Ivestyje yra skaiciu ar simboliu");
                isNotLetter = false;
            }
        }
        /// <summary>
        /// Method to print the theme menu
        /// </summary>
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
        /// <summary>
        /// Methos to ask the user wants to continue the game
        /// </summary>
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
        /// <summary>
        /// Mehtod to process and print the hangman screen
        /// </summary>
        /// <param name="word"></param>
        /// <param name="theme"></param>
        /// <param name="fails"></param>
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
            


            Console.Write("Zodis: ");
            foreach(var letter in word)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Method to pick a random string out of a string array
        /// </summary>
        /// <returns> random string out of the array </returns>
        public static string PickRandomString(string[] words, Random random) => words[random.Next(0, words.Length)];
        /// <summary>
        /// Method to check if the user won (called after CheckIfLost method)
        /// </summary>
        /// <returns> True if won, false if not</returns>
        public static bool CheckIfWon(string word, string wordField, string guess)
        {
            if (guess.Length > 1)
            {
                if(word.ToLower() == guess.ToLower())
                {
                    return true;
                }
            }
            else if (guess.Length == 1)
            {
                if (!wordField.Contains("_"))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Method to check if user lost (called before CheckIfWon method)
        /// </summary>
        /// <returns> True if lost, False if not</returns>
        public static bool CheckIfLost(string word, string guess, int fails)
        {
            if(guess.Length == 1 && fails > 6)
            {
                return true;
            }
            else if(guess.Length > 1 && word.ToLower() != guess.ToLower())
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Method to process a guess
        /// </summary>
        /// <returns> wordField with '_' replaced with guessed letters </returns>
        public static StringBuilder Guess(StringBuilder wordField, string word, ref int fails, string guess, List<string> guessed)
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
                        wordField[i] = word[i];
                    }
                }
            }
            if (!guessed.Contains(guess.ToLower()))
            {
                guessed.Add(guess.ToLower());
            }

            return wordField;
        }

        /// <summary>
        /// Method to remove sent entry(word) in the string array
        /// </summary>
        /// <returns> array without the sent entry(word)</returns>
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