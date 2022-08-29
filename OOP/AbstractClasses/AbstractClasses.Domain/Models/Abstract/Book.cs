namespace AbstractClasses.Domain.Models.Abstract
{
    public abstract class Book
    {
        public Book(string genre, string title, string author, int booksSold, int? quantity, double? price)
        {
            Genre = genre;
            Title = title;
            Author = author;
            BooksSold = booksSold;
            Quantity = quantity;
            Price = price;
        }

        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int BooksSold { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }

    }
}