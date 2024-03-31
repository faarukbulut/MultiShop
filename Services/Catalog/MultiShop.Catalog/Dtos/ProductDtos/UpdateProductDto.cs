﻿namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage1 { get; set; }
        public string ProductImage2 { get; set; }
        public string ProductImage3 { get; set; }
        public string ProductDetail { get; set; }
        public string ProductInfo { get; set; }
        public string CategoryID { get; set; }
    }
}
