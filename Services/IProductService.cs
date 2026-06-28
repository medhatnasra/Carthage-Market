using Carthage_Market.Models;
using Carthage_Market.Models.ViewModels;
using Microsoft.Identity.Client;

namespace Carthage_Market.Services
{
    public interface IProductService
    {
        public FeaturedProductsViewData GetFeaturedProducts();
        public List<Product> GetAllProducts();

        public Product GetProductDetail(int id); 

    }
}
