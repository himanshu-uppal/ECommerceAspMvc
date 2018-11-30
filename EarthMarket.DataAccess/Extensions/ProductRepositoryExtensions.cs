using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Extensions
{
    public static class ProductRepositoryExtensions
    {
        public static IEnumerable<Product> GetAllProductsByCategory(this IEntityRepository<Product> productRepository, IEntityRepository<ProductCategory> productCategoryRepository,IEnumerable<string> categories)
        {
            var productCategoriesMappings = productCategoryRepository.GetAll();
            var allProducts = new HashSet<Product>();
            foreach (var category in categories)
            {
                var products = productCategoriesMappings.Where(pc => pc.Category.Name == category).Select(pc=>pc.Product);
                Console.WriteLine(products.Select(p => p.Name));
                foreach(var product in products)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;           

        }
    }
}
