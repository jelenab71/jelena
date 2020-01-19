using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class OrderMapper
    {
        public static Order ToModel(OrderDto orderDto)
        {
            return new Order()
            {
                Id = orderDto.Id,
                CreatedOn = orderDto.CreatedOn,
                UserId = orderDto.UserId
            };
        }

        public static OrderDto ToDto(Order order)
        {
            return new OrderDto()
            {
                Id = order.Id,
                CreatedOn = order.CreatedOn,
                UserId = order.UserId
            };
        }
    }
}
