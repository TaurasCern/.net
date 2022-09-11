using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Services
{
    public class StatisticsService : IStatistics
    {
        public StatisticsService()
        {
            _previousLog = new Log();   
        }
        private Log _previousLog;
        private string _logDirectory = $"{Environment.CurrentDirectory}\\Logs\\";
        public bool IsUntilWin { get; set; } = true; // flag to select statistics table | true - moves until completion, false - moves over perfect win
        /// <summary>
        /// Method to create statistics out of the final logs out of the log files
        /// </summary>
        /// <returns>table of statistics</returns>
        public string CreateStatistics()
        {
            var gameLog = new GameLog();
            var log = new Log();
            StringBuilder sb = Header();

            Dictionary<string, string> filesFitlered = FindFilePriority(Directory.GetFiles(_logDirectory));

            foreach(var file in filesFitlered)
            {

                if (file.Value == "csv")
                {
                    string[] fileCsv =  File.ReadAllLines(_logDirectory + file.Key + "." + file.Value);
                    log.ParseCsv(fileCsv[fileCsv.Length - 1]);
                }
                else if(file.Value == "html")
                {
                    string fileHtml = File.ReadAllText(_logDirectory + file.Key + "." + file.Value);
                    string[] htmlCells = fileHtml.Split("</tr>");
                    log.ParseHtml(htmlCells[htmlCells.Length - 2]);
                }
                else if(file.Value == "txt")
                {
                    string fileTxt = File.ReadAllText(_logDirectory + file.Key + "." + file.Value);
                    gameLog.ParseTxt(fileTxt);
                    log = (Log)gameLog.Logs[gameLog.Logs.Count - 1].Clone();
                }
                AppendLog(sb, log);
            }

            _previousLog = new Log();
            return sb.ToString();
        }
        /// <summary>
        /// Method to format completion move count cell according to IsUntilWin flag
        /// </summary>
        /// <param name="log">log</param>
        /// <returns>Formatted cell</returns>
        private string FormatWinCell(Log log) 
            => IsUntilWin ? (log.IsWon ? log.Move.ToString() : "N/B") : (log.IsWon ? (log.Move - 15).ToString() : "N/B");
        private StringBuilder Header()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("----------------------------------------------------------------{0}", Environment.NewLine));
            sb.Append(String.Format("| {0,-21} | {1,-26} | Pokytis |{2,26}", "Žaidimo data", IsUntilWin ? "Ėjimų kiekis iki laimėjimo" : "Perteklinių ėjimų kiekis", Environment.NewLine));
            sb.Append(String.Format("----------------------------------------------------------------{0}", Environment.NewLine));

            return sb;
        }
        /// <summary>
        /// Method to add row to the given StringBuilder
        /// </summary>
        /// <param name="sb">given StringBuilder</param>
        /// <param name="log">Log to add</param>
        /// <returns>Table with appended log</returns>
        public StringBuilder AppendLog(StringBuilder sb, Log log)
        {
            sb.Append(String.Format("| {0,-21} | {1,-26} | {2,-7} |{3}",
                log.GameStartTime, FormatWinCell(log),
                _previousLog.IsWon && log.IsWon ? log.Move - _previousLog.Move : "N/G",
                Environment.NewLine));
            sb.Append($"----------------------------------------------------------------{Environment.NewLine}");

            _previousLog = log.IsWon ? (Log)log.Clone() : _previousLog;

            return sb;
        }
        /// <summary>
        /// Method to find log files priority(txt => html => csv)
        /// </summary>
        /// <param name="files">log file directories</param>
        /// <returns>Dictionary<Dir\Filename, extension></returns>
        public Dictionary<string, string> FindFilePriority(string[] files)
        {
            Dictionary<string, string> filePriority = new Dictionary<string, string>();

            foreach (var file in files)
            {
                string[] split = file.Split("\\")[file.Split("\\").Length - 1].Split('.');
                if (split[1] == "csv")
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
                if (split[1] == "txt")
                {
                    filePriority[split[0]] = split[1];
                }
            }

            return filePriority;
        }
    }
}
