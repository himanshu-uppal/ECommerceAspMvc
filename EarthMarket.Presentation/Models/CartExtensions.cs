using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class CartExtensions
    {
        public  static CartDto ToCartDto(this Cart cart)
        {
            return new CartDto
            {
                Key = cart.Key,
                User = cart.User.ToUserDto(),
                CartProductVariants = cart.CartProductVariants.Select(cpv => cpv.ToCartProductVariantDto())
            };

        }

        public static CartProductVariantDto ToCartProductVariantDto(this CartProductVariant cartProductVariant)
        {
            return new CartProductVariantDto
            {
                Key = cartProductVariant.Key,
                ProductVariant = cartProductVariant.ProductVariant.ToProductVariantDto()
            };
        }
    }
}