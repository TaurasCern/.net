using BookApi.Enums;

namespace BookApi.Models.DTOs
{
    public class FilterBookRequest
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public string KnygosTipas { get; set; }
    }
}
