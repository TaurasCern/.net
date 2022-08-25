using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Models;

namespace Interfaces.Domain.Interfaces
{
    public interface IPerson
    {
        void Interact(IHobby media);
        string GetFavoriteHobbyType();
        string GetFavoriteHobby();
        List<IHobby> GetFavoriteFromEachHobby();
        string GetFavoriteMusicGenre();
        Dictionary<string, int> GetEachHobbyAvgRating();
        void ShareHobbies(Person person);
        void ShareOldMovies(Person person);
        List<IHobby> FindSimilarHobbies(Person person);
        List<IHobby> FindSimilarHobbies(Person person, string hobbyType);
        List<string> FindMatchingGenres(Person person, string hobbyType);
    }
}
