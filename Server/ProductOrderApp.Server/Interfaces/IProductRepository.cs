using SingularSystems.ProductOrderApp.Models;

namespace SingularSystems.ProductOrderApp.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
