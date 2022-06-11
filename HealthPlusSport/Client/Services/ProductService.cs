using HealthPlusSport.Client.Services.Interfaces;
using HealthPlusSport.Shared.Models;

namespace HealthPlusSport.Client.Services
{
    public class ProductService : IProductService
    {
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
