using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Services
{
    public class ValidationService : IValidatable
    {
        public ValidationService(IGame game, IConsole consoleService)
        {
            _game = game;
            _consoleService = consoleService;
        }
        private IGame _game;
        private IConsole _consoleService;
        /// <summary>
        /// Mehtod to check if "Pick up" is valid
        /// </summary>
        /// <param name="choice">collumn choice</param>
        /// <returns>is pickup valid</returns>
        public bool IsValidPickUp(ConsoleKeyInfo choice)  
        {
            var isValid = !_game.IsPickedUp && !(_game.Board[choice.KeyChar - 49].Count == 0);
            if (!isValid && !_game.IsPickedUp)
            {
                _consoleService.Message = "STULPELYJE NĖRA DISKO";
            }
            return isValid;
        }

        /// <summary>
        /// Mehtod to check if "place" is valid
        /// </summary>
        /// <param name="choice">collumn choice</param>
        /// <returns>is place valid</returns>
        public bool IsValidPlace(ConsoleKeyInfo choice)
        {
            var isValid = _game.IsPickedUp && _game.IsPlaceable(choice.KeyChar - 49);

            if (!isValid && _game.IsPickedUp)
            {
                _consoleService.Message = "NEGALIMA DIDESNIO DISKO DĖTI ANT MAŽESNIO";
            }
            return isValid;
        } 
        public bool IsValidHelp()
        {
            var isValid = !_game.IsPickedUp;
            if (!isValid)
            {
                _consoleService.Message = "PAGALBA NETEIKIAMA, KAI YRA PAKELTAS DISKAS";
            }
            return isValid;
        }
    }
}
