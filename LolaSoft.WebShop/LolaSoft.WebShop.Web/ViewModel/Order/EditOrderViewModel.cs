using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LolaSoft.WebShop.ViewModel.Order
{
    public class EditOrderViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public IList<SelectListItem> Users { get; set; }
    }
}
