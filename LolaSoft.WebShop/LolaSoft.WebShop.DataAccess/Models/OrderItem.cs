using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Models
{
    public class OrderItem : IModel
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int Quantity { get; set; }
    }
}
