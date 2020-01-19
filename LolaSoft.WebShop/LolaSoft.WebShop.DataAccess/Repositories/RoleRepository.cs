using LolaSoft.WebShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role> { }
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(WebShopDbContext context)
            :base(context)
        {

        }
    }
}
