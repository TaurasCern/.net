using BookApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookApi.Models.Concrete
{
    public class Book
    {
        public Book()
        {

        }
        public Book(int id, string title, string author,ECoverType cover, int releaseYear)
        {
            Id = id;
            Title = title;
            Author = author;
            Cover = cover;
            ReleaseYear = releaseYear;
        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType Cover { get; set; }
        public int ReleaseYear { get; set; }

    }
}
