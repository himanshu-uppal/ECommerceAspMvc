using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class CartProductVariantExtensions
    {
        public static CartProductVariantDto ToCartProductVariantDto(this CartProductVariant cartProductVariant)
        {
            return new CartProductVariantDto
            {
                Key = cartProductVariant.Key,
                ProductVariant = cartProductVariant.ProductVariant.ToProductVariantDto(),
                ProductVariantCount = cartProductVariant.ProductVariantCount
            };
        }
    }
}