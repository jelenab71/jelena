using LolaSoft.WebShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order> 
    {
        List<Order> GetAllWithUser();
    }
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(WebShopDbContext context)
            :base(context)
        {

        }

        public List<Order> GetAllWithUser()
        {
            return context.Orders.Include(o => o.User).ToList();
        }
    }
}
