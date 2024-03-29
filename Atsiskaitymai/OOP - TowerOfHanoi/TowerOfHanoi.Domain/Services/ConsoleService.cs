﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Services
{
    public class ConsoleService : IConsole
    {
        private IGame _game;

        public ConsoleService(IGame game)
        {
            _game = game;
            Message = "";
        }
        public string Message { get; set; }
        public void PrintGameBoard()
        {
            Console.Clear();
            Console.WriteLine($"Ejimas: {_game.Moves}{Environment.NewLine}");
            Console.WriteLine("Diskas rankoje: {0}{1}", 
                _game.PickedUpDisk != null 
                ? new string('#', 
                _game.PickedUpDisk.Size * 2) 
                : "", Environment.NewLine);
            Console.WriteLine( "1eil      |            |            |");
            Console.WriteLine("2eil{0}{1}{2}",
                FormatCell(_game.Board[0], 3),
                FormatCell(_game.Board[1], 3),
                FormatCell(_game.Board[2], 3));
            Console.WriteLine("3eil{0}{1}{2}",
                FormatCell(_game.Board[0], 2),
                FormatCell(_game.Board[1], 2),
                FormatCell(_game.Board[2], 2));
            Console.WriteLine("4eil{0}{1}{2}",
                FormatCell(_game.Board[0], 1),
                FormatCell(_game.Board[1], 1),
                FormatCell(_game.Board[2], 1));
            Console.WriteLine("5eil{0}{1}{2}",
                FormatCell(_game.Board[0], 0),
                FormatCell(_game.Board[1], 0),
                FormatCell(_game.Board[2], 0));
            Console.WriteLine();

            PrintMessage();
        }
        /// <summary>
        /// Method to format a cell according to current state of the game
        /// </summary>
        /// <param name="collumn"></param>
        /// <param name="row"></param>
        /// <returns>Formated cell</returns>
        private string FormatCell(List<Disk> collumn, int row)
            => collumn.Count > row ?
                $"{new string(' ', 6 - collumn[row].Size)}{new string('#', collumn[row].Size)}|" +
                $"{new string('#',collumn[row].Size)}{new string(' ', 6 - collumn[row].Size)}"
                : "      |      ";
        private void PrintMessage()
        {
            if (!Message.Contains("<pagalba>") && !Message.Contains("Zaidimas Baigtas"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.White;
            Message = "";
        }
    }
}
