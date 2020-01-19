using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LolaSoft.WebShop.Services.Services
{
    public interface ICategoryService
    {
        CategoryDto GetById(int id);
        void Add(CategoryDto entity);
        List<CategoryDto> GetAll();
        List<CategoryDto> GetAllWithParentCategory();
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly WebShopDbContext context;

        public CategoryService(ICategoryRepository categoryRepository, 
                                WebShopDbContext context)
        {
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(CategoryDto entity)
        {
            categoryRepository.Add(CategoryMapper.ToModel(entity));
            context.SaveChanges();
        }

        public List<CategoryDto> GetAll()
        {
            var allCategories = categoryRepository.GetAll();

            return  allCategories.Select(CategoryMapper.ToDto).ToList();
        }

        public List<CategoryDto> GetAllWithParentCategory()
        {
            var allCategoriesWithParentCategory = categoryRepository.GetAll();
            return allCategoriesWithParentCategory.Select(CategoryMapper.ToDto).ToList();
        }

        public CategoryDto GetById(int id)
        {
            return CategoryMapper.ToDto(categoryRepository.Get(id));
        }
    }
}
