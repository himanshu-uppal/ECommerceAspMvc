using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Core;
using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Extensions;

namespace EarthMarket.DataAccess.Services
{
    public class MarketService : IMarketService
    {
        private readonly IEntityRepository<Category> _categoryRepository;
        private readonly IEntityRepository<Product> _productRepository;
        private readonly IEntityRepository<ProductVariant> _productVariantRepository;
        private readonly IEntityRepository<ProductCategory> _productCategoryRepository;
        public MarketService(IEntityRepository<Category> categoryRepository, 
            IEntityRepository<Product> productRepository,
            IEntityRepository<ProductCategory> productCategoryRepository,
            IEntityRepository<ProductVariant> productVariantRepository
            )
        {
            this._categoryRepository = categoryRepository;
            this._productRepository = productRepository;
            this._productCategoryRepository = productCategoryRepository;
            this._productVariantRepository = productVariantRepository;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _categoryRepository.All;

            return categories;

        }
        public PaginatedList<Category> GetCategories(int pageIndex, int pageSize)
        {           
            var categories = _categoryRepository.Paginate(pageIndex, pageSize, x => x.Key);          

            return categories;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _productRepository.All;

            return products;

        }

        public IEnumerable<Product> GetAllProductsByCategory(IEnumerable<string> categories)
        {
            return _productRepository.GetAllProductsByCategory(_productCategoryRepository,categories);
        }
        public Product GetProduct(Guid Key)
        {
            var product = _productRepository.GetSingle(Key);

            return product;

        }

        public IEnumerable<ProductVariant> GetAllProductVariants()
        {
            var productVariants = _productVariantRepository.All;

            return productVariants;

        }

        public ProductVariant GetProductVariant(Guid Key)
        {
            var productVariant = _productVariantRepository.GetSingle(Key);

            return productVariant;

        }
    }
}
