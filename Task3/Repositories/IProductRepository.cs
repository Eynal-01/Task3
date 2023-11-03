using System.Collections.Generic;
using System.Threading.Tasks;
using Task3.Entities;

namespace Task3.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        System.Threading.Tasks.Task Add(Product product);      

    }
}
