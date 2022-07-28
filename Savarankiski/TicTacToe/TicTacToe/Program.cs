namespace TicTacToe
{
    internal class Program
    {
        public static string playerAvatar;
        public static string botAvatar;
        public static bool playerMove = false;
        public static int difficulty = 50;
        static void Main(string[] args)
        {
            string[,] board = new string[3,3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

            TicTacToe(board);
        }
        public static void TicTacToe(string[,] board)
        {
            var random = new Random();
            var choice = Console.ReadLine();
            var coin = random.Next(0, 2);



            if(choice == coin.ToString()) 
            { 
                playerMove = true; 
                playerAvatar = "X";
                botAvatar = "O";
            }
            else
            {
                playerMove = false;
                playerAvatar = "O";
                botAvatar = "X";                
            }

            Console.WriteLine("Jus esate: {0}", playerAvatar);
            PrintBoard(board);
            Console.WriteLine("Isridenta: {0}", coin);

            while (true)
            {
                

                if (playerMove)
                {
                    PlayerMove(board, playerAvatar);
                }
                else
                {
                    BotMove(board, botAvatar);
                }

                Console.Clear();
                Console.WriteLine("Jus esate: {0}", playerAvatar);
                PrintBoard(board);

                if(CheckIfWon(board, playerAvatar))
                {
                    Console.WriteLine("Pergale: {0}", playerAvatar);
                    break;
                }
                else if(CheckIfWon(board, botAvatar))
                {
                    Console.WriteLine("Pergale: {0}", botAvatar);
                    break;
                }
                else if (CheckIfDraw(board))
                {
                    Console.WriteLine("Lygiosios");
                    break;
                }

                playerMove = !playerMove;
            }

        }
        public static string[,] BotMove(string[,] board, string avatar)
        {
            Random random = new Random();
            var decision = random.Next(0,101);
            var coordinates = new int[2];

            if (BotFinisher(ref board))
            {
                return board;
            }
            if (BotDefence(ref board))
            {
                return board;
            }


            if (decision > difficulty)
            {
                while (board[coordinates[0], coordinates[1]] != " ")
                {
                    coordinates[0] = random.Next(0, 3);
                    coordinates[1] = random.Next(0, 3);
                }
                board[coordinates[0],coordinates[1]] = avatar;
            }
            else
            {
                while (board[coordinates[0], coordinates[1]] != " ")
                {
                    coordinates[0] = random.Next(0, 3);
                    coordinates[1] = random.Next(0, 3);
                }
                board[coordinates[0], coordinates[1]] = avatar;
            }
             

            return board;
        }
        public static bool BotDefence(ref string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == " " && board[i, 1] == playerAvatar && board[i, 2] == playerAvatar)
                {
                    board[i, 0] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playerAvatar && board[i, 1] == " " && board[i, 2] == playerAvatar)
                {
                    board[i, 1] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playerAvatar && board[i, 1] == playerAvatar && board[i, 2] == " ")
                {
                    board[i, 2] = botAvatar;
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == " " && board[1, i] == playerAvatar && board[2, i] == playerAvatar)
                {
                    board[0, i] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == playerAvatar && board[1, i] == " " && board[2, i] == playerAvatar)
                {
                    board[1, i] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == playerAvatar && board[1, i] == playerAvatar && board[2, i] == " ")
                {
                    board[2, i] = botAvatar;
                    return true;
                }
            }

            if (board[0, 0] == " " && board[1, 1] == playerAvatar && board[2, 2] == playerAvatar)
            {
                board[0, 0] = botAvatar;
                return true;
            }
            if (board[0, 0] == playerAvatar && board[1, 1] == " " && board[2, 2] == playerAvatar)
            {
                board[1, 1] = botAvatar;
                return true;
            }
            if (board[0, 0] == playerAvatar && board[1, 1] == playerAvatar && board[2, 2] == " ")
            {
                board[2, 2] = botAvatar;
                return true;
            }
            if (board[2, 0] == playerAvatar && board[1, 1] == playerAvatar && board[0, 2] == " ")
            {
                board[0, 2] = botAvatar;
                return true;
            }
            if (board[2, 0] == playerAvatar && board[1, 1] == " " && board[0, 2] == playerAvatar)
            {
                board[1, 1] = botAvatar;
                return true;
            }
            if (board[2, 0] == " " && board[1, 1] == playerAvatar && board[0, 2] == playerAvatar)
            {
                board[2, 0] = botAvatar;
                return true;
            }

            return false;
        }
        public static bool BotFinisher(ref string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == " " && board[i, 1] == botAvatar && board[i, 2] == botAvatar) 
                {
                    board[i,0] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == botAvatar && board[i, 1] == " " && board[i, 2] == botAvatar)
                {
                    board[i, 1] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == botAvatar && board[i, 1] == botAvatar && board[i, 2] == " ")
                {
                    board[i, 2] = botAvatar;
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == " " && board[1, i] == botAvatar && board[2, i] == botAvatar)
                {
                    board[0, i] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == botAvatar && board[1, i] == " " && board[2, i] == botAvatar)
                {
                    board[1, i] = botAvatar;
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == botAvatar && board[1, i] == botAvatar && board[2, i] == " ")
                {
                    board[2, i] = botAvatar;
                    return true;
                }
            }

            if(board[0, 0] == " " && board[1, 1] == botAvatar && board[2, 2] == botAvatar)
            {
                board[0, 0] = botAvatar;
                return true;
            }
            if (board[0, 0] == botAvatar && board[1, 1] == " " && board[2, 2] == botAvatar)
            {
                board[1, 1] = botAvatar;
                return true;
            }
            if (board[0, 0] == botAvatar && board[1, 1] == botAvatar && board[2, 2] == " ")
            {
                board[2, 2] = botAvatar;
                return true;
            }
            if (board[2, 0] == botAvatar && board[1, 1] == botAvatar && board[0, 2] == " ")
            {
                board[0, 2] = botAvatar;
                return true;
            }
            if (board[2, 0] == botAvatar && board[1, 1] == " " && board[0, 2] == botAvatar)
            {
                board[1, 1] = botAvatar;
                return true;
            }
            if (board[2, 0] == " " && board[1, 1] == botAvatar && board[0, 2] == botAvatar)
            {
                board[2, 0] = botAvatar;
                return true;
            }

            return false;
        }
        public static bool CheckIfWon(string[,] board, string avatar)
        {
            if ((board[0, 0] == avatar && board[0, 1] == avatar && board[0, 2] == avatar) // eilutes
             || (board[1, 0] == avatar && board[1, 1] == avatar && board[1, 2] == avatar)
             || (board[2, 0] == avatar && board[2, 1] == avatar && board[2, 2] == avatar)

             || (board[0, 0] == avatar && board[1, 0] == avatar && board[2, 0] == avatar) // stulpeliai
             || (board[0, 1] == avatar && board[1, 1] == avatar && board[2, 1] == avatar)
             || (board[0, 2] == avatar && board[1, 2] == avatar && board[2, 2] == avatar)

             || (board[0, 0] == avatar && board[1, 1] == avatar && board[2, 2] == avatar) // istrizaines
             || (board[2, 0] == avatar && board[1, 1] == avatar && board[0, 2] == avatar))
            {
                return true;
            }

            return false;
        }
        public static bool CheckIfDraw(string[,] board)
        {
            if (board[0, 0] != " " && board[0, 1] != " " && board[0, 2] != " "
             && board[1, 0] != " " && board[1, 1] != " " && board[1, 2] != " "
             && board[2, 0] != " " && board[2, 1] != " " && board[2, 2] != " ")
            {
                return true;
            }

            return false;
        }
        public static string[,] PlayerMove(string[,] board, string avatar)
        {
            while (true)
            {
                Console.WriteLine("Iveskite koordinates.(#,#)");
                var move = Console.ReadLine();
                var coordinates = move.Split(',');

                if (board[int.Parse(coordinates[0]) - 1, int.Parse(coordinates[1]) - 1] == " ")
                {
                    board[int.Parse(coordinates[0]) - 1, int.Parse(coordinates[1]) - 1] = avatar;
                    break;
                }
            }

            return board;
        }
        public static void PrintBoard(string[,] board)
        {

            Console.WriteLine("{0}|{1}|{2}              1,1|1,2|1,3", board[0,0], board[0, 1], board[0, 2]);
            Console.WriteLine("-----              -----------");                 
            Console.WriteLine("{0}|{1}|{2}              2,1|2,2|2,3", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("-----              -----------");                 
            Console.WriteLine("{0}|{1}|{2}              3,1|3,2|3,3", board[2, 0], board[2, 1], board[2, 2]);
        }
    }
}