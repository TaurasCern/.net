using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Domain.Models;

namespace LINQ.Domain.Interfaces
{
    public interface IHumanFactory
    {
        IEnumerable<Character> Bind();
    }
}
