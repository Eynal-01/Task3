using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Task3.Services;
using Task3.Models;

namespace Task3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new ProductViewModel
            {
                Products=await _productService.GetAllByKey()
            };
            return View("ProductIndex", vm);
        }
    }
}
