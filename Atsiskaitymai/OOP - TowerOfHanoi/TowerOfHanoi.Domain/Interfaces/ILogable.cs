using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface ILogable
    {
        void Log();
        void SetConfig();
        string FormatCsvLog();
        string FormatHtmlLog();
        string FormatTxtLog();
    }
}
