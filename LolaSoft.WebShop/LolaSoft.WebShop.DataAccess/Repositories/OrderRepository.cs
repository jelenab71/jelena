using LolaSoft.WebShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order> { }
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(WebShopDbContext context)
            :base(context)
        {

        }
    }
}
