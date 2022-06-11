using HealthPlusSport.Shared.Models;

namespace HealthPlusSport.Client.Services.Interfaces
{
    public interface IShoppingCartService
    {
        event Action OnChange;
        List<Product> Products { get; }
        Task AddProduct(string productId);
        Task DeleteProduct(string productId);
        Task DecreaseQuantity(string productId);
        Task IncreaseQuantity(string productId);
    }
}
