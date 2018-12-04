﻿using System;
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
        private readonly IEntityRepository<User> _userRepository;
        private readonly IEntityRepository<Cart> _cartRepository;
        public MarketService(IEntityRepository<Category> categoryRepository, 
            IEntityRepository<Product> productRepository,
            IEntityRepository<ProductCategory> productCategoryRepository,
            IEntityRepository<ProductVariant> productVariantRepository,
            IEntityRepository<User> userRepository,
            IEntityRepository<Cart> cartRepository
            )
        {
            this._categoryRepository = categoryRepository;
            this._productRepository = productRepository;
            this._productCategoryRepository = productCategoryRepository;
            this._productVariantRepository = productVariantRepository;
            this._userRepository = userRepository;
            this._cartRepository = cartRepository;
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
        public User GetUser(Guid Key)
        {
            var user = _userRepository.GetSingle(Key);

            return user;
        }

        public Cart GetCartByUser(Guid userKey)
        {
            Cart cart = _cartRepository.GetCartByUser(userKey);

            return cart;

        }      
        public OperationResult<Cart> AddCart(Guid userKey,Cart cart)
        {
            var user = _userRepository.GetSingle(userKey);
            if(user == null)
            {
                return new OperationResult<Cart>(false);
            }
            if(cart.Key == null)  //if there is no previous cart in database
            {
                cart.Key = Guid.NewGuid();
                _cartRepository.Add(cart);
            }
            else   //if there is previous cart in database
            {
                _cartRepository.Edit(cart);
            }
            
            _cartRepository.Save();
            return new OperationResult<Cart>(true)
            {
                Entity = cart
            };
        }
    }
}
