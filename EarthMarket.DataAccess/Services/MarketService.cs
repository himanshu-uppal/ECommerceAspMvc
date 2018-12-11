using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Core;
using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Extensions;
using System.Diagnostics;

namespace EarthMarket.DataAccess.Services
{
    public class MarketService : IMarketService
    {
        private readonly IEntityRepository<Category> _categoryRepository;
        private readonly IEntityRepository<Product> _productRepository;
        private readonly IEntityRepository<ProductVariant> _productVariantRepository;
        private readonly IEntityRepository<ProductCategory> _productCategoryRepository;
        private readonly IEntityRepository<CartProductVariant> _cartProductVariantRepository;
        private readonly IEntityRepository<User> _userRepository;
        private readonly IEntityRepository<Cart> _cartRepository;
        private readonly IEntityRepository<Order> _orderRepository;
        private readonly IEntityRepository<OrderProductVariant> _orderProductVariantRepository;
        public MarketService(IEntityRepository<Category> categoryRepository,
            IEntityRepository<Product> productRepository,
            IEntityRepository<ProductCategory> productCategoryRepository,
            IEntityRepository<ProductVariant> productVariantRepository,
            IEntityRepository<User> userRepository,
            IEntityRepository<Cart> cartRepository,
            IEntityRepository<CartProductVariant> cartProductVariantRepository,
            IEntityRepository<Order> orderRepository,
            IEntityRepository<OrderProductVariant> orderProductVariantRepository
            )
        {
            this._categoryRepository = categoryRepository;
            this._productRepository = productRepository;
            this._productCategoryRepository = productCategoryRepository;
            this._productVariantRepository = productVariantRepository;
            this._userRepository = userRepository;
            this._cartRepository = cartRepository;
            this._cartProductVariantRepository = cartProductVariantRepository;
            this._orderRepository = orderRepository;
            this._orderProductVariantRepository = orderProductVariantRepository;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _categoryRepository.All;

            Debug.WriteLine("Fetching all categories  ");
            Debug.WriteLine(_categoryRepository.All);

            return categories;

        }
        public PaginatedList<Category> GetCategories(int pageIndex, int pageSize)
        {
            var categories = _categoryRepository.Paginate(pageIndex, pageSize, x => x.Key);

            Debug.WriteLine("Fetching allcategories  ");
            Debug.WriteLine(_categoryRepository.Paginate(pageIndex, pageSize, x => x.Key));

            return categories;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _productRepository.All;

            Debug.WriteLine("Fetching all products ");
            Debug.WriteLine(_productRepository.All);

            return products;

        }

        public IEnumerable<Product> GetAllProductsByCategory(IEnumerable<string> categories)
        {
            return _productRepository.GetAllProductsByCategory(_productCategoryRepository, categories);
        }
        public Product GetProduct(Guid Key)
        {
            var product = _productRepository.GetSingle(Key);

            Debug.WriteLine("Fetching  product with id -  "+ Key);
            Debug.WriteLine(_productRepository.GetSingle(Key));

            return product;

        }

        public IEnumerable<Product> SearchProducts(string searchText){            

            return _productRepository.GetAllProductsByNameOrDescription(searchText);
    }

        public IEnumerable<ProductVariant> GetAllProductVariants()
        {
            var productVariants = _productVariantRepository.All;

            Debug.WriteLine("Fetching all product variants");
            Debug.WriteLine(_productVariantRepository.All);

            return productVariants;

        }

        public ProductVariant GetProductVariant(Guid Key)
        {
            var productVariant = _productVariantRepository.GetSingle(Key);

            Debug.WriteLine("Fetching  product variant - "+ Key);
            Debug.WriteLine(_productVariantRepository.GetSingle(Key));


            return productVariant;

        }
        public User GetUser(Guid Key)
        {
            var user = _userRepository.GetSingle(Key);

            Debug.WriteLine("Fetching  user - " + Key);
            Debug.WriteLine(_userRepository.GetSingle(Key));

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

            Debug.WriteLine("Fetching  user - " + userKey);
            Debug.WriteLine(_userRepository.GetSingle(userKey));
            
            if (user == null)
            {
                return new OperationResult<Cart>(false);
            }
           
                cart.Key = Guid.NewGuid();
                _cartRepository.Add(cart);

            Debug.WriteLine("Adding new cart");

            //will check whther cart exists or not, if exists then update it

            _cartRepository.Save();           


            return new OperationResult<Cart>(true)
            {
                Entity = cart
            };
        }
        public OperationResult<CartProductVariant> AddProductVariantToCart(ProductVariant productVariant, Cart cart)
        {
            Cart verifyCart = _cartRepository.GetSingle(cart.Key);

            Debug.WriteLine("fetching cart - "+ cart.Key);
            Debug.WriteLine(_cartRepository.GetSingle(cart.Key));

            if (verifyCart== null)
            {
                return new OperationResult<CartProductVariant>(false);
            }
            ProductVariant verifyProductVariant = _productVariantRepository.GetSingle(productVariant.Key);

            Debug.WriteLine("fetching product variant - " + productVariant.Key);
            Debug.WriteLine(_productVariantRepository.GetSingle(productVariant.Key));


            if (verifyProductVariant == null)
            {
                return new OperationResult<CartProductVariant>(false);
            }
            var productVariants = _cartProductVariantRepository.    //fetching all product variants of the cart
                GetProductVariantsByCart(cart.Key);

           

            CartProductVariant cartProductVariant = null;
            bool newProductVariant = true;
            foreach(var singleProductVariant in productVariants)
            {
               
                    if (singleProductVariant.Key == productVariant.Key)
                    {
                        newProductVariant = false;
                        break;
                    }
                              

            }
            //checking whether the product variant already exists in the cart or not
            if (newProductVariant)
            {

                //add the product variant in the cart
                cartProductVariant = new CartProductVariant
                { Key = Guid.NewGuid(), Cart = cart, ProductVariant = productVariant,ProductVariantCount=1 };

                _cartProductVariantRepository.Add(cartProductVariant); //save CartProductVariant

                Debug.WriteLine("Adding new Cart Product Variant ");
           

            }
            else
            {
                // increment count for the product variant in cart
                cartProductVariant = _cartProductVariantRepository.
                    GetCartProductVariant(cart.Key, productVariant.Key);

                Debug.WriteLine("Fetching product variant - " + productVariant.Key  + " of cart -  " + cart.Key);
                Debug.WriteLine(_cartProductVariantRepository.
                    GetCartProductVariant(cart.Key, productVariant.Key));


                cartProductVariant.ProductVariantCount = cartProductVariant.ProductVariantCount + 1;
                _cartProductVariantRepository.Edit(cartProductVariant); //modify CartProductVariant

                Debug.WriteLine("Updating cart" + cart.Key);


            }

            _cartProductVariantRepository.Save();
            cart.CartProductVariants.Add(cartProductVariant);

            Debug.WriteLine("Adding Cart Product Variants to cart" + cart.Key);
            //_cartRepository.Edit(cart);  //doubt whether to do this or not
            //_cartRepository.Save();      //doubt whether to do this or not


            return new OperationResult<CartProductVariant>(true)
            {
                Entity = cartProductVariant

            };            

        }

        public OperationResult<Cart> RemoveProductVariantFromCart(ProductVariant productVariant, Cart cart)
        {
            Cart verifyCart = _cartRepository.GetSingle(cart.Key);

            Debug.WriteLine("fetching cart - " + cart.Key);
            Debug.WriteLine(_cartRepository.GetSingle(cart.Key));

            if (verifyCart == null)
            {
                return new OperationResult<Cart>(false);
            }
            ProductVariant verifyProductVariant = _productVariantRepository.GetSingle(productVariant.Key);

            Debug.WriteLine("fetching product Variant - " + productVariant.Key);
            Debug.WriteLine(_productVariantRepository.GetSingle(productVariant.Key));


            if (verifyProductVariant == null)
            {
                return new OperationResult<Cart>(false);
            }
            var productVariants = _cartProductVariantRepository.    //fetching all product variants of the cart
                GetProductVariantsByCart(cart.Key);

            CartProductVariant cartProductVariant = null;
            bool isCartProductVariant = false;
            foreach (var singleProductVariant in productVariants)
            {
               
                    //checking whether the product variant exists in the cart or not
                    if (singleProductVariant.Key == productVariant.Key)
                    {
                        isCartProductVariant = true;
                        break;
                    }
                
            }
            
            if (isCartProductVariant == false)
            {
                return new OperationResult<Cart>(false);
            }
            
            if (isCartProductVariant)
            {

                
                cartProductVariant = _cartProductVariantRepository.
                    GetCartProductVariant(cart.Key, productVariant.Key);

                if(cartProductVariant.ProductVariantCount > 1)
                {
                    //decerement product variant count
                    cartProductVariant.ProductVariantCount = cartProductVariant.ProductVariantCount - 1;
                    _cartProductVariantRepository.Edit(cartProductVariant); //modify CartProductVariant

                    Debug.WriteLine("Updating cart - " + cart.Key);
                    
                }
                else
                {
                    //remove product variant from cart
                    _cartProductVariantRepository.Delete(cartProductVariant);
                    Debug.WriteLine("Deleting - " + cart.Key);

                }              

            }
          

            _cartProductVariantRepository.Save();            
           // _cartRepository.Edit(verifyCart);  //doubt whether to do this or not
            _cartRepository.Save();      //doubt whether to do this or not


            return new OperationResult<Cart>(true)
            {
                Entity = verifyCart

            };

        }
        public OperationResult<Order> PlaceOrder(Cart cart,string shippingAddress)
        {
            //have to update product count sold in product and category when placing order
           
            Cart verifyCart = _cartRepository.GetSingle(cart.Key);

            Debug.WriteLine("fetching cart - " + cart.Key);
            Debug.WriteLine(_cartRepository.GetSingle(cart.Key));

            //not valid cart
            if (verifyCart == null)
            {
                return new OperationResult<Order>(false);
            }

            //invalid user
            if (GetUser(cart.User.Key)==null)
            {
                return new OperationResult<Order>(false);
            }

            //empty cart
            if (cart.CartProductVariants.Count() == 0)
            {
                return new OperationResult<Order>(false);
            }

            Order order = new Order
            {
                Key = Guid.NewGuid(),
                User = cart.User,
                OrderTotalPrice = cart.CartProductVariants.Sum(cpv => cpv.ProductVariant.Price * cpv.ProductVariantCount)
        };
            _orderRepository.Add(order);

            Debug.WriteLine("Adding new order");
            

            ICollection<OrderProductVariant> orderProductVariants = new List<OrderProductVariant>();

            foreach (var cartProductVariant in cart.CartProductVariants)
            {
                ProductVariant verifyProductVariant = _productVariantRepository.GetSingle(cartProductVariant.ProductVariant.Key);

                Debug.WriteLine("fetching product variant - " + cartProductVariant.ProductVariant.Key);
                Debug.WriteLine(_productVariantRepository.GetSingle(cartProductVariant.ProductVariant.Key));


                if (verifyProductVariant != null)
                {
                    OrderProductVariant orderProductVariant = new OrderProductVariant
                    {
                        Key = Guid.NewGuid(),
                        ProductVariant = cartProductVariant.ProductVariant,
                        ProductVariantCount = cartProductVariant.ProductVariantCount,
                        Order = order
                    };
                    orderProductVariants.Add(orderProductVariant);

                   

                    
                }               
                
            }

            //if there are corresponding order product variants then only save product
            if(orderProductVariants.Count > 0)
            {
                _orderRepository.Save();
            }

            //now save order product variants
            if (orderProductVariants.Count > 0)
            {
                foreach (var orderProductVariant in orderProductVariants)
                {
                    _orderProductVariantRepository.Add(orderProductVariant);

                    Debug.WriteLine("Adding order product variant");

                    //incrementing count of products sold in category and product
                    var orderProduct = orderProductVariant.ProductVariant.Product;
                    orderProduct.ProductCountSold = orderProduct.ProductCountSold + orderProductVariant.ProductVariantCount;
                    _productRepository.Edit(orderProduct);

                    Debug.WriteLine("Updating product");

                    foreach (var productCategory in orderProduct.ProductCategories)
                    {
                        productCategory.Category.ProductCountSold = productCategory.Category.ProductCountSold + 
                            orderProductVariant.ProductVariantCount;
                        _categoryRepository.Edit(productCategory.Category);
                        Debug.WriteLine("Updating category");
                    }
                }

                _orderProductVariantRepository.Save();
                _productRepository.Save();
                _categoryRepository.Save();
            }
            
            return new OperationResult<Order>(true)
            {
                Entity = order
            };
        }

        public bool DeleteCart(Cart cart)
        {
            Cart verifyCart = _cartRepository.GetSingle(cart.Key);

            Debug.WriteLine("fetching cart - " + cart.Key);
            Debug.WriteLine(_cartRepository.GetSingle(cart.Key));

            //not valid cart
            if (verifyCart == null)
            {
                return false;
            }
            var cartProductVariants = _cartProductVariantRepository.GetCartProductVariantsByCart(cart.Key);

            Debug.WriteLine("fetching cart product variants- " + cart.Key);
            Debug.WriteLine(_cartProductVariantRepository.GetCartProductVariantsByCart(cart.Key));

            //removing associated cart product variants
            foreach (var cartProductVariant in cartProductVariants)
            {
                _cartProductVariantRepository.Delete(cartProductVariant);
                Debug.WriteLine("Delteing cart product variant");
            }
            _cartProductVariantRepository.Save();
            _cartRepository.Delete(cart);
            _cartRepository.Save();
            return true;
        }

        public IEnumerable<Order> GetAllOrdersByUser(User user)
        {
            Debug.WriteLine("fetching orders of user- " + user.Key);
            Debug.WriteLine(_orderRepository.GetAll().Where(o => o.User.Key == user.Key));

            return _orderRepository.GetAll().Where(o => o.User.Key == user.Key);
        }
    }
}
