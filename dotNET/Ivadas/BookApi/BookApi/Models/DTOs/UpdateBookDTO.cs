using BookApi.Enums;

namespace BookApi.Models.DTOs
{
    public class UpdateBookDTO
    {
        public int Id { get; set; }
        public DateTime Isleista { get; set; }
        public string Autorius { get; set; }
        public string Pavadinimas { get; set; }
        public string KnygosTipas { get; set; }
    }
}
