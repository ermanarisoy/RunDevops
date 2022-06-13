using Shopping.Client.Models;
using System.Collections.Generic;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Name = "Product 1",
                Description = "Description 1",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Product 2",
                Description = "Description 2",
                ImageFile = "product-2.png",
                Price = 850.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Product 3",
                Description = "Description 3",
                ImageFile = "product-3.png",
                Price = 750.00M,
                Category = "Smart Phone"
            }
        };
    }
}
