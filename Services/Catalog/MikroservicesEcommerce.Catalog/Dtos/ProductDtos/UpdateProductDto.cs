﻿namespace MikroservicesEcommerce.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public string CaategoryId { get; set; }
    }
}
