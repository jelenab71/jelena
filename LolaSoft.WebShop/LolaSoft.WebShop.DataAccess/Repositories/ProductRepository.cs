using LolaSoft.WebShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetAllWithCategories();
    }
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(WebShopDbContext context) : base(context)
        {

        }

        public List<Product> GetAllWithCategories()
        {
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}