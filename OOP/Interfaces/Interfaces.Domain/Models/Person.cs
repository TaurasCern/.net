using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Person : IPerson
    {
        public Person()
        {
            Name = "";
            LastName = "";
        }
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<IHobby> FavoriteMedia { get; set; }
        public List<IHobby> CheckoutList { get; set; }
        public void AddFavoriteMedia(IHobby media) { FavoriteMedia.Add(media); }

        public List<string> FindMatchingGenres(Person person, string hobbyType)
        {
            List<string> matchingGenres = new List<string>();

            foreach(IHobby media in FavoriteMedia)
            {
                if(hobbyType == media.GetHobbyName())
                {
                    foreach(IHobby otherMedia in person.FavoriteMedia)
                    {
                        if(media.Genre == otherMedia.Genre && !matchingGenres.Contains(media.Genre))
                        {
                            matchingGenres.Add(media.Genre);
                        }
                    }
                }
            }

            return matchingGenres;
        }

        public List<IHobby> FindSimilarHobbies(Person person)
        {
            List<IHobby> matchingHobbies = new List<IHobby>();

            foreach (IHobby media in FavoriteMedia)
            {
                foreach (IHobby otherMedia in person.FavoriteMedia)
                {
                    if (media.GetHobbyName() == otherMedia.GetHobbyName())
                    {
                        matchingHobbies.Add(media);
                    }
                }
            }
            return matchingHobbies;
        }

        public List<IHobby> FindSimilarHobbies(Person person, string hobbyType)
        {
            List<IHobby> matchingHobbies = new List<IHobby>();

            foreach (IHobby media in FavoriteMedia)
            {
                foreach (IHobby otherMedia in person.FavoriteMedia)
                {
                    if (media.GetHobbyName() == otherMedia.GetHobbyName() && media.GetHobbyName() == hobbyType)
                    {
                        matchingHobbies.Add(media);
                    }
                }
            }
            return matchingHobbies;
        }

        public Dictionary<string, int> GetEachHobbyAvgRating()
        {
            Dictionary<string, int> avgRatings = new Dictionary<string, int>()
            {
                { "Game", 0 },
                { "Movie", 0 },
                { "Music", 0 }
            };
            int[] count = new int[3];

            foreach(IHobby hobby in FavoriteMedia)
            {
                if(hobby.GetHobbyName() == "Game")
                {
                    avgRatings["Game"] += hobby.Rating;
                    count[0]++;
                }
                else if(hobby.GetHobbyName() == "Movie")
                {
                    avgRatings["Movie"] += hobby.Rating;
                    count[1]++;
                }
                else if(hobby.GetHobbyName() == "Music")
                {
                    avgRatings["Music"] += hobby.Rating;
                    count[2]++;
                }
            }

            avgRatings["Game"] += avgRatings["Game"] / count[0];
            avgRatings["Movie"] += avgRatings["Movie"] / count[0];
            avgRatings["Music"] += avgRatings["Music"] / count[0];

            return avgRatings;
        }

        public List<IHobby> GetFavoriteFromEachHobby()
        {
            List<IHobby> favoriteHobbies = new List<IHobby>(3);

            foreach(IHobby hobby in favoriteHobbies)
            {
                if(hobby.GetHobbyName() == "Game")
                {
                    if (favoriteHobbies[0].Rating < hobby.Rating)
                    {
                        favoriteHobbies[0] = hobby;
                    }
                }
                else if (hobby.GetHobbyName() == "Movie")
                {
                    if (favoriteHobbies[1].Rating < hobby.Rating)
                    {
                        favoriteHobbies[1] = hobby;
                    }
                }
                else if (hobby.GetHobbyName() == "Music")
                {
                    if (favoriteHobbies[2].Rating < hobby.Rating)
                    {
                        favoriteHobbies[2] = hobby;
                    }
                }
            }

            return favoriteHobbies;
        }

        public string GetFavoriteHobby()
        {
            var text = "";
            IHobby temp = new Music();

            foreach (IHobby hobby in FavoriteMedia)
            {
                if(hobby.Rating > temp.Rating)
                {
                    text = hobby.GetHobbyInformation();
                }
            }

            return text;
        }

        public string GetFavoriteHobbyType()
        {
            var text = "";
            IHobby temp = new Music();

            foreach (IHobby hobby in FavoriteMedia)
            {
                if (hobby.Rating > temp.Rating)
                {
                    text = hobby.GetHobbyName();
                }
            }

            return text;
        }

        public string GetFavoriteMusicGenre()
        {
            Dictionary<string, int> repetitionCount = new Dictionary<string, int>() { };
            KeyValuePair<string, int> temp = new KeyValuePair<string, int>("",0);
            string text = "";
            foreach (IHobby hobby in FavoriteMedia)
            {
                repetitionCount[hobby.Genre] = repetitionCount[hobby.Genre]++;
            }

            foreach(KeyValuePair<string, int> genre in repetitionCount)
            {
                if(temp.Value < genre.Value)
                {
                    text = genre.Key;
                    temp = genre;
                }
            }

            return text;
        }

        public void Interact(IHobby media)
        {
            throw new NotImplementedException();
        }

        public void ShareHobbies(Person person)
        {
            throw new NotImplementedException();
        }

        public void ShareOldMovies(Person person)
        {
            throw new NotImplementedException();
        }
        public void AddRandomToCheckList(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
