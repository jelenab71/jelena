using LolaSoft.WebShop.Models;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Net;

namespace LolaSoft.WebShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService,
                                ICategoryService categoryService)
        {
            this.productService = productService ?? throw new ArgumentNullException(nameof(productService));
            this.categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }

        public IActionResult Index()
        {
            var allproduct = productService.GetAll();

            return View(allproduct);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var allCategories = categoryService.GetAll();

            var vm = new CreateProductViewModel()
            {
                Categories = allCategories.Select(
                    x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }).ToList()
            };

            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var productDto = new ProductDto()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                CreatedOn = DateTime.Now,
                Price = model.Price,
                StockQuantity = model.StockQuantity
            };

            productService.Add(productDto);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = productService.GetById(Id);
            var allCategories = categoryService.GetAll();
            var vm = new EditProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CreatedOn = product.CreatedOn,
                CategoryId = product.CategoryId,
                Categories = allCategories.Select(
                    x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                productService.Update(new ProductDto
                {
                    CategoryId = model.CategoryId,
                    CreatedOn = model.CreatedOn, 
                    Id = model.Id, 
                    Name = model.Name, 
                   Price = model.Price, 
                   StockQuantity = model.StockQuantity
                });                
            }
            catch (BadRequestException)
            {
                return StatusCode(400);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            var product = productService.GetById(Id);
            var allCategories = categoryService.GetAll();
            var vm = new DetailsProductViewModel()
            {
                Name = product.Name,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CreatedOn = product.CreatedOn,
                CategoryId = product.CategoryId,
                Categories = allCategories.Select(
                    x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString(),
                        Disabled = true
                    }).ToList()
            };

            return View(vm);
        }

        public IActionResult Delete(int Id)
        {
            productService.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}