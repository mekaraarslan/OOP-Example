using OOP_FileWriting_Example.Models;
using System.Collections.Generic;

namespace OOP_FileWriting_Example.DB {
    static class Database {

        internal static List<Product> GetProducts() {
            var categoryX = new Category() {
                Id = 1,
                Name = "X",
                Description = "Category X"
            };

            var categoryY = new Category() {
                Id = 1,
                Name = "Y",
                Description = "Category Y"
            };

            var p1 = new Product() {
                Id = 1,
                Name = "A",
                Price = 11.3m,
                Category = categoryX
            };

            var p2 = new Product() {
                Id = 2,
                Name = "B",
                Price = 9.16m,
                Category = categoryY
            };

            var p3 = new Product() {
                Id = 3,
                Name = "C",
                Price = 3.11m,
                Category = categoryX
            };

            var products = new List<Product>() { p1, p2, p3 };

            return products;
        }

        internal static List<AppUser> GetUsers() {
            return new List<AppUser>() {
                new AppUser() {
                    Id = 1,
                    FirstName = "admin",
                    LastName = "admin",
                    UserName = "admin",
                    Password = "1234"
                }
            };
        }
    }
}
