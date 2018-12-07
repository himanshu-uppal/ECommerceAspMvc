using EarthMarket.DataAccess.Core;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Services
{
   public  interface IMarketService
    {
        PaginatedList<Category> GetCategories(int pageIndex,int pageSize);
        IEnumerable<Category> GetAllCategories();

        IEnumerable<Product> GetAllProducts();
        Product GetProduct(Guid Key);
        IEnumerable<Product> GetAllProductsByCategory(IEnumerable<string> categories);

        IEnumerable<ProductVariant> GetAllProductVariants();
        ProductVariant GetProductVariant(Guid Key);

        User GetUser(Guid Key);

        OperationResult<Cart> AddCart(Guid userKey,Cart cart);
        OperationResult<CartProductVariant> AddProductVariantToCart(ProductVariant productVariant, Cart cart);
        OperationResult<Cart> RemoveProductVariantFromCart(ProductVariant productVariant, Cart cart);

        Cart GetCartByUser(Guid userKey);

        IEnumerable<Product> SearchProducts(string searchText);
    }
}
