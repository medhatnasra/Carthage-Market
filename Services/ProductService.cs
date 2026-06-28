using Carthage_Market.Context;
using Carthage_Market.Models;
using Carthage_Market.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Carthage_Market.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _myDbContext ; 
        public ProductService(AppDbContext db)
        {
            _myDbContext = db; 
        }
        public FeaturedProductsViewData GetFeaturedProducts()
        {
            return new FeaturedProductsViewData
            {
                Categories = _myDbContext.Categories.ToList(),
                Products = _myDbContext.Products.ToList()

            }; 
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _myDbContext.Products.ToList();
            return products; 
        }

        public Product GetProductDetail(int id)
        {
            Product product = _myDbContext.Products.Include(p => p.Category).FirstOrDefault(p => p.ID == id);
  

            return product; 
        }
    }
}
