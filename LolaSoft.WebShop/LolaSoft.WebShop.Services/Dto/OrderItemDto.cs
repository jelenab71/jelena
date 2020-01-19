using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.Services.Dto
{
    public class OrderItemDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public OrderDto Order { get; set; }

        public int Quantity { get; set; }
    }
}
