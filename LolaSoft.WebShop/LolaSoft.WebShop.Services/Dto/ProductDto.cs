using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.Services.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public DateTime? CreatedOn { get; set; }

        public CategoryDto Category { get; set; }
    }
}
