using LolaSoft.WebShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IUserRepository : IGenericRepository<User> { }
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(WebShopDbContext context)
            :base(context)
        {

        }
    }
}
