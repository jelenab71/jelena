using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LolaSoft.WebShop.Models
{
    public class DetailsProductViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Stock Quanttity")]
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Created On")]
        public DateTime? CreatedOn { get; set; }

        public int CategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}
