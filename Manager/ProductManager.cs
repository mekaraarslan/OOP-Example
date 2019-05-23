using OOP_FileWriting_Example.DB;
using OOP_FileWriting_Example.Models;
using System.Collections.Generic;

namespace OOP_FileWriting_Example.Manager {
    class ProductManager {

        internal List<Product> GetFilteredProductsByPrice(decimal price) {
            var allProducts = Database.GetProducts();
            var filteredProducts = new List<Product>();

            foreach (var product in allProducts) {
                if (product.Price < price)
                    filteredProducts.Add(product);
            }

            return filteredProducts;            
        }

        internal List<Product> GetAllProducts() {
            return Database.GetProducts();
        }
    }
}
