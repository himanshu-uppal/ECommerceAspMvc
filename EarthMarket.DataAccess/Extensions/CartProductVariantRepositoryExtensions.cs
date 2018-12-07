using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Extensions
{
    public static class CartProductVariantRepositoryExtensions
    {
        public static IEnumerable<ProductVariant> GetProductVariantsByCart(
            this IEntityRepository<CartProductVariant> cartProductVariantRepository,Guid cartKey)
        {
            var productVariants = cartProductVariantRepository.GetAll().
                Where(cpv => cpv.Cart.Key == cartKey).
                Select(cpv=>cpv.ProductVariant);
               
            return productVariants;
        }

        public static IEnumerable<CartProductVariant> GetCartProductVariantsByCart(
           this IEntityRepository<CartProductVariant> cartProductVariantRepository, Guid cartKey)
        {
            var cartProductVariants = cartProductVariantRepository.GetAll().
                Where(cpv => cpv.Cart.Key == cartKey);                

            return cartProductVariants;
        }

        public static CartProductVariant GetCartProductVariant(
            this IEntityRepository<CartProductVariant> cartProductVariantRepository,
            Guid cartKey,Guid productVariantKey)
        {
            var cartProductVariant = cartProductVariantRepository.GetAll().
                FirstOrDefault(cpv => cpv.Cart.Key == cartKey && cpv.ProductVariant.Key == productVariantKey);

            return cartProductVariant;
        }
    }
}
