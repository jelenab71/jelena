using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IOrderService
    {
        OrderDto GetById(int id);
        void Add(OrderDto entity);
        List<OrderDto> GetAllWithUser();
        void Update(OrderDto order);
    }
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly WebShopDbContext context;

        public OrderService(IOrderRepository orderRepository, 
                            WebShopDbContext context)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(OrderDto entity)
        {
            orderRepository.Add(OrderMapper.ToModel(entity));
            context.SaveChanges();
        }

        public List<OrderDto> GetAllWithUser()
        {
            var allOrders = orderRepository.GetAllWithUser();
            return allOrders.Select(o => OrderMapper.ToDto(o)).ToList();
        }

        public OrderDto GetById(int id)
        {
            return OrderMapper.ToDto(orderRepository.Get(id));
        }

        public void Update(OrderDto order)
        {
            var existingOrder = orderRepository.Get(order.Id);
            if (existingOrder == null)
                throw new BadRequestException();

            existingOrder.UserId = order.UserId;

            orderRepository.Update(existingOrder);
            context.SaveChanges();
        }
    }
}
