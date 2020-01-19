using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.Services.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public UserDto User { get; set; }
    }
}
