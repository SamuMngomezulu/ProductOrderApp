using Microsoft.AspNetCore.Mvc;
using SingularSystems.ProductOrderApp.Models;
using SingularSystems.ProductOrderApp.Interfaces; 


namespace SingularSystems.ProductOrderApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProductsAsync();

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}
