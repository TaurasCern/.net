﻿using TowerOfHanoi.Domain.Services;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            IInputService inputService = new InputService(game);
            inputService.GameStateMachine();
        }
 
    }
}