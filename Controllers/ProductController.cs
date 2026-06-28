using Carthage_Market.Models;
using Carthage_Market.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carthage_Market.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService ProductService) { 
        
            _productService = ProductService;
        }
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAllProducts(); 
            return View(products);
        }

        public IActionResult Details(int id) {

            Product product = _productService.GetProductDetail(id); 
            return View(product); 
        
        }
    }
}
