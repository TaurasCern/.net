using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Services
{
    public class InputService : IInputService 
    {
        public InputService(Game game)
        {
            _game = game;
            _consoleService = new ConsoleService(_game);
        }
        private Game _game;
        private IConsole _consoleService;
        public void GameStateMachine()
        {
            ILogable logService = new LogService(_game);

            while (!_game.IsWon())
            {
                _consoleService.PrintGameBoard();

                var choice = ValidInput();

                if (choice.Key == ConsoleKey.Escape) { Environment.Exit(1); }
                else if (choice.Key == ConsoleKey.H)
                {
                    // ai
                    // log
                }
                else if(choice.KeyChar - 48 == 1|| choice.KeyChar - 48 == 2 || choice.KeyChar - 48 == 3)
                {
                    TowerChoice(_game, choice.KeyChar - 48);
                    _consoleService.PrintGameBoard();
                    if (!_game.IsPickedUp) { logService.Log(); }                   
                }
            }
            Console.WriteLine("win");
        }
        public void TowerChoice(Game game, int choice)
        {
            if (!game.IsPickedUp)
            {
                if (game.Board[choice - 1].Count == 0) { return; }
                game.PickUp(choice - 1);
                _consoleService.PrintGameBoard();
            }          
            var placeChoice = ValidIntInput();
            game.Place(placeChoice - 1); 
            
        }
        public int ValidIntInput()
        {
            var input = Console.ReadKey();
            while ((input.KeyChar - 48 != 1)
               && (input.KeyChar - 48 != 2)
               && (input.KeyChar - 48 != 3))
            {
                input = Console.ReadKey();
            }

            return input.KeyChar - 48;
        }
        public ConsoleKeyInfo ValidInput()
        {
            var input = Console.ReadKey();
            while((input.Key != ConsoleKey.Escape) 
               && (input.Key != ConsoleKey.H) 
               && (input.KeyChar - 48 != 1) 
               && (input.KeyChar - 48 != 2) 
               && (input.KeyChar - 48 != 3))
            {
                input = Console.ReadKey();
            }

            return input;
        }
    }
}
