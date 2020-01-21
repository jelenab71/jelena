using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Services;
using LolaSoft.WebShop.ViewModel.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LolaSoft.WebShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IUserService userService;
        public OrderController(IOrderService orderService, 
            IUserService userService)
        {
            this.orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }
        public IActionResult Index()
        {
            var allOrders = orderService.GetAllWithUser();
            var vm = allOrders.Select(o => new OrderViewModel
            {
                Id = o.Id,
                CreatedOn = o.CreatedOn,
                UserName = o.User?.FirstName
            });
            return View(vm);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            var allUsers = userService.GetAll();
            var vm = new CreateOrderViewModel
            {
                Users = allUsers.Select(u => new SelectListItem
                {
                    Text = u.FirstName,
                    Value = u.Id.ToString()
                }).ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            var orderDto = new OrderDto
            {
                UserId = vm.UserId, 
                CreatedOn = DateTime.UtcNow
            };

            orderService.Add(orderDto);

            return RedirectToAction("Index");
        }
    }
}