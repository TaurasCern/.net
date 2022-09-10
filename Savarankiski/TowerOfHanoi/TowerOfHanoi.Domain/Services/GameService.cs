using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Services
{
    public class GameService : IGameService 
    {
        public GameService(Game game)
        {
            _game = game;
            _consoleService = new ConsoleService(_game);
            _validationService = new ValidationService(_game);
            _logService = new LogService(_game);
            _statisticsService = new StatisticsService();
        }
        private Game _game;
        private IConsole _consoleService;
        private IValidatable _validationService;
        private ILogable _logService;
        private IStatistics _statisticsService;

        public void GameStateMachine()
        {
            while (!_game.IsWon())
            {
                _consoleService.PrintGameBoard();

                var choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.Escape) { Environment.Exit(1); }
                else if (choice.Key == ConsoleKey.H)
                {
                    // ai
                    // log
                }
                else if(choice.KeyChar - 48 == 1 || choice.KeyChar - 48 == 2 || choice.KeyChar - 48 == 3) 
                {
                    if (_validationService.IsValidPickUp(choice)) { DiskPickupChoice(choice.KeyChar - 48); }
                    else if(_validationService.IsValidPlace(choice)) { DiskPlaceChoice(choice.KeyChar - 48); }
                }
            }
            _consoleService.PrintGameBoard();
            Console.WriteLine("win");
        }
        private void DiskPickupChoice(int choice)
        {
            _game.PickUp(choice - 1);
            _consoleService.PrintGameBoard();               
        }
        private void DiskPlaceChoice(int choice)
        {
            _game.Place(choice - 1);
            _logService.Log();
        }
    }
}
