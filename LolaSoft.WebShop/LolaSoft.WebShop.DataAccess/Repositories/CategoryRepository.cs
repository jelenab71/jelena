using LolaSoft.WebShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetAll();
    }
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(WebShopDbContext context)
            :base(context)
        {

        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

    }
}
