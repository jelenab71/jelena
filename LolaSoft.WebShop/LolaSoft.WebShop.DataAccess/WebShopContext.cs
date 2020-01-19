using LolaSoft.WebShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LolaSoft.WebShop.DataAccess
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(12, 10);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Clothes" 
                    
                },
                new Category
                {
                    Id = 2,
                    Name = "Pet"
                },
                new Category
                {
                    Id = 3,
                    Name = "House"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Jacket",
                    CreatedOn = DateTime.Now,
                    Price = 12.2m,
                    StockQuantity = 42
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Shirt",
                    CreatedOn = DateTime.Now,
                    Price = 10.2m,
                    StockQuantity = 11
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Sweater",
                    CreatedOn = DateTime.Now,
                    Price = 25.2m,
                    StockQuantity = 35
                },
                new Product
                {
                    Id = 4,
                    CategoryId =2 ,
                    Name = "Dog Toy",
                    CreatedOn = DateTime.Now,
                    Price = 3.2m,
                    StockQuantity = 18
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Name = "Bowl",
                    CreatedOn = DateTime.Now,
                    Price = 1.2m,
                    StockQuantity = 15
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Name = "Fork",
                    CreatedOn = DateTime.Now,
                    Price = 2.2m,
                    StockQuantity = 25
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Name = "wash mashine",
                    CreatedOn = DateTime.Now,
                    Price = 122.5m,
                    StockQuantity = 41
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Name = "knife",
                    CreatedOn = DateTime.Now,
                    Price = 1.5m,
                    StockQuantity = 30
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Name = "spoon",
                    CreatedOn = DateTime.Now,
                    Price = 1.4m,
                    StockQuantity = 38
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Name = "dinner table",
                    CreatedOn = DateTime.Now,
                    Price = 65.5m,
                    StockQuantity = 47
                }
            );
        }
    }
}
