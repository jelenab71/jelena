using LolaSoft.WebShop.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.Models
{
    public class CreateProductViewModel
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
