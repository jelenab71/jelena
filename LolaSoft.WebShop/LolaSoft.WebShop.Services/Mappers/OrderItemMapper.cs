using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class OrderItemMapper
    {
        public static OrderItem ToModel(OrderItemDto orderItemDto)
        {
            return new OrderItem()
            {
                Id = orderItemDto.Id,
                OrderId = orderItemDto.OrderId,
                Quantity = orderItemDto.Quantity
            };
        }

        public static OrderItemDto ToDto(OrderItem orderItem)
        {
            return new OrderItemDto()
            {
                Id = orderItem.Id,
                OrderId = orderItem.OrderId,
                Quantity = orderItem.Quantity
            };
        }
    }
}
