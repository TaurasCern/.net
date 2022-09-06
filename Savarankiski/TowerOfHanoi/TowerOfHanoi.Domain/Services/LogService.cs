using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Services
{
    public class LogService : ILogable
    {
        public LogService(Game game)
        {
            Game = game;
            using StreamReader sr = new StreamReader(_configPath);
            string configLine;
            while ((configLine = sr.ReadLine()) != null)
            {
                string[] config = configLine.Split(":");
                if(config.Length < 2) { continue; }
                if (config[0] == "txt" && config[1] == "true") { _logTxt = true; }
                else if (config[0] == "html" && config[1] == "true") { _logHtml = true; }
                else if (config[0] == "csv" && config[1] == "true") { _logCsv = true; }
            }
            sr.Close();
        }
        private Game Game;
        private bool _logCsv = false;
        private bool _logHtml = false;
        private bool _logTxt = false;
        private DateTime? _gameStartTime = null;
        private readonly string _configPath = $"{Environment.CurrentDirectory}\\game.config";
        private readonly string _logDirectory = $"{Environment.CurrentDirectory}\\Logs\\";
        public void Log()
        {
            if(_gameStartTime == null) { _gameStartTime = DateTime.Now; }
            if (_logTxt){ LogTxt(); }
            if (_logHtml){ LogHtml(); }
            if (_logCsv) { LogCsv(); }
        }
        private void LogTxt() 
        {
            using StreamWriter sw = new StreamWriter($"{_logDirectory}{((DateTime)_gameStartTime).ToFileTime()}.txt", true);
            sw.WriteLine($"žaidime kuris pradėtas {_gameStartTime}, ėjimu nr {Game.Moves}" +
                $", {Game.Board[Game.CurrentCollumn][Game.Board[Game.CurrentCollumn].Count - 1].Size} " +
                $"dalies diskas buvo paimtas iš {(ENumberWords)Game.PreviousCollumn + 1} " +
                $"ir padėtas į {(ENumberWords)Game.CurrentCollumn + 1}");
            sw.Close();
        }
        private void LogHtml() 
        {
            if (!File.Exists($"{Environment.CurrentDirectory}\\Logs\\{((DateTime)_gameStartTime).ToFileTime()}.html"))
            {
                using StreamWriter header = new StreamWriter($"{_logDirectory}{((DateTime)_gameStartTime).ToFileTime()}.html");
                header.WriteLine(
                $"<table border>{Environment.NewLine}" +
                $"<tr>{Environment.NewLine}" +
                $"<th>ŽAIDIMO PRADŽIOS DATA</td>{Environment.NewLine}" +
                $"<th>ĖJIMO NR</td>{Environment.NewLine}" +
                $"<th> DISKO 1 VIETA </td>{Environment.NewLine}" +
                $"<th> DISKO 2 VIETA </td>{Environment.NewLine}" +
                $"<th> DISKO 3 VIETA </td>{Environment.NewLine}" +
                $"<th> DISKO 4 VIETA </td>{Environment.NewLine}" +
                $"</tr>{Environment.NewLine}");
                header.Close();
            }

            using StreamWriter sw = new StreamWriter($"{_logDirectory}{((DateTime)_gameStartTime).ToFileTime()}.html", true);
            List<int> locations = Game.GetLocations();
            sw.WriteLine(
                $"<tr>{Environment.NewLine}" +
                $"<td>{_gameStartTime}</td>{Environment.NewLine}" +
                $"<td>{Game.Moves}</td>{Environment.NewLine}" +
                $"<td>{locations[0] + 1}</td>{Environment.NewLine}" +
                $"<td>{locations[1] + 1}</td>{Environment.NewLine}" +
                $"<td>{locations[2] + 1}</td>{Environment.NewLine}" +
                $"<td>{locations[3] + 1}</td>{Environment.NewLine}" +
                $"</tr>");
            sw.Close();
        }
        private void LogCsv()
        {
            if (!File.Exists($"{Environment.CurrentDirectory}\\Logs\\{((DateTime)_gameStartTime).ToFileTime()}.csv"))
            {
                using StreamWriter header = new StreamWriter($"{_logDirectory}{((DateTime)_gameStartTime).ToFileTime()}.csv");
                header.WriteLine("zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta");
            }
            using StreamWriter sw = new StreamWriter($"{_logDirectory}{((DateTime)_gameStartTime).ToFileTime()}.csv", true);
            List<int> locations = Game.GetLocations();
            sw.WriteLine($"{_gameStartTime},{Game.Moves},{locations[0] + 1},{locations[1] + 1},{locations[2] + 1},{locations[3] + 1}");
        }
    }
}
