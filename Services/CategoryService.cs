using Carthage_Market.Context;
using Carthage_Market.Models;
using Microsoft.EntityFrameworkCore;

namespace Carthage_Market.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _mydbcontext ; 
        public CategoryService (AppDbContext db) { 
            _mydbcontext  = db;
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _mydbcontext.Categories.ToList();
            
            
            return categories; 
        }
    }
}
