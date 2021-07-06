using System.Threading.Tasks;
using AppContract.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _product;
        
        public ProductController(IProductRepository product)
        {
            _product = product;
        }
        
        [HttpGet]
        [Route("get-products/{departmentId}")]
        public async Task<IActionResult> GetProduct(int departmentId)
        {
            return Ok(await _product.GetProducts(departmentId));
        }
    }
}