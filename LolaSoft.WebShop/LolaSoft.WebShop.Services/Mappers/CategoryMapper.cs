using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class CategoryMapper
    {
        public static Category ToModel(CategoryDto categoryDto)
        {
            return new Category()
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                ParentCategoryId = categoryDto.ParentCategoryId
            };
        }

        public static CategoryDto ToDto(Category category)
        {
            if (category == null)
                return null;

                return new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                ParentCategoryId = category.ParentCategoryId
            };
        }
    }
}
