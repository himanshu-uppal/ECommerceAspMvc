using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class ProductVariantExtensions
    {
        public static ProductVariantDto ToProductVariantDto(this ProductVariant productVariant)
        {
            string productVariantName = productVariant.Product.Name;
            IDictionary<string, string> aDictionaryOfAttributeAndValue = new Dictionary<string, string>();
            IEnumerable<string> productVariantImages = null;
            if (productVariant == null)
            {
                return new ProductVariantDto();
            }
            var productVariantAttributeValues = productVariant.ProductVariantAttributeValues.
                Select(pv=>new {AttributeName = pv.AttributeValue.Attribute.Name,AttributeValue = pv.AttributeValue.Value.Name });

            foreach(var productVariantAttributeValue in productVariantAttributeValues)
            {
                aDictionaryOfAttributeAndValue.Add(productVariantAttributeValue.AttributeName, productVariantAttributeValue.AttributeValue);
            }
            if (null != productVariant.ProductVariantImages)
            {
                productVariantImages = productVariant.ProductVariantImages.Select(pvi => pvi.ImagePath);
            }

            foreach(var productVariantAttributeValue in productVariantAttributeValues)
            {
                productVariantName = productVariantName + " " + "(" + productVariantAttributeValue.AttributeValue + ")";
            }

            return new ProductVariantDto
            {
                Key = productVariant.Key,
                ProductVariantAttributeValues = aDictionaryOfAttributeAndValue,
                ProductVariantPrice = productVariant.Price,
                ProductVariantImages = productVariantImages,
                ProductVariantName = productVariantName
            };
        }
    }
}