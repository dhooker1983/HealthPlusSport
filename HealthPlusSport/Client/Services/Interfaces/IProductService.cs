using HealthPlusSport.Shared.Models;

namespace HealthPlusSport.Client.Services.Interfaces
{
    public interface IProductService
    {
        Task Add(Product product);
        Task Delete(string id);
        Task<Product> Get(string id);
        Task<IEnumerable<Product>> GetAll();
        Task Update(Product product); //this could take a string as a parameter, not sure yet.
    }
}
