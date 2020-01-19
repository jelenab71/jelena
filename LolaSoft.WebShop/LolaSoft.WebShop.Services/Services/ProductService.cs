using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IProductService
    {
        ProductDto GetById(int id);
        void Add(ProductDto productDto);
        List<ProductDto> GetAll();
        void Update(ProductDto productDto);
        void Delete(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly WebShopDbContext context;

        public ProductService(WebShopDbContext context,
            IProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ProductDto GetById(int id) 
        {
            return ProductMapper.ToDto(productRepository.Get(id));
        }

        public void Add(ProductDto productDto)
        {
            productRepository.Add(ProductMapper.ToModel(productDto));

            context.SaveChanges();
        }

        public List<ProductDto> GetAll()
        {
            var allProducts = productRepository.GetAllWithCategories();

            return allProducts.Select(ProductMapper.ToDto).ToList();
        }

        public void Update(ProductDto model)
        {
            var existingProduct = GetById(model.Id);
            if (existingProduct == null)
                throw new BadRequestException();

            existingProduct.Name = model.Name;
            existingProduct.Price = model.Price;
            existingProduct.StockQuantity = model.StockQuantity;
            existingProduct.CreatedOn = model.CreatedOn;
            existingProduct.CategoryId = model.CategoryId;
            existingProduct.Id = model.Id;

            productRepository.Update(ProductMapper.ToModel(existingProduct));

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var existingProduct = GetById(id);
            if (existingProduct == null)
                throw new BadRequestException();

            productRepository.Delete(ProductMapper.ToModel(existingProduct));
        }
    }
}
