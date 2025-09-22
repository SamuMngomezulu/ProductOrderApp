using Microsoft.EntityFrameworkCore;
using SingularSystems.ProductOrderApp.Data;
using SingularSystems.ProductOrderApp.Models;
using SingularSystems.ProductOrderApp.Interfaces;

namespace SingularSystems.ProductOrderApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ModelDbContext _context;

        public ProductRepository(ModelDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}