﻿using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IOrderService
    {
        OrderDto GetById(int id);
        void Add(OrderDto entity);
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

        public OrderDto GetById(int id)
        {
            return OrderMapper.ToDto(orderRepository.Get(id));
        }
    }
}