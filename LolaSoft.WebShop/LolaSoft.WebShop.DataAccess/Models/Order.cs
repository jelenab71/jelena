using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Models
{
    public class Order : IModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedOn { get; set; }
                        
        public User User { get; set; }        
    }
}
