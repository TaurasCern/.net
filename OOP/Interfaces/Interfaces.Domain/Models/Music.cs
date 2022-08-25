using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Music : IHobby
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }
        
        public int Rating { get; set; }

        public string GetHobbyInformation() => $"Daina: {Name}, Zanras: {Genre}, Ivertinimas: {Rating}";

        public string GetHobbyName() => nameof(Music);
    }
}
