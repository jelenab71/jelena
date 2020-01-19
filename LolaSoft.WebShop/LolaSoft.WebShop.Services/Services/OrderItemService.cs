using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IOrderItemService 
    {
        void Add(OrderItemDto entity);
        OrderItemDto GetbyId(int id);
    }
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository orderItemRepository;
        private readonly WebShopDbContext context;

        public OrderItemService(IOrderItemRepository orderItemRepository, 
                                WebShopDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.orderItemRepository = orderItemRepository ?? throw new ArgumentNullException(nameof(orderItemRepository));
        }
        public void Add(OrderItemDto entity)
        {
            orderItemRepository.Add(OrderItemMapper.ToModel(entity));
            context.SaveChanges();
        }

        public OrderItemDto GetbyId(int id)
        {
            return OrderItemMapper.ToDto(orderItemRepository.Get(id));
        }
    }
}
