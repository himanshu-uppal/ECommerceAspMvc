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
            IDictionary<string, string> aDictionaryOfAttributeAndValue = new Dictionary<string, string>();
            var productVariantAttributeValues = productVariant.ProductVariantAttributeValues.
                Select(pv=>new {AttributeName = pv.AttributeValue.Attribute.Name,AttributeValue = pv.AttributeValue.Value.Name });

            foreach(var productVariantAttributeValue in productVariantAttributeValues)
            {
                aDictionaryOfAttributeAndValue.Add(productVariantAttributeValue.AttributeName, productVariantAttributeValue.AttributeValue);
            }

            return new ProductVariantDto
            {
                Key = productVariant.Key,
                ProductVariantAttributeValues = aDictionaryOfAttributeAndValue,
                ProductVariantPrice = productVariant.Price
            };
        }
    }
}