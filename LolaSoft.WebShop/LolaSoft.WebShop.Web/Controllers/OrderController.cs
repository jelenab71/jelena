using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LolaSoft.WebShop.Services.Services;
using LolaSoft.WebShop.ViewModel.Order;
using Microsoft.AspNetCore.Mvc;

namespace LolaSoft.WebShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }
        public IActionResult Index()
        {
            var allOrders = orderService.GetAllWithUser();
            var vm = allOrders.Select(o => new OrderViewModel
            {
                Id = o.Id,
                CreatedOn = o.CreatedOn,
                UserName = o.User.FirstName
            });
            return View(vm);
        }
    }
}