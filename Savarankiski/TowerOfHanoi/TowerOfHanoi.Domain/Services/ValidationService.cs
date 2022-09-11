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
        public ValidationService(IGame game)
        {
            _game = game;
        }
        private IGame _game;
        /// <summary>
        /// Mehtod to check if "Pick up" is valid
        /// </summary>
        /// <param name="choice">collumn choice</param>
        /// <returns>is pickup valid</returns>
        public bool IsValidPickUp(ConsoleKeyInfo choice) => !_game.IsPickedUp && !(_game.Board[choice.KeyChar - 49].Count == 0);
        /// <summary>
        /// Mehtod to check if "place" is valid
        /// </summary>
        /// <param name="choice">collumn choice</param>
        /// <returns>is place valid</returns>
        public bool IsValidPlace(ConsoleKeyInfo choice) => _game.IsPickedUp && _game.IsPlaceable(choice.KeyChar - 49);
    }
}
