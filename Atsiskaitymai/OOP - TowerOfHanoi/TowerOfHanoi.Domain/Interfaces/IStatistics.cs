using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface IStatistics
    {
        bool IsUntilWin { get; set; }
        string CreateStatistics();
        Dictionary<string, string> FindFilePriority(string[] files);
    }
}
