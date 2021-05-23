using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts())
            }
        }

		private static IEnumerable<Product> GetPreconfiguredProducts()
		{
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone 11 Pro",
                    Summary = "A product from Apple Inc.",
                    Description = "Some Description",
                    ImageFile = "product-1.jpg",
                    Category = "Smart Phone",
                    Price = 90.53M
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "IPhone 11",
                    Summary = "A product from Apple Inc.",
                    Description = "Some Description",
                    ImageFile = "product-2.jpg",
                    Category = "Smart Phone",
                    Price = 90.53M
                }
            };
		}
	}
}
