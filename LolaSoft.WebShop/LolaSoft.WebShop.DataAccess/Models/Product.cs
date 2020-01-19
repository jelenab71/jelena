using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LolaSoft.WebShop.DataAccess.Models
{
    public class Product : IModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public int StockQuantity { get; set; }

        [Column(TypeName = "decimal(7, 2)")]
        public decimal Price { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
