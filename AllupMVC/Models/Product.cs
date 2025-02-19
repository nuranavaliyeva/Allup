﻿namespace AllupMVC.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public decimal ExTax { get; set; }
        public bool IsAvailable {  get; set; }

        //relational
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
   

    }
}
