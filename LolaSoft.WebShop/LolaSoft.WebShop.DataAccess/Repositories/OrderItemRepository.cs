using LolaSoft.WebShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IOrderItemRepository : IGenericRepository<OrderItem> { }
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(WebShopDbContext context)
            :base(context)
        {

        }
    }
}
