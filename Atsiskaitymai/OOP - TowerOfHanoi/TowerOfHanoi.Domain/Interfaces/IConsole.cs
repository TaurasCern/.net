﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface IConsole
    {
        public string Message { get; set; }
        void PrintGameBoard();
    }
}
