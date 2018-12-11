using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EarthMarket.DataAccess.Extensions
{
    public static class ProductRepositoryExtensions
    {
        public static IEnumerable<Product> GetAllProductsByCategory(this IEntityRepository<Product> productRepository,
            IEntityRepository<ProductCategory> productCategoryRepository,
            IEnumerable<string> categories)
        {
            var productCategoriesMappings = productCategoryRepository.GetAll();

            Debug.WriteLine("Fetching all Product and categories Entries ");
            Debug.WriteLine(productCategoryRepository.GetAll());

            var allProducts = new HashSet<Product>();
            foreach (var category in categories)
            {
                var products = productCategoriesMappings.Where(pc => pc.Category.Name == category).Select(pc=>pc.Product);

                Debug.WriteLine("Fetching all Product of category -  " + category);
                Debug.WriteLine(productCategoriesMappings.Where(pc => pc.Category.Name == category).Select(pc => pc.Product));


                foreach (var product in products)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;           

        }

        public static IEnumerable<Product> GetAllProductsByNameOrDescription(this IEntityRepository<Product> productRepository,
            string searchText)
        {
            Debug.WriteLine("Fetching all Products having  -  " + searchText + " in Name or description");
            Debug.WriteLine(productRepository.GetAll().Where(p => p.Name.Contains(searchText) || p.Description.Contains(searchText)));

            return productRepository.GetAll().Where(p => p.Name.Contains(searchText) || p.Description.Contains(searchText));

        }
    }
}
