using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.ViewModel.Order
{
    public class CreateOrderViewModel
    {
        public int UserId { get; set; }
        public  List<SelectListItem> Users { get; set; }
    }
}
