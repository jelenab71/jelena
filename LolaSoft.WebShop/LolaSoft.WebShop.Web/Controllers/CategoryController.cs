using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Services;
using LolaSoft.WebShop.Web.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace LolaSoft.WebShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }
        public IActionResult Index()
        {
            var allcategories = categoryService.GetAllWithParentCategory();
            var categories = allcategories.Select(c =>
            new CategoryViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                ParentCategoryName = c.ParentCategory?.Name,
                ParentCategoryId = c.ParentCategoryId
            }).ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var category = categoryService.GetById(Id);
            if (category == null)
                return NotFound();

            var allCategories = categoryService.GetAll();

            var vm = new EditCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                ParentCategory = allCategories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditCategoryViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            try
            {
                categoryService.Update(new CategoryDto()
                {
                    Id = vm.Id,
                    Name = vm.Name,
                    ParentCategoryId = vm.ParentCategoryId
                });
            }
            catch (BadRequestException)
            {
                return StatusCode(400);
            }

            return RedirectToAction("Index");
        }
    }
}