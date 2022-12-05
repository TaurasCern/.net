using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Services;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Services
{
    public class HelperService : IHelper
    {
        public HelperService(IGame game)
        {
            _game = game;
        }
        private IGame _game;
        private string _logDirectory = $"{Environment.CurrentDirectory}\\Logs\\";
        private Log _previousLog;
        private int _bestMoves = int.MaxValue;
        private bool _isFound = false;
        private int _moveFrom = 0;
        private int _moveTo = 0;
        /// <summary>
        /// Method to find log files priority(csv => html => txt)
        /// </summary>
        /// <param name="files">array of file directories</param>
        /// <returns>Dicktionary<Filename, File extension></returns>
        public Dictionary<string, string> FindFilePriority(string[] files)
        {
            Dictionary<string, string> filePriority = new Dictionary<string, string>();

            foreach (var file in files)
            {
                string[] split = file.Split("\\")[file.Split("\\").Length - 1].Split('.');
                if (split[1] == "txt")
                {
                    filePriority[split[0]] = split[1];
                }
            }
            foreach (var file in files)
            {
                string[] split = file.Split("\\")[file.Split("\\").Length - 1].Split('.');
                if (split[1] == "html")
                {
                    filePriority[split[0]] = split[1];
                }
            }
            foreach (var file in files)
            {
                string[] split = file.Split("\\")[file.Split("\\").Length - 1].Split('.');
                if (split[1] == "csv")
                {
                    filePriority[split[0]] = split[1];
                }
            }

            return filePriority;
        }
        /// <summary>
        /// Method to redirect files to appropriate method
        /// </summary>
        /// <returns>Help tip</returns>
        public string FindHelp()
        {
            Dictionary<string, string> files = FindFilePriority(Directory.GetFiles(_logDirectory));

            foreach (var file in files)
            {
                if (file.Value == "csv")
                {
                    FindMoveCsv(File.ReadAllLines(_logDirectory + file.Key + "." + file.Value));
                }
                else if (file.Value == "html")
                {
                    FindMoveHtml(File.ReadAllText(_logDirectory + file.Key + "." + file.Value));
                }
                else if (file.Value == "txt")
                {
                    FindMoveTxt(File.ReadAllText(_logDirectory + file.Key + "." + file.Value));
                }
            }

            return FormatHelpTip();
        }
        public string FormatHelpTip() => _isFound
                ? $"<pagalba> - paimkite diską iš {(ENumberWords)_moveFrom} stulpelio ir padėkite į {(ENumberWords)(_moveTo + 10)}"
                : "Pagalba negalima";
        /// <summary>
        /// Method to find helping move
        /// </summary>
        /// <param name="lines">logs in csv format</param>
        public void FindMoveCsv(string[] lines)
        {
            Log gameState = GameState();
            Log currentLog = new Log();

            _previousLog = new Log(_game.GameStartDate, 0, 1, 1, 1, 1);

            if (lines.Length < 2) { return; }

            Log finalLog = new Log();
            finalLog.ParseCsv(lines[lines.Length - 1]);


            for (int i = 1; i < lines.Length; i++)
            {
                currentLog.ParseCsv(lines[i]);
                if (_previousLog.Equals(gameState) && _bestMoves >= finalLog.Move && finalLog.IsWon)
                {

                    if (currentLog.FirstDiskLocation != _previousLog.FirstDiskLocation)
                    {
                        _moveFrom = _previousLog.FirstDiskLocation;
                        _moveTo = currentLog.FirstDiskLocation;
                    }
                    if (currentLog.SecondDiskLocation != _previousLog.SecondDiskLocation)
                    {
                        _moveFrom = _previousLog.SecondDiskLocation;
                        _moveTo = currentLog.SecondDiskLocation;
                    }
                    if (currentLog.ThirdDiskLocation != _previousLog.ThirdDiskLocation)
                    {
                        _moveFrom = _previousLog.ThirdDiskLocation;
                        _moveTo = currentLog.ThirdDiskLocation;
                    }
                    if (currentLog.FourthDiskLocation != _previousLog.FourthDiskLocation)
                    {
                        _moveFrom = _previousLog.FourthDiskLocation;
                        _moveTo = currentLog.FourthDiskLocation;
                    }
                    _isFound = true;
                }
                _bestMoves = finalLog.Move;
                _previousLog = (Log)currentLog.Clone();
            }
        }
        /// <summary>
        /// Method to find helping move by converting html logs into csv and calling FindMoveCsv(string[] lines)
        /// </summary>
        /// <param name="htmlText">full html log file</param>
        public void FindMoveHtml(string htmlText)
        {
            GameLog gameLog = new GameLog();
            gameLog.ParseHtml(htmlText);
            FindMoveCsv(gameLog.ToCsv());
        }
        /// <summary>
        /// Method to find helping move by converting txt logs into csv and calling FindMoveCsv(string[] lines)
        /// </summary>
        /// <param name="txtText">full txt log file</param>
        public void FindMoveTxt(string txtText)
        {
            GameLog gameLog = new GameLog();
            gameLog.ParseTxt(txtText);
            FindMoveCsv(gameLog.ToCsv());
        }
        public Log GameState()
        {
            var locations = _game.GetLocations();
            return new Log(_game.GameStartDate, _game.Moves, locations[0] + 1, locations[1] + 1, locations[2] + 1, locations[3] + 1);
        }  
    }
}
