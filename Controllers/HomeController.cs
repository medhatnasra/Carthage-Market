using System.Diagnostics;
using Carthage_Market.Models;
using Carthage_Market.Models.ViewModels;
using Carthage_Market.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carthage_Market.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _CategoryService;
        private readonly IProductService _ProductService; 

        public HomeController(ICategoryService CategoryService,IProductService ProductService)
        {
            _CategoryService = CategoryService;
            _ProductService = ProductService;
        }

        public IActionResult Index()
        {
            FeaturedProductsViewData FproductsData = _ProductService.GetFeaturedProducts();
            return View(FproductsData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Categories()
        {
            List<Category> categories = _CategoryService.GetCategories();
            return View(categories);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                }
            );
        }
    }
}
