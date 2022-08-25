using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Figura
    {
        public Figura(string name)
        {
            Name = name;
        }
        public readonly string Name;
    }
}
