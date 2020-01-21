using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.ViewModel.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
        [Display(Name ="User name")]
        public string UserName { get; set; }
    }
}
