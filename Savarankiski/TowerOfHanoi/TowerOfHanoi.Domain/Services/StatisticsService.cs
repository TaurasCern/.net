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
        public bool IsUntilWin { get; set; } = true;
        public string CreateStatistics()
        {
            var gameLog = new GameLog();
            var log = new Log();
            StringBuilder sb = Header();

            Dictionary<string, string> filesFitlered = FindFilePriority();

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
        private string FormatWinCell(Log log) 
            => IsUntilWin ? (log.IsWon ? log.Move.ToString() : "N/B") : (log.IsWon ? (log.Move - 15).ToString() : "N/B");
        private StringBuilder Header()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("---------------------------------------------------------------{0}", Environment.NewLine));
            sb.Append(String.Format("| {0,-20} | {1,-26} | Pokytis |{2,26}", "Žaidimo data", IsUntilWin ? "Ėjimų kiekis iki laimėjimo" : "Perteklinių ėjimų kiekis", Environment.NewLine));
            sb.Append(String.Format("---------------------------------------------------------------{0}", Environment.NewLine));

            return sb;
        }
        private StringBuilder AppendLog(StringBuilder sb, Log log)
        {
            if (sb.ToString().Split(Environment.NewLine).Length < 4)
            {
                sb.Append(String.Format("| {0,-20} | {1,-26} | {2,-7} |{3}", log.GameStartTime, FormatWinCell(log), "N/G", Environment.NewLine));
                sb.Append($"---------------------------------------------------------------{Environment.NewLine}");
            }
            else
            {
                sb.Append(String.Format("| {0,-20} | {1,-26} | {2,-7} |{3}",
                    log.GameStartTime, FormatWinCell(log),
                    _previousLog.IsWon && log.IsWon ? log.Move - _previousLog.Move : "N/G",
                    Environment.NewLine));
                sb.Append($"---------------------------------------------------------------{Environment.NewLine}");

            }

            _previousLog = log.IsWon ? (Log)log.Clone() : _previousLog;

            return sb;
        }
        private Dictionary<string, string> FindFilePriority()
        {
            string[] filesCsv = Directory.GetFiles(_logDirectory, "*.csv");
            string[] filesHtml = Directory.GetFiles(_logDirectory, "*.html");
            string[] filesTxt = Directory.GetFiles(_logDirectory, "*.txt");
            Dictionary<string, string> filePriority = new Dictionary<string, string>();

            foreach (var fileCsv in filesCsv)
            {
                string[] split = fileCsv.Split("\\")[fileCsv.Split("\\").Length - 1].Split('.');
                filePriority[split[0]] = split[1];
            }
            foreach (var fileHtml in filesHtml)
            {
                string[] split = fileHtml.Split("\\")[fileHtml.Split("\\").Length - 1].Split('.');
                filePriority[split[0]] = split[1];
            }
            foreach (var fileTxt in filesTxt)
            {
                string[] split = fileTxt.Split("\\")[fileTxt.Split("\\").Length - 1].Split('.');
                filePriority[split[0]] = split[1];
            }

            return filePriority;
        }
    }
}
