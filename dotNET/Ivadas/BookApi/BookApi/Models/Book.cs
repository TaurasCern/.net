namespace BookApi.Models
{
    public class Book
    {
        public Book(int id,string title, string author, int releaseYear)
        {
            Id = id;
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

    }
}
