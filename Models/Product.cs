﻿namespace OOP_FileWriting_Example.Models {
    class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }

        public override string ToString() {
            return $"{Name} - {Price}";
        }
    }
}
