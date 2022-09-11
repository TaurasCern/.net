using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Log : ICloneable
    {
        public Log()
        {

        }
        public Log(DateTime gameStartTime, int move, int firstDiskLocation, int secondDiskLocation, int thirdDiskLocation, int fourthDiskLocation)
        {
            GameStartTime = gameStartTime;
            Move = move;
            FirstDiskLocation = firstDiskLocation;
            SecondDiskLocation = secondDiskLocation;
            ThirdDiskLocation = thirdDiskLocation;
            FourthDiskLocation = fourthDiskLocation;
        }
        public DateTime GameStartTime { get; set; }
        public int Move { get; set; }
        public int FirstDiskLocation { get; set; }
        public int SecondDiskLocation { get; set; }
        public int ThirdDiskLocation { get; set; }
        public int FourthDiskLocation { get; set; }

        public bool IsWon
        {
            get => FirstDiskLocation == 3
                && SecondDiskLocation == 3
                && ThirdDiskLocation == 3
                && FourthDiskLocation == 3;
        }
        /// <summary>
        /// Method to parse csv format line into log object;
        /// </summary>
        public void ParseCsv(string csv)
        {
            string[] split = csv.Split('\u002C');

            GameStartTime = DateTime.Parse(split[0]);
            Move = int.Parse(split[1]);
            FirstDiskLocation = int.Parse(split[2]);
            SecondDiskLocation = int.Parse(split[3]);
            ThirdDiskLocation = int.Parse(split[4]);
            FourthDiskLocation = int.Parse(split[5]);
        }
        /// <summary>
        /// Method to get csv format of the log
        /// </summary>
        /// <returns></returns>
        public string ToCsv() => $"{GameStartTime},{Move},{FirstDiskLocation},{SecondDiskLocation},{ThirdDiskLocation},{FourthDiskLocation}";
        /// <summary>
        /// Method to parse html cell into log object;
        /// </summary>
        public void ParseHtml(string htmlCell)
        {
            string[] lines = htmlCell.Split(Environment.NewLine);
            int i = 2;

            GameStartTime = DateTime.Parse(lines[i].Replace("<td>", "").Replace("</td>", ""));
            Move = int.Parse(lines[i + 1].Replace("<td>", "").Replace("</td>", ""));
            FirstDiskLocation = int.Parse(lines[i + 2].Replace("<td>", "").Replace("</td>", ""));
            SecondDiskLocation = int.Parse(lines[i + 3].Replace("<td>", "").Replace("</td>", ""));
            ThirdDiskLocation = int.Parse(lines[i + 4].Replace("<td>", "").Replace("</td>", ""));
            FourthDiskLocation = int.Parse(lines[i + 5].Replace("<td>", "").Replace("</td>", ""));
        }
        public object Clone()
        {
            return new Log()
            {
                GameStartTime = this.GameStartTime,
                Move = this.Move,
                FirstDiskLocation = this.FirstDiskLocation,
                SecondDiskLocation = this.SecondDiskLocation,                  
                ThirdDiskLocation = this.ThirdDiskLocation,
                FourthDiskLocation = this.FourthDiskLocation,
            };
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Log || obj == null) return false;

            Log other = obj as Log;

            return this.FirstDiskLocation == other.FirstDiskLocation 
                && this.SecondDiskLocation == other.SecondDiskLocation
                && this.ThirdDiskLocation == other.ThirdDiskLocation
                && this.FourthDiskLocation == other.FourthDiskLocation;                                     
        }
    }
}
