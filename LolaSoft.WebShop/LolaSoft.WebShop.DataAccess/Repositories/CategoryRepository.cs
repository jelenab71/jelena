using LolaSoft.WebShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetAllWithParentCategory();
    }
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(WebShopDbContext context)
            :base(context)
        {

        }

        public List<Category> GetAllWithParentCategory()
        {
            return context.Categories.Include(x => x.ParentCategory).ToList();
        }
    }
}
