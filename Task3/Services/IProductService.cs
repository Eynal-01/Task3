using System.Collections.Generic;
using System.Threading.Tasks;
using Task3.Entities;

namespace Task3.Services
{
    public interface IProductService
    {
       public Task<List<Product>> GetAllByKey(string key = "");
    }
}
