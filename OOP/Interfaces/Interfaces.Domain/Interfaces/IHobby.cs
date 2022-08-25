using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Models;

namespace Interfaces.Domain.Interfaces
{
    public interface IHobby
    {
        string Name { get; }
        string Publisher { get; }
        string Genre { get; }
        int Rating { get; }
        string GetHobbyName();
        string GetHobbyInformation();
    }
}
