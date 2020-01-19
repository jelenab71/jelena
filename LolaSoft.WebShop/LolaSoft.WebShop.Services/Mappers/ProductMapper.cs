using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class ProductMapper
    {
        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                Category = CategoryMapper.ToDto(product.Category),
                CreatedOn = product.CreatedOn,
                Price = product.Price,
                Id = product.Id,
                StockQuantity = product.StockQuantity
            };
        }

        public static Product ToModel(ProductDto product)
        {
            return new Product
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                CreatedOn = product.CreatedOn,
                Price = product.Price,
                Id = product.Id,
                StockQuantity = product.StockQuantity
            };
        }
    }
}