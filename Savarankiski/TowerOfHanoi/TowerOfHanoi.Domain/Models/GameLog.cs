using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Models
{
    public class GameLog
    { 
        public List<Log> Logs { get; set; } = new List<Log>();
        public int Moves { get => Logs.Count; }
        public bool IsWon 
        { 
            get => Logs[Logs.Count - 1].FirstDiskLocation == 3
                && Logs[Logs.Count - 1].SecondDiskLocation == 3
                && Logs[Logs.Count - 1].ThirdDiskLocation == 3
                && Logs[Logs.Count - 1].FourthDiskLocation == 3;
        }
        public void ParseTxt(string txtLog)
        {
            string[] lines = txtLog.Split(Environment.NewLine);
            Log log = new Log(new DateTime(), 0, 1, 1, 1, 1);

            foreach (var line in lines)
            {
                if(line.Length < 1) { continue; }
                
                string[] filteredTxt = line
                    .Replace("žaidime kuris pradėtas", "")
                    .Replace("ėjimu nr", "")
                    .Replace("dalies diskas buvo paimtas iš", ",")
                    .Replace("ir padėtas į", ",")
                    .Split(",");
                log.GameStartTime = DateTime.Parse(filteredTxt[0].Trim());
                log.Move = int.Parse(filteredTxt[1].Trim());

                int size = int.Parse(filteredTxt[2].Trim());
                int placed = (int)Enum.Parse<ENumberWords>(filteredTxt[4].Trim()) - 10;
                
                if(size == 1) log.FirstDiskLocation = placed;
                if(size == 2) log.SecondDiskLocation = placed;
                if(size == 3) log.ThirdDiskLocation = placed;
                if(size == 4) log.FourthDiskLocation = placed;

                Logs.Add((Log)log.Clone());
            }
        }
        public void ParseHtml(string htmlLog)
        {
            string[] cells = htmlLog.Split("</tr>");

            for (int i = 1; i < cells.Length - 1; i++)
            {
                Log log = new Log(new DateTime(), 0, 1, 1, 1, 1);
                log.ParseHtml(cells[i]);
                Logs.Add(log);
            }
        }
        public string[] ToCsv()
        {
            string[] lines = new string[Logs.Count + 1];
            lines[0] = "zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta";

            for (int i = 0; i < Logs.Count; i++)
            {
                lines[i + 1] = Logs[i].ToCsv();
            }
            return lines;
        }
    }
}
