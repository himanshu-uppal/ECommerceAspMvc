﻿using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class ProductExtensions
    {
        public static ProductDto ToProductDto(this Product product)
        {
            IEnumerable<ProductVariantDto> productVariants = null;
            IEnumerable<string> productImages = null;
            if (null != product.ProductVariants)
            {
                productVariants = product.ProductVariants.Select(pv => { if (pv != null) { return pv.ToProductVariantDto(); }
                    else { return new ProductVariantDto(); } });
            }
            if (null != product.ProductImages)
            {
                productImages = product.ProductImages.Select(pi => pi.ImagePath);
            }

            return new ProductDto
            {
                Key = product.Key,
                Name = product.Name,
                ProductCountSold = product.ProductCountSold,
                Categories = product.ProductCategories.Select(pc => pc.Category).Select(c => c.Name),
                ProductVariants= productVariants,
                ProductImages = productImages,
                Description = product.Description
            };
        }
    }
}