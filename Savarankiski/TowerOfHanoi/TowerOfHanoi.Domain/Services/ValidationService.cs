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
        public ValidationService(Game game)
        {
            _game = game;
        }
        private Game _game;
        public bool IsValidPickUp(ConsoleKeyInfo choice) => !_game.IsPickedUp && !(_game.Board[choice.KeyChar - 49].Count == 0);
        public bool IsValidPlace(ConsoleKeyInfo choice) => _game.IsPickedUp && _game.IsPlaceable(choice.KeyChar - 49);
    }
}
