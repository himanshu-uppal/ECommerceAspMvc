using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class CategoryExtensions
    {
        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto
            {
                Key = category.Key,
                Name = category.Name,
                Products = category.ProductCategories.Select(cp=> cp.Product).Select(p => p.ToProductDto())
            };
        }

        internal static HomePageCategoryDto ToHomePageCategoryDto(this Category category, bool isTopSelling)
        {
            IEnumerable<ProductDto> ProductDtos;
            
            if (isTopSelling)
            {
                ProductDtos = category.ProductCategories.Select(cp => cp.Product)
                    .Select(p => p.ToProductDto())
                    .OrderByDescending(p => p.ProductCountSold).Take(3);
            }
            else
            {
                ProductDtos = category.ProductCategories.Select(cp => cp.Product)
                    .Select(p => p.ToProductDto())
                    .OrderByDescending(p => p.ProductCountSold).Take(5); 
            }

            return new HomePageCategoryDto
            {
                Key = category.Key,
                Name = category.Name,
                Products = ProductDtos,
                isTopSelling = isTopSelling
            };
        }
    }
}