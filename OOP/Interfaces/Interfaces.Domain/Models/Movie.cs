using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Movie : IHobby
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public string GetHobbyInformation() => $"Filmas: {Name}, Zanras: {Genre}, Ivertinimas: {Rating}";

        public string GetHobbyName() => nameof(Movie);
    }
}
