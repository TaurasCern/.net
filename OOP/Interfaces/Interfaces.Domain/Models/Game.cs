using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Game : IHobby
    {
        public int Id { get; set; }
        public string Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public string GetHobbyInformation() => $"Zaidimas: {Name}, Zanras: {Genre}, Ivertinimas: {Rating}";

        public string GetHobbyName() => nameof(Game);
    }
}
