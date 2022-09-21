using DapperExample.Database.Models;

namespace DapperExample.Database
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> Get();
        int Delete(string name);
    }
}