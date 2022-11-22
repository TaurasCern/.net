using BookApi.Models.DTOs;

namespace BookApi.Interfaces
{
    public interface IBookManager
    {
        int Add(CreateBookDTO book);
        void Delete(int id);
        bool Exists(int id);
        List<GetBookDTO> Filter(Dictionary<string, string> filter);
        List<GetBookDTO> Get();
        GetBookDTO Get(int id);
        void Update(UpdateBookDTO book);
    }
}