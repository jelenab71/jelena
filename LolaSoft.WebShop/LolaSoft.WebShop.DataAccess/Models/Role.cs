using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Models
{
    public class Role : IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
