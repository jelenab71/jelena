using LolaSoft.WebShop.Services.Services;
using LolaSoft.WebShop.Web.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;
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
    }
}