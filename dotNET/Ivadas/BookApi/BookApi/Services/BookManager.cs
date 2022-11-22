using BookApi.Interfaces;
using BookApi.Models.Concrete;
using BookApi.Models.DTOs;

namespace BookApi.Services
{
    public class BookManager : IBookManager
    {
        private readonly IBookSet _context;
        private readonly IBookWrapper _wrapper;

        public BookManager(IBookSet context, IBookWrapper wrapper)
        {
            _context = context;
            _wrapper = wrapper;
        }

        public List<GetBookDTO> Get()
            => _context.Books.Select(b => _wrapper.Bind(b)).ToList();

        public GetBookDTO Get(int id)
            => _wrapper.Bind(_context.Books.Find(b => b.Id == id));

        public bool Exists(int id)
            => _context.Books.Exists(b => b.Id == id);

        public List<GetBookDTO> Filter(Dictionary<string, string> filter)
        {
            IEnumerable<Book> books = _context.Books;
            foreach (var item in filter)
            {
                if (item.Key == "Pavadinimas") books = books.Where(b => b.Title.ToLower() == item.Value.ToLower());
                if (item.Key == "Autorius") books = books.Where(b => b.Author.ToLower() == item.Value.ToLower());
                if (item.Key == "KnygosTipas") books = books.Where(b => (int)b.Cover == int.Parse(item.Value));
            }

            return books.Select(b => _wrapper.Bind(b)).ToList();
        }
        public int Add(CreateBookDTO book)
        {
            var bookToAdd = _wrapper.Bind(book);
            _context.
                Books.Add(bookToAdd);
            return bookToAdd.Id;
        }
        public void Update(UpdateBookDTO book)
        {
            var bookToUpdate = _context.Books.Find(b => b.Id == book.Id);
            bookToUpdate = _wrapper.Bind(book);
        }
        public void Delete(int id)
        {
            int delelteIndex = 0;
            for (int i = 0; i < _context.Books.Count; i++)
            {
                if (_context.Books[i].Id == id)
                {
                    delelteIndex = i;
                    break;
                }
            }
            _context.Books.RemoveAt(delelteIndex);
        }
    }
}
