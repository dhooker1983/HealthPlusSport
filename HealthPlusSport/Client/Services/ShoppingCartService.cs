using HealthPlusSport.Client.Services.Interfaces;
using HealthPlusSport.Shared.Models;

namespace HealthPlusSport.Client.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        private List<Product> staticProducts => new List<Product>
        {
            new Product {ProductId = "1", Title = "Drink", Url = "/images/products/mineralwater-peach.jpg"},
            new Product {ProductId = "2", Title = "Food bar", Url ="/images/products/ski-coat_29940.jpg"},
            new Product {ProductId = "3", Title = "Tablet", Url ="/images/products/vitamin-magnesium.jpg"}
        };

        public event Action OnChange;

        void UpdateCart() => OnChange.Invoke();

        public async Task AddProduct(string productId)
        {
            var product = staticProducts.Where(p => p.ProductId == productId).FirstOrDefault();
            Products.Add(product);
            UpdateCart();
        }

        public async Task DecreaseQuantity(string productId)
        {
            var product = staticProducts.Where(p => p.ProductId == productId).FirstOrDefault();
            if (product != null) product.Quantity = product.Quantity--;
            UpdateCart();
        }

        public async Task DeleteProduct(string productId)
        {
            var product = staticProducts.Where(p => p.ProductId == productId).FirstOrDefault();
            Products.Remove(product);
            UpdateCart();
        }

        public async Task IncreaseQuantity(string productId)
        {
            var product = staticProducts.Where(p => p.ProductId == productId).FirstOrDefault();
            if (product != null) product.Quantity = product.Quantity++;
            UpdateCart();
        }
    }
}
