using System;
using AppEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEntity.Database
{
    public static class AppData
    {
        public static void SeedData(this ModelBuilder builder)
        {
            /*Admin*/
            builder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    Description = "Produce",
                    Name = "Produce",
                    CreatedBy = 1,
                    IsActive="Y",
                    CreatedTime = DateTime.Now
                },
                new Department
                {
                    DepartmentId = 2,
                    Description = "Groceries",
                    Name = "Groceries",
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                }
            );

            /*Role*/
            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Tomatoes",
                    Description = "Tomatoes",
                    DepartmentId = 1,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Ginger",
                    Description = "Ginger",
                    DepartmentId = 2,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Brocolli",
                    Description = "Brocolli",
                    DepartmentId = 2,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Lettuce",
                    Description = "Lettuce",
                    DepartmentId = 1,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                }, new Product
                {
                    ProductId = 5,
                    Name = "Baking Powder",
                    Description = "Baking Powder",
                    DepartmentId = 2,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                }, new Product
                {
                    ProductId = 6,
                    Name = "Chocolate",
                    Description = "Chocolate",
                    DepartmentId = 1,
                    CreatedBy = 1,
                    IsActive = "Y",
                    CreatedTime = DateTime.Now
                }
            );

            /*UserRole*/
            builder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    ProductId = 1,
                    CreatedBy = 1,
                    CreatedTime = DateTime.Now
                },
                new Order
                {
                    OrderId = 2,
                    ProductId = 2,
                    CreatedBy = 1,
                    CreatedTime = DateTime.Now
                }
            );
        }
    }
}