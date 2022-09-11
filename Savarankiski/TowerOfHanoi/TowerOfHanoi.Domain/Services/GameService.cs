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
            _validationService = new ValidationService(_game, _consoleService);
            _helperService = new HelperService(_game);
            _statisticsService = new StatisticsService();
        }
        private IGame _game;
        private IConsole _consoleService;
        private IValidatable _validationService;
        private ILogable _logService;
        private IStatistics _statisticsService;
        private IHelper _helperService;
        /// <summary>
        /// Method to Start the game loop
        /// </summary>
        public void StartGame()
        {
            while (true)
            {
                GameStateMachine();

                Console.WriteLine("Ar norite zaisti dar karta?(Y/N)");
                var choice = Console.ReadKey();

                while(!(choice.Key == ConsoleKey.Y) && !(choice.Key == ConsoleKey.N))
                {
                    _consoleService.PrintGameBoard();
                    Console.WriteLine("Ar norite zaisti dar karta?(Y/N)");
                }

                if(choice.Key == ConsoleKey.N) { break; }

                _game = new Game(DateTime.Now);
                _consoleService = new ConsoleService(_game);
                _validationService = new ValidationService(_game, _consoleService);
                _helperService = new HelperService(_game);
                _statisticsService = new StatisticsService();
            }
            
        }
        /// <summary>
        /// State machine to call chosen actions
        /// </summary>
        public void GameStateMachine()
        {
            _logService = new LogService(_game, _game.GameStartDate);
            _logService.SetConfig();


            while (!_game.IsWon())
            {
                _consoleService.PrintGameBoard();

                var choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.Escape) { Environment.Exit(1); }
                else if (choice.Key == ConsoleKey.H)
                {
                   if(_validationService.IsValidHelp()) HelpChoice();
                }
                else if(choice.KeyChar - 48 == 1 || choice.KeyChar - 48 == 2 || choice.KeyChar - 48 == 3) 
                {
                    if (_validationService.IsValidPickUp(choice)) { DiskPickupChoice(choice.KeyChar - 48); }
                    else if(_validationService.IsValidPlace(choice)) { DiskPlaceChoice(choice.KeyChar - 48); }
                }
                else { _consoleService.Message = "TOKIO PASIRINKIMO NERA"; }
            }
            ProcessVictory();
        }
        /// <summary>
        /// Method to call victory display and choose statistics
        /// </summary>
        private void ProcessVictory()
        {
            _consoleService.Message = "Zaidimas Baigtas.";
            _consoleService.PrintGameBoard();

            Console.WriteLine("Kuria statistika isspausdinti?(1 - Kiekis, 2 - Perteklis)");

            var choice = Console.ReadKey();

            while (!(choice.KeyChar - 48 == 1) && !(choice.KeyChar - 48 == 2))
            {
                Console.Clear();
                Console.WriteLine("Kuria statistika isspausdinti?(1 - Kiekis, 2 - Perteklis)");
                choice = Console.ReadKey();
            }
            _statisticsService.IsUntilWin = choice.KeyChar - 48 == 1 ? true : false;

            Console.WriteLine();
            Console.WriteLine(_statisticsService.CreateStatistics());
        }
        /// <summary>
        /// Method to add help line for current move
        /// </summary>
        private void HelpChoice()
        {
            _consoleService.Message = _helperService.FindHelp();
        }
        /// <summary>
        /// Method to "Pick up" Disk
        /// </summary>
        /// <param name="choice">collumn</param>
        private void DiskPickupChoice(int choice)
        {
            _game.PickUp(choice - 1);
            _consoleService.PrintGameBoard();               
        }
        /// <summary>
        /// Method to "Place" Disk
        /// </summary>
        /// <param name="choice">collumn</param>
        private void DiskPlaceChoice(int choice)
        {
            _game.Place(choice - 1);
            _logService.Log();
        }
    }
}
